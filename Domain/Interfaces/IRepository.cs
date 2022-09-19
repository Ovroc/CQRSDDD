using System;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        Task<TEntity> CreateAsync(TEntity model);

        Task<TEntity> UpdateAsync(TEntity model);

        Task<bool> DeleteAsync(TEntity model);

        Task<int> SaveAsync();
    }
}
