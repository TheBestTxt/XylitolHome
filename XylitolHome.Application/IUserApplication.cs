using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using XylitolHome.Domain.Dto;
using XylitolHome.Domain.Entities;

namespace XylitolHome.Domain.IService
{
    public interface IUserApplication
    {
        UserEntity Query(string id);

        Task Add(AddUser request);
    }
}
