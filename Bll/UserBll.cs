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
    public class UserBll
    {
        private UserDal ud = new UserDal();
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        public bool Add_User(UsersModels u)
        {
            return ud.Add_User(u)>0;
        }

        /// <summary>
        /// 全查询
        /// </summary>
        /// <returns></returns>
        public DataTable Get_User()
        {
            return ud.Get_User();
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Del_Users(int id)
        {
            return ud.Del_Users(id);
        }

        /// <summary>
        /// 按照id查询
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public UsersModels Get_DataById(int id)
        {
            return ud.Get_DataById(id);
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public bool Up_User(UsersModels U)
        {
           return ud.Up_User(U)>0;
        }

        /// <summary>
        /// 按照ID查询原图片名称
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string Get_UserPhoto(int id)
        {
            return ud.Get_UserPhoto(id);
        }


    }
}
