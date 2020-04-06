using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Models;
namespace Dal
{
    public class LeftMenuDal
    {
        /// <summary>
        /// 全查询
        /// </summary>
        /// <returns></returns>
        public DataTable Get_LeftMenu() 
        {
            string sql= "select * from LeftMenu";
            return Class1.ExcuteDataTable(sql);
        }
        /// <summary>
        /// 根据ParentId 查询
        /// </summary>
        /// <param name="pid">父级菜单id 为0的时候是根节点,其他的时候是子节点</param>
        /// <returns></returns>
        public DataTable Get_LeftMenuByParentId(int pid)
        {
            string sql = "select * from LeftMenu where ParentId = @ParentId";
            SqlParameter[] sp =
            {
                new SqlParameter("@ParentId",pid)
            };

            return Class1.Query(sql, sp);
        }

        /// <summary>
        /// id 查询
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public LeftMenuModels Get_LeftMenuById(int id)
        {
            string sql = "select * from LeftMenu where Id = @Id";
            SqlParameter[] param =
            {
                new SqlParameter("@Id",id)
            };
            LeftMenuModels lm = null;
            var dt = Class1.Query(sql, param);
            foreach (DataRow dr in dt.Rows)
            {
                lm = new LeftMenuModels()
                {
                    Id = int.Parse(dr["Id"].ToString()),
                    Title = dr["Title"].ToString(),
                    Link = dr["Link"].ToString(),
                    ParentId = int.Parse(dr["ParentId"].ToString()),
                    UpdateTime = DateTime.Parse(dr["UpdateTime"].ToString()),
                };
            }

            return lm;
        }


    }
}
