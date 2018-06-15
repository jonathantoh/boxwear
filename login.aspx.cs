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

    string _connStr = ConfigurationManager.ConnectionStrings["customerDBContext"].ConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btn_submit_Click(object sender, EventArgs e)
    {
        
        SqlConnection conn = new SqlConnection(_connStr);
        SqlCommand cmd = new SqlCommand("SELECT * FROM customer", conn);
        conn.Open();
        if (conn.State == ConnectionState.Open)
        {
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                if (sdr[4].ToString().Equals(txtusername.Text) && sdr[5].ToString().Equals(txtpassword.Text))
                {
                    Response.Write("<script>alert('login success1');</script>");
                    Response.Cookies["uname"].Value = sdr[1].ToString();
                    Response.Cookies["u_id"].Value = sdr[0].ToString();
                    FormsAuthentication.RedirectFromLoginPage(txtusername.Text, false);
                    Response.Redirect("~/Pages/Home.aspx");

                    Response.Write("<script>alert('login success');</script>");
                }
                else
                {
                    lblerror.Text = "Please enter write username and password";
                    Response.Write("<script>alert('login failure');</script>");
                }

            }

        }

        else
        {

        }
    }
}