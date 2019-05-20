using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace DevPortal
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        public static void ExecuteSQL (string SQL)
        {
            SqlConnection sqlCon = new
            SqlConnection(ConfigurationManager.ConnectionStrings["Portal"].ConnectionString);
            sqlCon.Open();
            SqlCommand sqlCmd = new SqlCommand(SQL, sqlCon);
            sqlCmd.ExecuteNonQuery();
            sqlCon.Close();

        }

        public static string ReturnSQL(string SQL)
        {
            string Value = "";
            SqlConnection sqlCon = new   
            SqlConnection(ConfigurationManager.ConnectionStrings["Portal"].ConnectionString);
            sqlCon.Open();
            SqlCommand sqlCmd = new SqlCommand(SQL, sqlCon);
            try
            {
                Value = (string)sqlCmd.ExecuteScalar().ToString();
                sqlCon.Close();
                return Value;
            }
            catch (Exception ex)
            {
                return Value = "";
            }

        }
    }
}