using MediatR;
using System.Linq;

namespace Domain.Queries.Requests
{
    public class GetUsuariosQueryRequest : IRequest<IQueryable<UsuarioResponse>> 
    {
        public GetUsuariosQueryRequest(int quantidade)
        {
            Quantidade = quantidade;
        }

        public int Quantidade { get; set; }
    }
}