using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DevPortal
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["Logout"] == "True")
            {
                Session.Clear();
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string Email = uName.Text;
            string Password = pWord.Text;

            if (uName.Text != null & pWord.Text != null)
            {
                Session["UserID"] = "1";
                Response.Redirect("/");
            }



        }
    }
}