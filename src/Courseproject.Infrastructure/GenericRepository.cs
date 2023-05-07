using Courseproject.Common.Interfaces;
using Courseproject.Common.Model;

namespace Courseproject.Infrastructure
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<T>> GetAsync(int? skip, int? take, params System.Linq.Expressions.Expression<Func<T, object>>[] includes)
        {
            throw new NotImplementedException();
        }

        public Task<T?> GetByIdAsync(params System.Linq.Expressions.Expression<Func<T, object>>[] includes)
        {
            throw new NotImplementedException();
        }

        public Task<List<T>> GetFilteredAsync(System.Linq.Expressions.Expression<Func<T, bool>>[] filters, int? skip, int? take, params System.Linq.Expressions.Expression<Func<T, object>>[] includes)
        {
            throw new NotImplementedException();
        }

        public Task<int> InsertAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
