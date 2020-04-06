using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    /// <summary>
    /// 友情连接表
    /// </summary>
    public class FriendLinkModels
    {
        private int _Id;
        private string _Title;
        private string _Link;
        /// <summary>
        /// 主要用询问是否展示
        /// </summary>
        private string _IsShow;

        public int Id { get => _Id; set => _Id = value; }
        public string Title { get => _Title; set => _Title = value; }
        public string Link { get => _Link; set => _Link = value; }
        public string IsShow { get => _IsShow; set => _IsShow = value; }

    }
}
