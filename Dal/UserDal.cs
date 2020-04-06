using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Data;
using System.Data.SqlClient;

namespace Dal
{
    public class UserDal
    {
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        public int Add_User(UsersModels u)
        {
            string sql = "insert into Users(Email,Password,Nickname,Photo) values(@Email,@Password,@Nickname,@Photo)";
            SqlParameter[] sp =
            {
                new SqlParameter("@Email",u.Email),
                new SqlParameter("@Password",u.Password),
                new SqlParameter("@Nickname",u.NickName),
                new SqlParameter("@Photo",u.Photo)
            };
            return Class1.ExcuteNoQuery(sql,CommandType.Text, sp);
        }

        /// <summary>
        /// 全查询
        /// </summary>
        /// <returns></returns>
        public DataTable Get_User() 
        {
            string sql = "select * from users";
            return Class1.ExcuteDataTable(sql);
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Del_Users(int id)
        {
            string sql = "delete from Users where Id = @Id";
            SqlParameter[] sp =
            {
                new SqlParameter("@Id",id)
            };

            return Class1.ExcuteNoQuery(sql, CommandType.Text, sp);
        }

        /// <summary>
        /// 按照id查询
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public UsersModels Get_DataById(int id)
        {
            string sql = "select * from Users where Id = @Id";
            SqlParameter[] sp =
            {
                new SqlParameter("@Id",id)
            };

            var dt = Class1.Query(sql, sp);
            //判断这个系统续表当中是否有值
            if (dt.Rows.Count > 0) //判断系统续表当中行数是否大于0
            {
                //有值的情况
                return new UsersModels()
                {
                    ID = int.Parse(dt.Rows[0]["Id"].ToString()),
                    Email = dt.Rows[0]["Email"].ToString(),
                    NickName = dt.Rows[0]["NickName"].ToString(),
                    Photo = dt.Rows[0]["Photo"].ToString(),
                };
            }
            else
            {
                return null; //没有值的情况
            }
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public int Up_User(UsersModels U)
        {
            string sql = "update Users set Email=@Email,NickName=@NickName,Photo=@Photo  where Id=@Id";
            SqlParameter[] param =
            {
                new SqlParameter("@Email",SqlDbType.VarChar){ Value=U.Email},
                new SqlParameter("@NickName",SqlDbType.VarChar){ Value=U.NickName},
                new SqlParameter("@Photo",SqlDbType.VarChar){ Value=U.Photo},
                new SqlParameter("@Id",SqlDbType.Int){ Value=U.ID},
            };
            return Class1.ExcuteNoQuery(sql, CommandType.Text, param);
        }

        /// <summary>
        /// 按照ID查询原图片名称
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string Get_UserPhoto(int id) 
        {
            string sql = "select Photo from Users where ID="+id;
            return Class1.ExecuteScalar(sql).ToString();
        }



    }
}
