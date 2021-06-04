using System;
using System.Collections.Generic;
using System.Text;

namespace XylitolHome.Common.Interfaces
{
    public interface IEntity
    {
        /// <summary>
        /// 实体主键
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// 最后修改时间
        /// </summary>
        public DateTime? LastEditTime { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
