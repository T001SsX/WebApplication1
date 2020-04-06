using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using Models;
using Bll;

namespace WebApplication1
{
    public partial class UsersManager : System.Web.UI.Page
    {
        private UserBll ub = new UserBll();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                return;
            Bind();
        }

        public void Bind()           
        {
            this.GridView1.DataKeyNames = new string[] { "Id" };
            DataView dv = ub.Get_User().DefaultView;
            this.GridView1.DataSource = dv;
            this.GridView1.DataBind();
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int index = e.RowIndex;
            var value = this.GridView1.DataKeys[index].Value.ToString();
            int num = ub.Del_Users(int.Parse(value));
            if (num > 0)
            {
                Response.Write("<script>alert('删除成功');</script>");
                Bind();
            }
            else
            {
                Response.Write("<script>alert('删除失败');</script>");
            }
        }


    }
}