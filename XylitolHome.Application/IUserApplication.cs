using System;
using System.Collections.Generic;
using System.Text;
using XylitolHome.Domain.Entities;

namespace XylitolHome.Domain.IService
{
    public interface IUserApplication
    {
        UserEntity Query(string id);
    }
}
