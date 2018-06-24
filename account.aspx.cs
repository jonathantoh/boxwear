using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.Security;

public partial class account : System.Web.UI.Page
{
    string _connStr = ConfigurationManager.ConnectionStrings["BoxWearDB"].ConnectionString.ToString();
    
    SqlCommand cmd = new SqlCommand();
    SqlDataAdapter sda = new SqlDataAdapter();
    DataSet ds = new DataSet();

    protected void Page_Load(object sender, EventArgs e)
    {

        //SqlConnection conn = new SqlConnection(_connStr);
        //string query = "SELECT count(*) FROM customer where custEmail='" + Session["user"].ToString() + "'";

        //SqlCommand cmd = new SqlCommand(query, conn);
        //cmd.Parameters.AddWithValue("@Fname", Session["user"].ToString());

        //if (Session["user"] != null)
        //{
        //    txtuser.Text = "Welcome " + Session["user"].ToString();
        //}

        if (Session["user"] == null)
        {
            Response.Redirect("login.aspx");
        }
        else
        {
            //SqlConnection conn = new SqlConnection(_connStr);
            //conn.ConnectionString = "Data Source=(LocalDB)/MSSQLLocalDB;AttachDbFilename=C:/Users/Jonathantoh/Documents/GitHub/boxwear/App_Data/BoxWearDB.mdf;Integrated Security=True";
            //conn.Open();
            showdata();
        }
    }

    protected void btnlogout_Click(object sender, EventArgs e)
    {
        Session.Remove("user");
        Response.Redirect("~/login.aspx");
    }

    public void showdata()
    {
        SqlConnection conn = new SqlConnection(_connStr);
        conn.Open();
        string query = "select * from customer where custEmail='" + Session["user"] + "'";
        SqlCommand cmd = new SqlCommand(query, conn);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        sda.SelectCommand = cmd;
        fnametxt.Text = ds.Tables[0].Rows[0]["custFName"].ToString();
        lnametxt.Text = ds.Tables[0].Rows[0]["custLName"].ToString();
        emailtxt.Text = ds.Tables[0].Rows[0]["custEmail"].ToString();
        contacttxt.Text = ds.Tables[0].Rows[0]["custContact"].ToString();

        if (Session["user"] != null)
        {
            txtuser.Text = "Hello, " + fnametxt.Text;
        }
    }
}