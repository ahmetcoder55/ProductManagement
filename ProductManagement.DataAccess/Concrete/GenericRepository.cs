using Microsoft.EntityFrameworkCore;
using ProductManagement.DataAccess.Abstract;
using ProductManagement.Entities.Abstract;
using ProductManagement.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace ProductManagement.DataAccess.Concrete
{
    public class GenericRepository<TEntity, TContext> : IGenericRepository<TEntity>
     where TEntity : BaseEntity, IEntity
        where TContext:DbContext
    {

        //Dependency Injection
        protected readonly TContext _context;

        public GenericRepository(TContext context)
        {
            _context = context;
        }

        public async Task AddAsync(TEntity entity)
        {
            await _context.Set<TEntity>().AddAsync(entity);
        }

        public void Delete(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
        }

        public async Task<List<TEntity>> GetAllAsync()
        {
            return await _context.Set<TEntity>().ToListAsync();
        }

        public async Task<TEntity?> GetByIdAsync(int id)
        {
            return await _context.Set<TEntity>().FindAsync(id);
        }

        public async Task<List<TEntity>> GetWhereAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await _context.Set<TEntity>().Where(predicate).ToListAsync();
        }

        public void Update(TEntity entity)
        {
            _context.Set<TEntity>().Update(entity);
        }
    }
}
