using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
#region #Prevent_Collapsing
using DevExpress.Web.ASPxTreeView;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void ASPxTreeView1_ExpandedChanging(object source, DevExpress.Web.ASPxTreeView.TreeViewNodeCancelEventArgs e) {
        if ((e.Node.Expanded) && (ASPxTreeView1.SelectedNode != null)) {
            TreeViewNode  node = ASPxTreeView1.SelectedNode.Parent;
            while (node != null) {
                if (e.Node == node) {
                    e.Cancel = true;
                    break;
                }
                node = node.Parent;
            }
        }
    }
}
#endregion #Prevent_Collapsing