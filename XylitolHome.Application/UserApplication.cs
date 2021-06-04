using System;
using System.Collections.Generic;
using System.Text;
using XylitolHome.Domain.Entities;
using XylitolHome.Domain.IRepository;
using XylitolHome.Domain.IService;

namespace XylitolHome.Infrastructure.Service
{
    public class UserApplication : IUserApplication
    {
        private readonly IBaseRepository _baseRepository;

        public UserApplication(IBaseRepository baseRepository)
        {
            _baseRepository = baseRepository;
        }

        public UserEntity Query(string id)
        {
            return _baseRepository.FirstOrDefault<UserEntity>(a => a.Id == id);
        }
    }
}
