using Application.Interfaces;
using Application.ViewModels;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Domain.Commands.Requests;
using Domain.Queries.Requests;
using MediatR;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;

        public UsuarioService(IMapper mapper, IMediator mediator)
        {
            _mapper = mapper;
            _mediator = mediator;
        }

        public async Task<IEnumerable<ResponseUsuarioViewModel>> GetAll(int quantidade = 10)
        {
            var queryGetUsuarios = new GetUsuariosQueryRequest(quantidade);
            var result = await _mediator.Send(queryGetUsuarios);

            return result.ProjectTo<ResponseUsuarioViewModel>(_mapper.ConfigurationProvider);
        }

        public async Task<ResponseUsuarioViewModel> GetById(int id)
        {
            var queryGetUsuarioById = new GetUsuarioByIdQueryRequest(id);
            var result = await _mediator.Send(queryGetUsuarioById);

            return _mapper.Map<ResponseUsuarioViewModel>(result);
        }

        public async Task<ResponseUsuarioViewModel> Register(RequestUsuarioViewModel usuarioViewModel)
        {
            var registerCommand = _mapper.Map<CreateUsuarioRequest>(usuarioViewModel);
            var result = await _mediator.Send(registerCommand);

            return _mapper.Map<ResponseUsuarioViewModel>(result);
        }

        public async Task<bool> Remove(int id)
        {
            var removeCommand = new RemoveUsuarioRequest(id);
            return await _mediator.Send(removeCommand);
        }

        public async Task<ResponseUsuarioViewModel> Update(RequestUsuarioViewModel usuarioViewModel)
        {
            var updateCommand = _mapper.Map<UpdateUsuarioRequest>(usuarioViewModel);
            var result = await _mediator.Send(updateCommand);

            return _mapper.Map<ResponseUsuarioViewModel>(result);
        }
    }
}
