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

public partial class login : System.Web.UI.Page
{

    string _connStr = ConfigurationManager.ConnectionStrings["BoxWearDB"].ConnectionString.ToString();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["user"] != null)
        {
            Response.Redirect("~/account.aspx");
        }
    }

    protected void btn_submit_Click(object sender, EventArgs e)
    {

        int result = 0;
        Customer cust = new Customer(txtusername.Text, txtpassword.Text);
        result = cust.UserLogin();

        if (result > 0)
        {
            Session["user"] = txtusername.Text;
            Response.Redirect("~/account.aspx");
        }
        else
        {
            Response.Write("<script>alert('Login NOT successful');</script>");
        }
        //SqlConnection conn = new SqlConnection(_connStr);
        //conn.Open();
        //string query = "SELECT count(*) FROM customer where custEmail='" + txtusername.Text + "' and custPassword='" + txtpassword.Text + "'";

        //SqlCommand cmd = new SqlCommand(query, conn);
        //string output = cmd.ExecuteScalar().ToString();

        //if(output == "1")
        //{
        //    //creating a session
        //    Session["user"] = txtusername.Text;
        //    Response.Redirect("~/account.aspx");
        //}
        //else
        //{
        //    Response.Write("Login Failed");
        //}




    }
}