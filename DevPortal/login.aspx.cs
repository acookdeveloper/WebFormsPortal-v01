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
            string UserID = "";

            if (uName.Text != null & pWord.Text != null)
            {
                UserID = Global.ReturnSQL("EXEC sp_UA_Login @Email = '" + uName.Text + "', @Password = '" + pWord.Text + "'");

                if (UserID != "")
                {
                    Session["UserID"] = UserID;
                    Response.Redirect("/");
                }
                else
                {
                    Response.Write("You FAIL!");
                }
                
            }



        }
    }
}