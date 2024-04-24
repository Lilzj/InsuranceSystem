using System.Linq.Expressions;

namespace InsuranceSystem.Application.Persistence
{
    public interface IGenericRepository<T>
    {
        Task<T> GetSingleAsync(Expression<Func<T, bool>> predicate);
        Task<IEnumerable<T>> GetWhere(Expression<Func<T, bool>> predicate);
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> IncludeAsync(Expression<Func<T, bool>> predicate, string includeProperties = "");
        Task<IEnumerable<T>> AllIncludeAsync(Expression<Func<T, bool>> predicate, string includeProperties = "");
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
