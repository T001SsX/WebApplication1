using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Models;
using Dal;

namespace Bll
{
    public class LeftMenuBll
    {
        private LeftMenuDal ld = new LeftMenuDal();
        /// <summary>
        /// 全查询
        /// </summary>
        /// <returns></returns>
        public DataTable Get_LeftMenu()
        {
            return ld.Get_LeftMenu();
        }

        /// <summary>
        /// 根据ParentId 查询
        /// </summary>
        /// <param name="pid"></param>
        /// <returns></returns>
        public DataTable Get_LeftMenuByParentId(int pid)
        {
            return ld.Get_LeftMenuByParentId(pid);
        }

        /// <summary>
        /// id 查询
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public LeftMenuModels Get_LeftMenuById(int id)
        {
            return ld.Get_LeftMenuById(id);
        }



    }
}
