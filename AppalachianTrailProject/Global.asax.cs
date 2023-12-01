using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using System.IO;
using Newtonsoft.Json;
using System.Configuration;

namespace AppalachianTrailProject
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            string filepath = Path.Combine(Server.MapPath("~"), "App_Data", "AllStudent.txt");
            Application.Add("Filename", filepath);
            //using (var wr = new StreamWriter(filepath))
            //{
            //    var dict = new Dictionary<int, Student>();
            //    for (int i = 0; i < 100; i++)
            //    {
            //        var st = new Student(i, i, "password");
            //        dict.Add(i, st);
            //    }
            //    var jsonS = JsonConvert.SerializeObject(dict);
            //    wr.Write(jsonS);
            //}

            //using(var sr = new StreamReader(filepath))
            //{
            //    var line = sr.ReadToEnd();
            //    var ldict = JsonConvert.DeserializeObject<Dictionary<String, Student>>(line);
            //    if(ldict == null)
            //    {
            //        ldict = new Dictionary<string, Student>();
            //    }
            //    Application.Add("stuData", ldict);
            //}

            //var connectionString = ConfigurationManager.ConnectionStrings["rdSqlDatabase"].ConnectionString;

        }
    }
}