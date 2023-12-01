using System;
using System.Collections.Generic;
using System.Web.UI;

namespace AppalachianTrailProject
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //var dict = Application["stuData"] as Dictionary<String, Student>;
            if (!this.IsPostBack)
            {
                

                string[] classMiles = Student.GetClassTotalMiles("2", "3", "4", "7", "");
                classMil2.Text = classMiles[0];
                classMil3.Text = classMiles[1];
                classMil4.Text = classMiles[2];
                classMil7.Text = classMiles[3];
                teachMiles.Text = classMiles[4];
                if (double.Parse(classMil2.Text) >= 2184)
                {
                    comp2.Visible = true;
                }
                if (double.Parse(classMil3.Text) >= 2184)
                {
                    comp3.Visible = true;
                }
                if (double.Parse(classMil4.Text) >= 2184)
                {
                    comp4.Visible = true;
                }
                if (double.Parse(classMil7.Text) >= 2184)
                {
                    comp7.Visible = true;
                }
            }
        }
        

    }
}