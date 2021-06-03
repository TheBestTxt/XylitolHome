using System;
using System.Collections.Generic;
using System.Text;

namespace XylitolHome.Common.Interfaces
{
    public class Entity
    {
        /// <summary>
        /// 实体主键
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// 最后修改时间
        /// </summary>
        public DateTime LastEditTime { get; set; }
    }
}
