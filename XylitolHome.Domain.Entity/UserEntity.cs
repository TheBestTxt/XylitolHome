using System;
using System.Collections.Generic;
using System.Text;
using XylitolHome.Common.Interfaces;
using XylitolHome.Domain.Dto;

namespace XylitolHome.Domain.Entities
{
    public class UserEntity : IEntity, ISoftWare, IAggregateRoot
    {
        #region property
        public string NickName { get; set; }
        public string Mobile { get; set; }
        public string Password { get; set; }
        public bool IsDeleted { get; set; }
        public string Account { get; set; }
        public string Id { get; set; }
        public DateTime? LastEditTime { get; set; }
        public DateTime? CreateDate { get; set; }
        #endregion


        #region method

        public void Create(AddUser request)
        {
            this.Password = request.Password;
            this.NickName = request.NickName;
            this.Mobile = request.Mobile;
            this.Account = request.Account;
            this.Id = Guid.NewGuid().ToString("N");
            this.CreateDate = DateTime.Now;
        }

        #endregion
    }
}
