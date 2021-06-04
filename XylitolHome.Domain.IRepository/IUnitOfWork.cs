using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace XylitolHome.Domain.IRepository
{
    public interface IUnitOfWork
    {
        Task<int> SaveChangsAsync();
    }
}
