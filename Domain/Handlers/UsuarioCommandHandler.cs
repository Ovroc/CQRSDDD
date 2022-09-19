using Domain.Commands.Requests;
using Domain.Interfaces;
using Domain.Models;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Domain.Handlers
{
    public class UsuarioCommandHandler :
        IRequestHandler<CreateUsuarioRequest, UsuarioResponse>,
        IRequestHandler<UpdateUsuarioRequest, UsuarioResponse>,
        IRequestHandler<RemoveUsuarioRequest, bool>
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioCommandHandler(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public async Task<UsuarioResponse> Handle(CreateUsuarioRequest request, CancellationToken cancellationToken)
        {
            var model = new Usuario(request.Nome, request.Sobrenome, request.Email, request.DataNascimento, request.EscolaridadeId);

            if (!Validate(model)) return null;

            var result = await _usuarioRepository.CreateAsync(model);

            return new UsuarioResponse
            {
                Id = result.Id,
                Nome = result.Nome,
                Sobrenome = result.Sobrenome,
                Email = result.Email,
                DataNascimento = result.DataNascimento,
                EscolaridadeId = result.EscolaridadeId,
                DateAdd = result.DateAdd,
                DateUp = result.DateUp
            };
        }

        public async Task<UsuarioResponse> Handle(UpdateUsuarioRequest request, CancellationToken cancellationToken)
        {
            var model = new Usuario(request.Id, request.Nome, request.Sobrenome, request.Email, request.DataNascimento, request.EscolaridadeId);

            if (!Validate(model)) return null;

            var result = await _usuarioRepository.UpdateAsync(model);

            return new UsuarioResponse
            {
                Id = result.Id,
                Nome = result.Nome,
                Sobrenome = result.Sobrenome,
                Email = result.Email,
                DataNascimento = result.DataNascimento,
                EscolaridadeId = result.EscolaridadeId,
                DateAdd = result.DateAdd,
                DateUp = result.DateUp
            };
        }

        public async Task<bool> Handle(RemoveUsuarioRequest request, CancellationToken cancellationToken)
        {
            var usuario = await _usuarioRepository.GetUsuarioById(request.Id);

            if (usuario == null)
                return false;

            return await _usuarioRepository.DeleteAsync(usuario);                        
        }

        private bool Validate(Usuario usuario)
        {
            return usuario.IsValidEmail() && usuario.IsValidBirthDate() && usuario.IsValidSchooling();
        }
    }
}
