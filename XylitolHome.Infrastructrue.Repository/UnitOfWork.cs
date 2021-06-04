using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using XylitolHome.Domain.IRepository;

namespace XylitolHome.Infrastructrue.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationContext _dbContext;

        public UnitOfWork(ApplicationContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<int> SaveChangsAsync()
        {
             return await _dbContext.SaveChangesAsync();
        }
    }
}
