using System;
using System.Data;
using System.Collections;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ComponentModel;
using DevExpress.Web;
using System.Text;
using System.Xml;


public partial class ASPxperience_LoadOnCallback : System.Web.UI.Page {
    protected void LoadGroupContent(NavBarGroup group) {
        Control control = null;
        if(group.Expanded && group.ContentTemplate == null) {
            switch(group.Name) {
                case "Group1":
                case "Group2":
                    control = LoadControl("UserControl.ascx");
                    break;
            }
            group.ContentTemplate = control as ITemplate;
        }
    }
    protected void LoadExpandedGroups() {
        for(int i = 0; i < ASPxNavBar1.Groups.Count; i++)
            LoadGroupContent(ASPxNavBar1.Groups[i]);
    }

    protected void Page_Load(object sender, EventArgs e) {
        LoadExpandedGroups();
    }
    protected void ASPxNavBar1_ExpandedChanged(object source, DevExpress.Web.NavBarGroupEventArgs e) {
        LoadGroupContent(e.Group);
    }
}