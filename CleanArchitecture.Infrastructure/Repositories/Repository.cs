using CleanArchitecture.Core.Repositories;
using CleanArchitecture.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Infrastructure.Repositories
{
    public class Repository<T> : IRepository<T>, IRepositoryAsync<T> where T : class
    {
        private readonly Context context;
        private DbSet<T> db;

        #region Contructor
        public Repository(Context context)
        {
            this.context = context;
            db = context.Set<T>();
        }
        #endregion

        #region Sync Methods
        public void Add(T entity)
        {
            db.Add(entity);
        }

        public List<T> GetAll()
        {
            return db.ToList();
        }

        public T GetById(int id)
        {
            return db.Find(id);
        }

        public void Delete(int id)
        {
            var entity = db.Find(id);
            if (entity == null)
              throw new Exception($"User Id {id} Not Found");
            db.Remove(entity);
        }        

        public void Update(T Entity)
        {
            context.Entry(Entity).State = EntityState.Modified;            
        }
        #endregion

        #region Async Methods
        public async Task AddAsync(T entity)
        {
            await db.AddAsync(entity);
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await db.FindAsync(id);
            if (entity == null)
              throw new Exception($"User Id {id} Not Found");
            db.Remove(entity);
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await db.ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await db.FindAsync(id);
        }

        public async Task UpdateAsync(T Entity)
        {
          db.Attach(Entity);
          context.Entry(Entity).State = EntityState.Modified;
          await  Task.FromResult(0);
        }
    #endregion
  }
}
