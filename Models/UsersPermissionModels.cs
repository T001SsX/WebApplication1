using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    /// <summary>
    /// 权限分配表,用于设定每个权限能看到的系统菜单都有哪些
    /// </summary>
    public class UsersPermissionModels
    {
        private int _Id;
        /// <summary>
        /// 权限编号
        /// </summary>
        private int _RolesId;
        /// <summary>
        /// 系统菜单编号
        /// </summary>
        private int _SystemMenuId;

        public int Id { get => _Id; set => _Id = value; }
        public int RolesId { get => _RolesId; set => _RolesId = value; }
        public int SystemMenuId { get => _SystemMenuId; set => _SystemMenuId = value; }



    }
}
