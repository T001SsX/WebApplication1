using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Bll;
using Models;
using WebApplication1.Tools;

namespace WebApplication1
{
    public partial class RolesManagerUI : System.Web.UI.Page
    {
        private UserBll ub = new UserBll();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            UploadImage ui = new UploadImage();
            var PhoneName = this.FileUpload1.FileName;
            UsersModels u = new UsersModels()
            {
                Email = this.textEmail.Text.Trim(),
                Password = this.textPassword.Text.Trim(),
                NickName = this.textNickName.Text.Trim(),
                Photo = ui.UpFileName(this.FileUpload1, "~/User_folder/"),
            };
            if (ub.Add_User(u))
            {
                Response.Write("<script>alert('注册成功');</script>");
            }
            else
            {
                Response.Write("<script>alert('注册失败');</script>");
            }            
                
            


        }




    }
}