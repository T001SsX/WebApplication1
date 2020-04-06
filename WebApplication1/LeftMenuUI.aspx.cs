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
    public partial class Treeview : System.Web.UI.Page
    {
        private LeftMenuBll lb = new LeftMenuBll();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                return;

            var dt = lb.Get_LeftMenuByParentId(0);
            foreach (DataRow dr in dt.Rows) 
            {
                TreeNode tree = new TreeNode(dr["Title"].ToString(), dr["Id"].ToString()); 

                this.TreeView1.Nodes.Add(tree); 
            }

            for (var i = 0; i < this.TreeView1.Nodes.Count; i++) 
            {
                int pid = int.Parse(this.TreeView1.Nodes[i].Value);

                var son_dt = lb.Get_LeftMenuByParentId(pid); 

                foreach (DataRow dr in son_dt.Rows)
                {
                    TreeNode tree = new TreeNode(dr["Title"].ToString(), dr["Id"].ToString());

                    this.TreeView1.Nodes[i].ChildNodes.Add(tree); 
                }
            }

            this.TreeView1.ExpandDepth = 0; 
            this.TreeView1.ShowLines = true;

        }

        /// <summary> 
        /// 选中节点改变事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void TreeView1_SelectedNodeChanged(object sender, EventArgs e)
        {
            
            var s = this.TreeView1.SelectedNode.Value;
            var model = lb.Get_LeftMenuById(int.Parse(s));
            Response.Redirect(model.Link);
        }



    }
}