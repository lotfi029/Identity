using Microsoft.EntityFrameworkCore;
using Models.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EF.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly AppDbContext _dbContext;
        private DbSet<T> _dbSet;
        public BaseRepository(AppDbContext context)
        {
            _dbContext = context;
            _dbSet = context.Set<T>();
        }
        public async Task Add(T entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<T> GetById(string Id)
        {
            return await _dbSet.FindAsync(Id);
        }

        public async Task<T> GetByName(string Name)
        {
            return await _dbSet.FindAsync(Name);
        }

        public void Update(T entity)
        {
            _dbSet.Update(entity);
        }
    }
}
