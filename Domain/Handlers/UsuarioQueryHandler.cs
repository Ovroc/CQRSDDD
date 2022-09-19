using Domain.Interfaces;
using Domain.Queries.Requests;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Domain.Handlers
{
    public class UsuarioQueryHandler :
        IRequestHandler<GetUsuarioByIdQueryRequest, UsuarioResponse>,
        IRequestHandler<GetUsuariosQueryRequest, IQueryable<UsuarioResponse>>
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioQueryHandler(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public async Task<UsuarioResponse> Handle(GetUsuarioByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var result =  await _usuarioRepository.GetUsuarioById(request.Id);

            if (result == null)
                return null;

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

        public async Task<IQueryable<UsuarioResponse>> Handle(GetUsuariosQueryRequest request, CancellationToken cancellationToken)
        {
            var result = _usuarioRepository.GetAll(request.Quantidade);

            return result.Select(s => new UsuarioResponse
            {
                Id =s.Id,
                Nome = s.Nome,
                Sobrenome = s.Sobrenome,
                Email = s.Email,
                DataNascimento = s.DataNascimento,
                EscolaridadeId = s.EscolaridadeId,
                DateAdd = s.DateAdd,
                DateUp = s.DateUp
            });
        }
    }
}
