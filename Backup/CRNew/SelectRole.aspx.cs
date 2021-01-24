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
using System.Data.SqlClient;

namespace FloraSoft
{
    public partial class SelectUserRole : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindUserRole();
            }
        }

        private void BindUserRole()
        {
            int UserID = Int32.Parse(Context.User.Identity.Name);
            RoleDB Role = new RoleDB();
            ddluserrole.DataSource = Role.GetRolesForLoginProceed(UserID);
            ddluserrole.DataBind();
        }

     
        protected void Login_Click(object sender, EventArgs e)
        {
            string UserID = Context.User.Identity.Name;
            Response.Cookies["RoleID"].Value = ddluserrole.SelectedItem.Value;
            Response.Cookies["RoleName"].Value = ddluserrole.SelectedItem.Text;
            //if (ddluserrole.SelectedItem.Value == "9")
            //{
            //    FormsAuthentication.SetAuthCookie(UserID, false);
            //    Response.Redirect("Users.aspx");
            //}
            //if (ddluserrole.SelectedItem.Value == "10")
            //{
            //    FormsAuthentication.SetAuthCookie(UserID, false);
            //    Response.Redirect("ReportViewerMenu.aspx");
            //}
            if ((ddluserrole.SelectedItem.Value == "23") || (ddluserrole.SelectedItem.Value == "24"))
            {
                FormsAuthentication.SetAuthCookie(UserID, false);
                Response.Redirect("CR/Default.aspx");
            } 
            //if ((ddluserrole.SelectedItem.Value != "4") && (ddluserrole.SelectedItem.Value != "21"))
            //{
            //    FormsAuthentication.SetAuthCookie(UserID, false);
            //    Response.Redirect("BranchMenu.aspx");
            //}
            //try
            //{
            //    PBMServer.Service1 pbm = new FloraSoft.PBMServer.Service1();
            //    AppVariable.IsConnected = pbm.AreYouUp();
            //}
            //catch (Exception ex)
            //{
            //    System.Console.WriteLine(ex.Message);
            //    AppVariable.IsConnected = false;
            //}
            FormsAuthentication.RedirectFromLoginPage(UserID, false);
        }
    }
}
