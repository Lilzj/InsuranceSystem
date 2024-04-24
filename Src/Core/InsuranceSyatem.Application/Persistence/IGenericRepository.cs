using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

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
