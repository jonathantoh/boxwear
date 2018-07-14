using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_dashboard : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["admin"] == null)
        {
            Response.Redirect("~/admin-login.aspx");
        }
        else
        {

        }
    }

    protected void btnlogout_Click(object sender, EventArgs e)
    {
        Session.Remove("admin");
        Response.Redirect("~/admin-login.aspx");
    }
}