using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using XylitolHome.Common.Interfaces;

namespace XylitolHome.Domain.IRepository
{
    public interface IBaseRepository
    {
        List<TEntity> Query<TEntity>() where TEntity : class, IEntity, new();

        List<TEntity> Query<TEntity>(Expression<Func<TEntity, bool>> where) where TEntity : class, IEntity, new();

        Task<List<TEntity>> QueryAsync<TEntity>() where TEntity : class, IEntity, new();

        Task<List<TEntity>> QueryAsync<TEntity>(Expression<Func<TEntity, bool>> where) where TEntity : class, IEntity, new();

        TEntity FirstOrDefault<TEntity>(Expression<Func<TEntity, bool>> where) where TEntity : class, IEntity, new();

        Task<TEntity> FirstOrDefaultAsync<TEntity>(Expression<Func<TEntity, bool>> where) where TEntity : class, IEntity, new();
    }
}
