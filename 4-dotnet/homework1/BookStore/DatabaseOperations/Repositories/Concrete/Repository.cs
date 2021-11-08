using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using BookStore.DatabaseOperations.Repositories.Abstract;
using BookStore.Entity;
using Microsoft.EntityFrameworkCore;

namespace BookStore.DatabaseOperations.Repositories.Concrete
{

    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly DataContext _context;

        private readonly DbSet<TEntity> _table;

        public Repository(DataContext context)
        {
            _context = context;
            _table = _context.Set<TEntity>();
        }

        public async Task<TEntity> AddAsync(TEntity entity)
        {
            await _table.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<IEnumerable<TEntity>> AddRangeAsync(IEnumerable<TEntity> entities)
        {
            await _table.AddRangeAsync(entities);
            await _context.SaveChangesAsync();
            return entities;
        }

        public async Task<List<TEntity>> GetAllAsync()
        {
            return await _table.ToListAsync();
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            return await _table.FindAsync(id);
        }

        public void Remove(TEntity entity)
        {
            _table.Remove(entity);
            _context.SaveChanges();
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            _table.RemoveRange(entities);
            _context.SaveChanges();
        }

        public async Task<TEntity> SingleOrDefaultAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await _table.SingleOrDefaultAsync(predicate);

        }

        public TEntity Update(TEntity entitiy)
        {
            _context.Entry(entitiy).State = EntityState.Modified;

            _context.SaveChanges();

            return entitiy;

        }

        public async Task<IEnumerable<TEntity>> Where(Expression<Func<TEntity, bool>> predicate)
        {
            return await _table.Where(predicate).ToListAsync();
        }
    }


}