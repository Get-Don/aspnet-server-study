using System.Linq.Expressions;

namespace ApiServer.Repository.DB.Interface
{
    public interface IRepository<T> where T : class
    {
        Task<List<T>> GetAllAsync(long accountId, Expression<Func<T, bool>>? filter = null);
        Task<T?> GetByIdAsync(long id);
        Task CreateAsync(T entity);
        Task RemoveAsync(T entity);
        Task SaveAsync();
    }
}
