using InsuranceSystem.Application.Persistence;
using InsuranceSystem.Persistence.DBContext;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace InsuranceSystem.Persistence.Reprositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly InsuranceDbContext _ctx;
        public GenericRepository(InsuranceDbContext ctx)
        {
            _ctx = ctx;
        }

        public void Delete(T entity) => _ctx.Set<T>().Remove(entity);

        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> predicate)
          => await _ctx.Set<T>().FirstOrDefaultAsync(predicate);

        public virtual async Task<IEnumerable<T>> GetWhere(Expression<Func<T, bool>> predicate)
         => await _ctx.Set<T>().Where(predicate).ToListAsync();

        public async Task<IEnumerable<T>> GetAllAsync()
            => await _ctx.Set<T>().ToListAsync();

        public void Insert(T entity) => _ctx.Set<T>().AddAsync(entity);

        public void Update(T entity) => _ctx.Entry(entity).State = EntityState.Modified;

        public async Task<T> IncludeAsync(Expression<Func<T, bool>> predicate, string includeProperties = "")
        {
            IQueryable<T> query = _ctx.Set<T>();
            query = _IncludeProperties(query, includeProperties);
            return query.FirstOrDefault(predicate);
        }

        public async Task<IEnumerable<T>> AllIncludeAsync(Expression<Func<T, bool>> predicate, string includeProperties = "")
        {
            IQueryable<T> query = _ctx.Set<T>();
            query = _IncludeProperties(query, includeProperties);
            return query.Where(predicate).ToList();
        }



        private IQueryable<T> _IncludeProperties(IQueryable<T> query, string properties)
        {
            if (!string.IsNullOrEmpty(properties))
            {
                foreach (var property in properties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(property.Trim());
                }
            }
            return query;
        }
    }
}
