using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class admin_dashboard : System.Web.UI.Page
{

    string _connStr = ConfigurationManager.ConnectionStrings["BoxWearDB"].ConnectionString;
    Customer cust = new Customer();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["admin"] == null)
        {
            Response.Redirect("~/admin-login.aspx");
        }


        if (!IsPostBack)
        {
            bind();
        }

        countUsers();
    }

    protected void btnlogout_Click(object sender, EventArgs e)
    {
        Session.Remove("admin");
        Response.Redirect("~/admin-login.aspx");
    }

    protected void bind()
    {

        List<Customer> userList = new List<Customer>();
        userList = cust.getUserAll();
        gvUser.DataSource = userList;
        gvUser.DataBind();
    }


    protected void viewMore_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/admin-view-users.aspx");
    }

    public void countUsers()
    {

        SqlConnection conn = new SqlConnection(_connStr);
        conn.Open();
        string query = "SELECT count(*) FROM customer";

        SqlCommand cmd = new SqlCommand(query, conn);
        string output = cmd.ExecuteScalar().ToString();

        

        countUser.Text = output.ToString();

    }
}