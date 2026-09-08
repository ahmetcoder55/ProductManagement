using ProductManagement.Entities.Abstract;
using ProductManagement.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace ProductManagement.DataAccess.Abstract
{
    public interface IGenericRepository<T> where T:BaseEntity,IEntity
    {
        Task<List<T>> GetAllAsync();
        Task<List<T>> GetWhereAsync(Expression<Func<T, bool>> predicate);
        Task<T?> GetByIdAsync(int id);
        Task AddAsync(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
