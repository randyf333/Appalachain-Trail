using System;
using System.IO;

namespace AppalachianTrailProject
{
    public partial class DataFilepg : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String temp = Session["stuID"] as string;
            if (String.IsNullOrEmpty(temp) || (temp != "1525269" && temp != "007") )
            {
                Response.Redirect("Login.aspx");
            }
        }

        protected void fileButton_Click(object sender, EventArgs e)
        {
            //var filepath = Application["Filename"] as string;
            //var dailyFile = filepath.Split('.')[0] + Calendar1.SelectedDate.ToString("yyyyMMdd") + ".csv";
            //FileInfo file = new FileInfo(dailyFile);
            //if (file.Exists)
            //{
            //    Response.ClearContent();

            //    // LINE1: Add the file name and attachment, which will force the open/cance/save dialog to show, to the header
            //    Response.AddHeader("Content-Disposition", String.Format("attachment; filename={0}", file.Name));

            //    // Add the file size into the response header
            //    Response.AddHeader("Content-Length", file.Length.ToString());

            //    // Set the ContentType
            //    Response.ContentType = "text/plain";

            //    // Write the file into the response (TransmitFile is for ASP.NET 2.0. In ASP.NET 1.1 you have to use WriteFile instead)
            //    Response.TransmitFile(file.FullName);

            //    // End the response
            //    Response.End();
            //    //Response.TransmitFile(dailyFile);
            //}
            //else
            //{
            //    errFile.Text = "No File For " + Calendar1.SelectedDate.ToString("d");
            //}
            string filename = "StudentLogs" + Calendar1.SelectedDate.ToString("yyyyMMdd") + ".csv";
            var content = Student.GetLogSteps(Calendar1.SelectedDate);
            if (!string.IsNullOrEmpty(content))
            {
                Response.ClearContent();

                // LINE1: Add the file name and attachment, which will force the open/cance/save dialog to show, to the header
                Response.AddHeader("Content-Disposition", $"attachment; filename={filename}");
                Response.AddHeader("Content-Length", content);
                Response.ContentType = "text/plain";
                Response.Write(content);
                Response.End();
            }
            else
            {
                errFile.Text = "No Data For " + Calendar1.SelectedDate.ToString("d");
            }
        }
    }
}