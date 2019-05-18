using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DevPortal
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserID"] != null)
            {
                lblLoginID.Text = Session["UserID"].ToString();
            }
            else if (Session["UserID"] is null)
            {
                Response.Redirect("/login.aspx");
            }
        }
    }
}