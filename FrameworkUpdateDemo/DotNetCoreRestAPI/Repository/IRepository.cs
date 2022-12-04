using System.Linq.Expressions;

namespace DotNetCoreRestAPI.Repository
{
    public interface IRepository<T> where T : class
    {
        Task<T> GetById(int id);
        Task<T> GetById(Guid id);
        Task<IList<T>> GetAll();
        Task<IEnumerable<T>> Find(Expression<Func<T, bool>> predicate);
        Task Add(T entity);
        Task Update(T entity);
        Task Delete(T entity);
    }
}
