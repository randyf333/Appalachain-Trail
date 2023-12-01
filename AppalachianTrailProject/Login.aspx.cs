using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Security.Cryptography;

namespace AppalachianTrailProject
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["userCreate"] != null)
            {
                createBut.Visible = false;
                createLab.Visible = true;
            }
            else
            {
                createBut.Visible = true;
                createLab.Visible = false;
            }
        }

        protected void logBut_Click(object sender, EventArgs e)
        {
            //Take text from name and password and compare to key and values
            int ret = findUser(logName.Text, logPass.Text);
            if (ret < 0)
            {
                loginFail.Text = "The Username Is Incorrect";
                return;
            }
            else if(ret == 0)
            {
                loginFail.Text = "Your Password Is Incorrect";
            }
            else
            {
                Session.Add("stuID",logName.Text);
                Response.Redirect("YourDatapg.aspx");
            
            }
        }
        protected int findUser(String stuId, String attempt)
        {
            //var data = Application.Get("stuData") as Dictionary<String, Student>;
            int check = -1;
            //if(data.ContainsKey(name))
            var stu = Student.GetStudent(stuId);
            if (stu != null)
            {
                check = 0;
                if (stu.password == attempt.GetHashCode().ToString())
                {
                    check = 1;
                    Session["stuObj"] = stu;
                }
            }
            return check;
        }
    }
}