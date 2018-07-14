using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class site_admin : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["admin"] != null)
        {
            //Customer custDetails = null;
            //Customer cust = new Customer();
            //string custEmail = Session["admin"].ToString();
            //custDetails = cust.getUser(custEmail);
            welcome.Text = "Welcome, Admin";

            lbtnLogout.Visible = true;
        }
        else if (Session["admin"] == null)
        {
            lbtnLogout.Visible = false;
        }
    }

    protected void lbtnLogout_Click(object sender, EventArgs e)
    {
        Session.Remove("admin");
        Response.Redirect("~/admin-login.aspx");
    }
}
