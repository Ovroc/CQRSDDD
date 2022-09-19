using Application.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IUsuarioService
    {
        Task<IEnumerable<ResponseUsuarioViewModel>> GetAll(int quantidade = 10);
        Task<ResponseUsuarioViewModel> GetById(int id);
        Task<ResponseUsuarioViewModel> Register(RequestUsuarioViewModel usuarioViewModel);
        Task<ResponseUsuarioViewModel> Update(RequestUsuarioViewModel usuarioViewModel);
        Task<bool> Remove(int id);
    }
}
