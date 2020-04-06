using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    /// <summary>
    /// 网站菜单表,指定的是前台界面的导航栏信息
    /// </summary>
    public class WebMenuModels
    {
        private int Id;
        private string _Title;
        private string _Link;
        /// <summary>
        /// 菜单等级
        /// </summary>
        private int _ParentId;

        public int Id1 { get => Id; set => Id = value; }
        public string Title { get => _Title; set => _Title = value; }
        public string Link { get => _Link; set => _Link = value; }
        public int ParentId { get => _ParentId; set => _ParentId = value; }
    }
}
