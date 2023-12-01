using System;
using System.Collections.Generic;

namespace AppalachianTrailProject
{
    public partial class CreateUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                var s = @"function HidePeriod()
                {
                    var p =document.getElementById('MainContent_periodList');
                    var l=document.getElementById('periodlabel');
                    if (document.getElementById('MainContent_bxtUser').value == ""007"")
                    {
                       l.style.display ='none';
                       p.style.display ='none';
                    }
                    else
                    {
                        if (p.style.display =='none')
                        {
                            l.style.display ='';
                            p.style.display ='';
                        }
                    }
                }";
                if (!ClientScript.IsClientScriptBlockRegistered("hidePeriod"))
                {
                    ClientScript.RegisterClientScriptBlock(this.GetType(), "hidePeriod", s, true);
                    bxtUser.Attributes.Add("onKeyUp", "javascript:HidePeriod();");
                }
            }
        }

        protected void bxtPass_TextChanged(object sender, EventArgs e)
        {

        }

        protected void butCreate_Click(object sender, EventArgs e)
        {
            //String letters = "abcdefghijklmnopqrstuvwxyz";
            if (bxtPass.Text != bxtConfirm.Text)
            {
                errMessage.Text = "Passwords do not match";
            }
            else if (string.IsNullOrEmpty(bxtUser.Text))
            {
                errMessage.Text = "Input your name";
            }
            else if (!int.TryParse(bxtUser.Text, out int _))
            {
                errMessage.Text = "Please enter your student ID";
            }
            else if (string.IsNullOrEmpty(bxtPass.Text))
            {
                errMessage.Text = "Enter a Password";
            }
            else if (string.IsNullOrEmpty(firstNamebox.Text))
            {
                errMessage.Text = "Enter your first name";
            }
            else if(string.IsNullOrEmpty(lastNameBox.Text))
            {
                errMessage.Text = "Enter your last name";
            }
            else
            {
                //create new user in files
                //var data = Application.Get("stuData") as Dictionary<String, Student>;
                Student stu = Student.GetStudent(bxtUser.Text);
                if (stu != null)
                {
                    if (stu.password == "@@@@")
                    {
                        stu.password = bxtPass.Text.GetHashCode().ToString();
                        stu.period = periodList.SelectedValue.Trim();
                        //Student.saveDict(Application, data);
                        stu.Update();
                        //ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + myStringVariable + "');", true);
                        Response.Redirect("Login.aspx");
                    }
                    else
                    {
                        errMessage.Text = "User already exists";
                    }
                }
                else
                {
                    /*stu = new Student();
                    stu.stuId = bxtUser.Text;
                    if (bxtUser.Text == "007")
                    {
                        stu.period = "";
                    }
                    else
                    {
                        stu.period = periodList.SelectedValue.Trim();
                    }
                    stu.password = bxtPass.Text.GetHashCode().ToString();
                    stu.firName = firstNamebox.Text;
                    stu.lastName = lastNameBox.Text;
                    //data.Add(stu.stuId, stu);
                    //Student.saveDict(Application, data);
                    stu.SaveNew();
                    Session["userCreate"] = true;
                    Response.Redirect("Login.aspx");*/
                                    }

            }

        }

    }
}