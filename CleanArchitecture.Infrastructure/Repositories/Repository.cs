using CleanArchitecture.Core.Repositories;
using CleanArchitecture.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Infrastructure.Repositories
{
    public class Repository<T> : IRepository<T>, IRepositoryAsync<T> where T : class
    {
        private readonly Context context;
        private DbSet<T> entities;

        #region Contructor
        public Repository(Context context)
        {
            this.context = context;
            entities = context.Set<T>();
        }
        #endregion

        #region Sync Methods
        public void Add(T entity)
        {
            entities.Add(entity);
            context.SaveChanges();
        }

        public List<T> GetBy(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }        

        public void Update(T Entity)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Async Methods
        public async Task AddAsync(T entity)
        {
            await entities.AddAsync(entity);
            await context.SaveChangesAsync();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<T>> GetByAsync(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(T Entity)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
