using Domain.Models;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IUsuarioRepository : IRepository<Usuario> 
    {
        IQueryable<Usuario> GetAll(int quantidade);
        Task<Usuario> GetUsuarioById(int usuarioid);
    }
}
