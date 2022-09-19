using Data.Context;
using Domain.Interfaces;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class UsuarioRepository : Repository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(OneContext context) : base(context) { }

        public IQueryable<Usuario> GetAll(int quantidade)
        {
            return _context.Usuarios.Take(quantidade);
        }

        public Task<Usuario> GetUsuarioById(int usuarioid)
        {
            return _context.Usuarios
                .AsNoTracking()
                .Where(w => w.Id == usuarioid)
                .FirstOrDefaultAsync();
        }
    }
}
