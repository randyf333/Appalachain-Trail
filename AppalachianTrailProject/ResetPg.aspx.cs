using System;

namespace AppalachianTrailProject
{
    public partial class ResetPg : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void resetBut_Click(object sender, EventArgs e)
        {
            //var dict = Application["stuData"] as Dictionary<String, Student>;
            //Student stu = dict[resetID.Text] as Student;
            var stu = Student.GetStudent(resetID.Text);
            if (stu != null)
            {
                stu.password = "@@@@";
                stu.Update();
                resetMess.Text = "Reset Successful";
            }
            else
            {
                resetMess.Text = "User not found";
            }
            
            //Student.saveDict(Application, dict);
        }
    }
}