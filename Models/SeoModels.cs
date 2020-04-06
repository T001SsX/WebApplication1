using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    /// <summary>
    /// 优化表
    /// </summary>
    public class SeoModels
    {
        private int _Id;
        private string _Title;
        /// <summary>
        /// 关键字
        /// </summary>
        private string _Keyword;
        /// <summary>
        /// 网站描述信息
        /// </summary>
        private string _Descriptions;
        /// <summary>
        /// 外键,与网站菜单表关联
        /// </summary>
        private int _WebMenuId;

        public int Id { get => _Id; set => _Id = value; }
        public string Title { get => _Title; set => _Title = value; }
        public string Keyword { get => _Keyword; set => _Keyword = value; }
        public string Descriptions { get => _Descriptions; set => _Descriptions = value; }
        public int WebMenuId { get => _WebMenuId; set => _WebMenuId = value; }
    }
}
