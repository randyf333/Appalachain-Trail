using System;

namespace AppalachianTrailProject
{
    public partial class Your_Datapg : System.Web.UI.Page
    {
        Student curStudent;
        protected void Page_Load(object sender, EventArgs e)
        {
            curStudent = Session["stuObj"] as Student;
            if (!this.IsPostBack)
            {
                String temp = Session["stuID"] as string;
                if (String.IsNullOrEmpty(temp))
                {
                    Response.Redirect("Login.aspx");
                }
                if (temp == "1525269" || temp == "007")
                {
                    resetLink.Visible = true;
                    dataLink.Visible = true;
                }
                //var dict = Application["stuData"] as Dictionary<String, Student>;
                //// Student cur = dict[temp];
                //curStudent = dict[temp];

                nameText.Text = curStudent.firName + " " + curStudent.lastName;//Session["stuID"] as String;//get ID from value
                mileLabel.Text = (curStudent.miles).ToString();//get data from student value
                mileLabel2.Text = (curStudent.miles).ToString();

                classMil.Text = Student.GetClassTotalMiles(curStudent.period)[0];//get data from class value
            }
        }

        protected void entButton_Click(object sender, EventArgs e)
        {
            //String letters = "abcdefghijklmnopqrstuvwxyz";
            //if (entBox.Text.)
            if (!int.TryParse(entBox.Text, out int a))
            {
                enterMess.Text = "Enter a number";
            }
            else
            {
                curStudent.addMiles(a);
                //var dict = Application["stuData"] as Dictionary<String, Student>;
                //var filepath = Application["Filename"] as string;
                // var dailyFile = filepath + DateTime.Now.Date.ToString("yyyymmdd");
                //var dailyFile = filepath.Split('.')[0] + DateTime.Now.Date.ToString("yyyyMMdd") + ".csv";
                //FileInfo file = new FileInfo(dailyFile);
                //bool fileExist = true;
                //if (!file.Exists)
                //    fileExist = false;
                //using (var wr = new StreamWriter(dailyFile, true))
                //{
                //    if (!fileExist)
                //    {
                //        wr.WriteLine("Student ID, First Name, Last Name, Period, Steps, Total Miles");
                //    }
                //    string line = curStudent.stuId + ", " + curStudent.firName + ", " + curStudent.lastName + ", " +
                //        curStudent.period + ", " + a + ", " + curStudent.miles;
                //    wr.WriteLine(line);
                //}
                //Student.saveDict(Application, dict);
                curStudent.UpdateSteps(a);

                enterMess.Text = "Succesfully Entered";
                mileLabel.Text = (curStudent.miles).ToString();//get data from student value
                mileLabel2.Text = (curStudent.miles).ToString();
                classMil.Text = (double.Parse(classMil.Text) + Math.Round((double)a / 2000, 2)).ToString();
            }
            entBox.Text = "";
            Response.Redirect("YourDatapg.aspx");

        }
        protected void entBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

