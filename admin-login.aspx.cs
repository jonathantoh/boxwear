using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.Security;

public partial class admin_login : System.Web.UI.Page
{
    string _connStr = ConfigurationManager.ConnectionStrings["BoxWearDB"].ConnectionString.ToString();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["admin"] != null)
        {
            Response.Redirect("~/admin-dashboard.aspx");
        }
    }

    protected void btn_submit_Click(object sender, EventArgs e)
    {

        int result = 0;
        if (txtusername.Text == "admin" && txtpassword.Text == "123")
        {
            result = 1;
        }
        else
        {
            result = 0;
        }

        //int result = 0;
        //Customer cust = new Customer(txtusername.Text, txtpassword.Text);
        //result = cust.UserLogin();

        if (result > 0)
        {
            Session["admin"] = txtusername.Text;
            Response.Redirect("~/admin-dashboard.aspx");
        }
        else
        {
            Response.Write("<script>alert('Login NOT successful');</script>");
        }
    }
    }