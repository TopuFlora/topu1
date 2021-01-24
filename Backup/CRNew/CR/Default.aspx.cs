using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FloraSoft.CR
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
 
            if (!(Request.Cookies["RoleID"].Value == "23" || Request.Cookies["RoleID"].Value == "24"))
            {
                Response.Redirect("~/AccessDenied.aspx");
            }         
            //WelcomeMsg.Text = "Welcome " + Request.Cookies["UserName"].Value + " (" + Request.Cookies["RoleName"].Value + ") of " + Request.Cookies["BranchName"].Value + " branch.";
        }
    }
}