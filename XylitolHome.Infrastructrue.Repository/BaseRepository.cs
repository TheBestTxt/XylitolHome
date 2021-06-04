using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using XylitolHome.Common.Interfaces;
using XylitolHome.Domain.IRepository;

namespace XylitolHome.Infrastructrue.Repository
{
    public class BaseRepository : IBaseRepository
    {
        private readonly ApplicationContext _dbContext;

        public BaseRepository(ApplicationContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<TEntity> Query<TEntity>() where TEntity : class, IEntity, new()
        {
            return _dbContext.Set<TEntity>().ToList();
        }

        public List<TEntity> Query<TEntity>(Expression<Func<TEntity, bool>> where) where TEntity : class, IEntity, new()
        {
            return _dbContext.Set<TEntity>().Where(where).ToList();
        }

        public async Task<List<TEntity>> QueryAsync<TEntity>() where TEntity : class, IEntity, new()
        {
            return await _dbContext.Set<TEntity>().ToListAsync();
        }

        public async Task<List<TEntity>> QueryAsync<TEntity>(Expression<Func<TEntity, bool>> where) where TEntity : class, IEntity, new()
        {
            return await _dbContext.Set<TEntity>().Where(where).ToListAsync();
        }

        public TEntity FirstOrDefault<TEntity>(Expression<Func<TEntity, bool>> where) where TEntity : class, IEntity, new()
        {
            return _dbContext.Set<TEntity>().FirstOrDefault(where);
        }

        public async Task<TEntity> FirstOrDefaultAsync<TEntity>(Expression<Func<TEntity, bool>> where) where TEntity : class, IEntity, new()
        {
            return await _dbContext.Set<TEntity>().FirstOrDefaultAsync(where);
        }

       public void Entry<TEntity>(TEntity entity) where TEntity : class, IEntity, new()
        {
            _dbContext.Entry(entity).;
        }
    }
}
