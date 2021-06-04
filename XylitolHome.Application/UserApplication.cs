using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using XylitolHome.Domain.Dto;
using XylitolHome.Domain.Entities;
using XylitolHome.Domain.IRepository;
using XylitolHome.Domain.IService;

namespace XylitolHome.Infrastructure.Service
{
    public class UserApplication : IUserApplication
    {
        private readonly IBaseRepository _baseRepository;
        private readonly IUnitOfWork _unitOfWork;

        public UserApplication(IBaseRepository baseRepository,
             IUnitOfWork unitOfWork)
        {
            _baseRepository = baseRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task Add(AddUser request)
        {
            var userEntity = new UserEntity();
            userEntity.Create(request);
            await _unitOfWork.SaveChangsAsync();

        }

        public UserEntity Query(string id)
        {
            return _baseRepository.FirstOrDefault<UserEntity>(a => a.Id == id);
        }
    }
}
