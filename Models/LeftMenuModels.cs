using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    /// <summary>
    /// 侧面菜单
    /// </summary>
    public class LeftMenuModels
    {
        private int _Id;
        private string _Title;
        private string _Link;
        private int _ParentId;
        private DateTime _CreateTime;
        private DateTime _UpdateTime;

        public int Id { get => _Id; set => _Id = value; }
        public string Title { get => _Title; set => _Title = value; }
        public string Link { get => _Link; set => _Link = value; }
        public int ParentId { get => _ParentId; set => _ParentId = value; }
        public DateTime CreateTime { get => _CreateTime; set => _CreateTime = value; }
        public DateTime UpdateTime { get => _UpdateTime; set => _UpdateTime = value; }
    }
}
