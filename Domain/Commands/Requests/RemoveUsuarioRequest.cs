using MediatR;

namespace Domain.Commands.Requests
{
    public class RemoveUsuarioRequest : IRequest<bool>
    {
        public RemoveUsuarioRequest(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
