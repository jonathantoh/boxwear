using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class site : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["user"] != null)
        {
            Customer custDetails = null;
            Customer cust = new Customer();
            string custEmail = Session["user"].ToString();
            custDetails = cust.getUser(custEmail);
            welcome.Text = "Welcome, " + custDetails.FName;

            lbtnLogout.Visible = true;
        }
        else if (Session["user"] == null)
        {
            lbtnLogout.Visible = false;
        }
    }

    protected void lbtnLogout_Click(object sender, EventArgs e)
    {
        Session.Remove("user");
        Response.Redirect("~/home.aspx");
    }

    protected void IB_Cart_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("ViewCart.aspx");
    }
}
