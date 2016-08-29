using System;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

using Entities.Base;
using Data.Interfaces.Base;

namespace Data.Base
{
    public abstract class ReadOnlyBaseRepository<T> : IReadOnlyRepository<T> where T : BaseEntity
    {
        private readonly MyDbContext _myDbContext;

        protected ReadOnlyBaseRepository(MyDbContext myDbContext)
        {
            _myDbContext = myDbContext;
            _myDbContext.Database.Log = sql => Debug.WriteLine(sql);
        }

        protected MyDbContext MyDbContext
        {
            get { return _myDbContext; }
        }

        public int Count(Expression<Func<T, bool>> where)
        {
            return Get().Count(where);
        }
        public int Count()
        {
            return Get().Count();
        }

        public bool Exists(Expression<Func<T, bool>> where)
        {
            return Get().Any(where);
        }

        public IQueryable<T> GetAll(params Expression<Func<T, object>>[] includes)
        {
            return Get(includes);
        }

        public IQueryable<T> GetBy(Expression<Func<T, bool>> where, params Expression<Func<T, object>>[] includes)
        {
            return Get(includes).Where(where);
        }

        public async Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> where,
            params Expression<Func<T, object>>[] includes)
        {
            return await Get(includes).Where(where).FirstOrDefaultAsync();
        }

        public async Task<int> CountAsync()
        {
            return await Get().CountAsync();
        }

        public async Task<bool> ExistsAsync(Expression<Func<T, bool>> where)
        {
            return await Get().AnyAsync(where);
        }

        #region Additional helper methods

        //additional Helper method
        protected IQueryable<T> Get(params string[] includes)
        {
            var query = MyDbContext.Set<T>().AsQueryable();

            if (includes != null && includes.Any())
            {
                query = includes.Aggregate(query, (current, item) => current.Include(item));
            }

            return query;
        }
        private IQueryable<T> Get<TProperty>(params Expression<Func<T, TProperty>>[] includes)
        {
            var query = MyDbContext.Set<T>().AsQueryable();

            if (includes != null && includes.Length > 0)
            {
                query = includes.Aggregate(query, (current, item) => current.Include(item));
            }
            return query;
        }

        #endregion Additional helper methods
    }
}
