using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class admin_view_users : System.Web.UI.Page
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
    }


    protected void bind()
    {

        List<Customer> userList = new List<Customer>();
        userList = cust.getUserAll();
        gvUser.DataSource = userList;
        gvUser.DataBind();
    }

    protected void gvUser_RowEditing(object sender, GridViewEditEventArgs e)
    {
        gvUser.EditIndex = e.NewEditIndex;
        bind();
    }

    protected void gvUSer_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        gvUser.EditIndex = -1;
        bind();
    }

    protected void gvUser_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        int result = 0;
        Customer cust = new Customer();
        GridViewRow row = (GridViewRow)gvUser.Rows[e.RowIndex];
        string email = gvUser.DataKeys[e.RowIndex].Value.ToString();
        string Fname = ((TextBox)row.Cells[1].Controls[0]).Text;
        string Lname = ((TextBox)row.Cells[2].Controls[0]).Text;
        string Hp = ((TextBox)row.Cells[3].Controls[0]).Text;
        string Address = ((TextBox)row.Cells[4].Controls[0]).Text;
        string Postal = ((TextBox)row.Cells[5].Controls[0]).Text;
        string City = ((TextBox)row.Cells[6].Controls[0]).Text;

        result = cust.userUpdate(email, Fname, Lname, Hp, Address, Postal, City);
        if (result > 0)
        {
            Response.Write("<script>alert('User Profile updated successfully');</script>");
        }
        else
        {
            Response.Write("<script>alert('User Profile NOT updated');</script>");
        }
        gvUser.EditIndex = -1;
        bind();


    }

    protected void gvUser_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        int result = 0;
        Customer cust = new Customer();
        string userEmail = gvUser.DataKeys[e.RowIndex].Value.ToString();
        result = cust.UserDelete(userEmail);

        if (result > 0)
        {
            Response.Write("<script>alert('Product Remove successfully');</script>");
        }
        else
        {
            Response.Write("<script>alert('Product Removal NOT successfully');</script>");
        }

        Response.Redirect("admin-view-users.aspx");
    }

    public void countUsers()
    {
        SqlConnection conn = new SqlConnection(_connStr);
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "SELECT COUNT(*) FROM table_name";
        Int32 count = (Int32)cmd.ExecuteScalar();

        
    }

}