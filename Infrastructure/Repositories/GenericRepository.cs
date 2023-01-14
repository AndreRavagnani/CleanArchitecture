using Domain.Interfaces;
using Domain.Primitive;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace Data.Repositories
{
    public abstract class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private readonly AppDbContext _context;
        private readonly DbSet<T> _dbSet;

        protected GenericRepository(AppDbContext appDbContext, DbSet<T> dbSet)
        {
            _context = appDbContext;
            _dbSet = dbSet;
        }

        public virtual async Task<int> AddAsync(T entity)
        {
            _dbSet.Add(entity);
            _context.SaveChanges();
            return entity.Id;
        }

        public virtual async Task<bool> DeleteAsync(T entity)
        {
            _dbSet.Remove(entity);
            _context.SaveChanges();
            return true;
        }

        public virtual async Task<IReadOnlyList<T>> GetAllAsync()
        {

            return _dbSet.ToList();
        }

        public virtual async Task<T> GetByIdAsync(int id)
        {
            return _dbSet.Find(id);
        }

        public virtual async Task<bool> UpdateAsync(T entity)
        {
            _dbSet.Update(entity);
            _context.SaveChanges();
            return true;
        }
    }
}
