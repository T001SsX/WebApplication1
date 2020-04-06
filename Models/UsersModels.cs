using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    /// <summary>
    ///  用户表
    /// </summary>
    public class UsersModels
    {
        private int _ID;
        private string _Email;
        private string _Password;
        private string _NickName;
        private string _Photo;
        private DateTime _CreateTime;

        public int ID { get => _ID; set => _ID = value; }
        public string Email { get => _Email; set => _Email = value; }
        public string Password { get => _Password; set => _Password = value; }
        public string NickName { get => _NickName; set => _NickName = value; }
        public string Photo { get => _Photo; set => _Photo = value; }
        public DateTime CreateTime { get => _CreateTime; set => _CreateTime = value; }
    }
}
