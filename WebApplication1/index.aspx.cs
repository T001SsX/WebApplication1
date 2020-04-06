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
using WebApplication1.Tools;

namespace WebApplication1
{
    public partial class index : System.Web.UI.Page
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
            var id = Request.Params["Id"];
            var User = ub.Get_DataById(int.Parse(id));
            if (User == null)
            {
                Response.Write("<script>alert('服务器忙,请稍后再试');location.href='UsersManager.aspx'</script>");
            }
            else
            {
                this.textID.Text = User.ID.ToString();
                this.textEmail.Text = User.Email.ToString();
                this.textPassword.Text = User.Password;
                this.textNickName.Text = User.NickName.ToString();
                
            }
        }

       
        
        /// <summary>
        /// 重置按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnReset_Click(object sender, EventArgs e)
        {
            Bind();
        }

        /// <summary>
        /// 修改按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (this.textEmail.Text != "" && this.textNickName.Text != ""&& this.textPassword.Text!="" && this.textID.Text != "")
            {
                UploadImage ui = new UploadImage();
                var id = Request.Params["Id"];
                var PhotoName = ub.Get_UserPhoto(Convert.ToInt32(id));
                UsersModels u = new UsersModels()
                {
                    ID = int.Parse(this.textID.Text),
                    Email = this.textEmail.Text,
                    NickName = this.textNickName.Text,
                    Password = this.textPassword.Text,
                   // Photo = ui.UpFileName2(this.FileUpload1, "~/User_folder/"),
                };
                if (ub.Up_User(u))
                {
                    Response.Write(s: "<script>alert('修改成功');location.href='UsersManager.aspx'</script>");
                }
                else
                {
                    Response.Write(s: "<script>alert('修改失败');location.href='UsersManager.aspx'</script>");
                }

            }
            else
            {
                Response.Write("<script>alert('没有信息');</script>");
            }
        }



    }
}