using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AppalachianTrailProject
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String temp = Session["stuID"] as string;
            if (String.IsNullOrEmpty(temp))
            {
                logButton.Text = "Login Here";
            }
            else
            {
                logButton.Text = "Logout";
            }
        }

        protected void logButton_Click(object sender, EventArgs e)
        {
            if (logButton.Text == "Login Here")
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                Session["stuID"] = null;
                Session.Abandon();
                logButton.Text = "Login Here";
                Response.Redirect("Default.aspx");
            }
        }
    }
}