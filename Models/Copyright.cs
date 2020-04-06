    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    /// <summary>
    /// 版权信息表
    /// </summary>
    public class Copyright
    {
        private int _Id;
        private string _Title;
        private string _Content;
        private string _Address;
        /// <summary>
        /// 电话1/2
        /// </summary>
        private string _Tell;
        private string _Tel2;
        /// <summary>
        /// QQ1/2
        /// </summary>
        private string _QQ1;
        private string _QQ2;
        /// <summary>
        /// 微信
        /// </summary>
        private string _Wechat;
        private string _Email;
        private string _Logo;
        private string _Images;

        public int Id { get => _Id; set => _Id = value; }
        public string Title { get => _Title; set => _Title = value; }
        public string Content { get => _Content; set => _Content = value; }
        public string Address { get => _Address; set => _Address = value; }
        public string Tell { get => _Tell; set => _Tell = value; }
        public string Tel2 { get => _Tel2; set => _Tel2 = value; }
        public string QQ1 { get => _QQ1; set => _QQ1 = value; }
        public string QQ2 { get => _QQ2; set => _QQ2 = value; }
        public string Wechat { get => _Wechat; set => _Wechat = value; }
        public string Email { get => _Email; set => _Email = value; }
        public string Logo { get => _Logo; set => _Logo = value; }
        public string Images { get => _Images; set => _Images = value; }

    }
}
