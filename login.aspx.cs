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

    string _connStr = ConfigurationManager.ConnectionStrings["customerDBContext"].ConnectionString.ToString();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["user"] != null)
        {
            Response.Redirect("~/account.aspx");
        }
    }

    protected void btn_submit_Click(object sender, EventArgs e)
    {

        SqlConnection conn = new SqlConnection(_connStr);
        conn.Open();
        string query = "SELECT count(*) FROM customer where custEmail='" + txtusername.Text + "' and custPassword='" + txtpassword.Text + "'";

        SqlCommand cmd = new SqlCommand(query, conn);
        string output = cmd.ExecuteScalar().ToString();
        
        if(output == "1")
        {
            //creating a session
            Session["user"] = txtusername.Text;
            Response.Redirect("~/account.aspx");
        }
        else
        {
            Response.Write("Login Failed");
        }

        //USE BELOW FOR NO SESSION STORING
        
        //SqlConnection conn = new SqlConnection(_connStr);
        //conn.Open();
        //SqlCommand cmd = new SqlCommand("SELECT * FROM customer where custEmail = @custEmail and custPassword = @custPassword", conn);

        //cmd.Parameters.AddWithValue("@custEmail", txtusername.Text);
        //cmd.Parameters.AddWithValue("@custPassword", txtpassword.Text);

        //SqlDataReader sdr = cmd.ExecuteReader();

        //if (sdr.Read())
        //{
        //    lblerror.Text = "Login Successful";
        //}else
        //{
        //    lblerror.Text = "Login Unsuccessful";
        //}

        //conn.Close();


    }
}