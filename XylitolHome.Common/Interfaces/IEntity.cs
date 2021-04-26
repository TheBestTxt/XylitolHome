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
        Guid ID { get; set; }

    }
}
