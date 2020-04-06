using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;
using System.Web;
using System.Web.UI.WebControls;


namespace WebApplication1.Tools
{
    public class UploadImage : System.Web.UI.Page
    {
        /// <summary>
        /// 上传文件方法
        /// </summary>
        /// <param name="file">我们上传控件</param>
        /// <param name="url">我们上传文件的路径</param>
        /// <returns>新的文件名称</returns>
        public string UpFileName(FileUpload file, string url) // ~/upload/Users/
        {
            string res = "";
            Random r = new Random();
            string filePath = file.FileName;
            string newName = DateTime.Now.ToString("yyyyMMddHHmmss") + r.Next(1000, 9999);

            if (filePath != "")
            {
                string fileType = filePath.Substring(filePath.LastIndexOf('.'));
                string filePic = Server.MapPath(url + newName + fileType);
                file.PostedFile.SaveAs(filePic);
                res = newName + fileType;
            }
            return res;
        }

        /// <summary>
        /// 上传文件的方法2
        /// </summary>
        /// <param name="file"></param>
        /// <param name="url"></param>
        /// <returns></returns>
        public string UpFileName2(FileUpload file, string url,string oldName) // ~/upload/Users/
        {
            string res = "";
            string filePath = file.FileName;
            string newName = DateTime.Now.ToString("yyyyMMddHHmmss")+oldName;
            if (filePath != "")
            {
                string fileType = filePath.Substring(filePath.LastIndexOf('.'));
                string filePic = Server.MapPath(url + newName + fileType);
                file.PostedFile.SaveAs(filePic);
                res = newName + fileType;
            }
            return res;
        }


    }
}