using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace CleanArchitecture.Core.Repositories
{
    public interface IRepository <T> where T : class
    {
        void Add(T entity);
        T GetById(int id);
        List<T> GetAll();
        //List<T> GetBy(Expression<Func<T, bool>> predicate);
        void Update(T entity);
        void Delete(int id);
    }
}
