using MediatR;

namespace Domain.Queries.Requests
{
    public class GetUsuarioByIdQueryRequest : IRequest<UsuarioResponse>
    {
        public GetUsuarioByIdQueryRequest(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
