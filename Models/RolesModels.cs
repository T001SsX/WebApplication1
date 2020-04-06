using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    /// <summary>
    /// 身份/权限表
    /// </summary>
    public class RolesModels
    {
        /// <summary>
        /// 编号
        /// </summary>
        private int _ID;
        /// <summary>
        /// -->权限名称, 超级管理员,普通管理员.
        /// </summary>
        private string _Title;

        public int ID { get => _ID; set => _ID = value; }
        public string Title { get => _Title; set => _Title = value; }
    }
}
