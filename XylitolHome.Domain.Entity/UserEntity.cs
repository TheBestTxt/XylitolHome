using System;
using System.Collections.Generic;
using System.Text;
using XylitolHome.Common.Interfaces;

namespace XylitolHome.Domain.Entities
{
    public class UserEntity : IEntity, ISoftWare, IAggregateRoot
    {
        #region property
        public string NickName { get; set; }
        public string Mobile { get; set; }
        public string Password { get; set; }
        public bool IsDeleted { get; set; }
        public string Id { get; set; }
        public DateTime? LastEditTime { get; set; }
        public DateTime? CreateDate { get; set; }
        #endregion


        #region method

        public void Create(
            string nickName,
            string mobile,
            string password)
        {
            this.Password = password;
            this.NickName = nickName;
            this.Mobile = mobile;
        }

        #endregion
    }
}
