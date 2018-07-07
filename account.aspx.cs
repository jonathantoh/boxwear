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
using System.Threading;
using System.Web.Security;

public partial class account : System.Web.UI.Page
{
    string _connStr = ConfigurationManager.ConnectionStrings["BoxWearDB"].ConnectionString.ToString();
    
    SqlCommand cmd = new SqlCommand();
    SqlDataAdapter sda = new SqlDataAdapter();
    DataSet ds = new DataSet();

    Customer custDetails = null;

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

    protected void updateBtn_Click(object sender, EventArgs e)
    {
        profileUpdate();
    }

    protected void updateAddressBtn_Click(object sender, EventArgs e)
    {
        addressUpdate();
    }

    public void showdata()
    {
        Customer cust = new Customer();

        string custEmail = Session["user"].ToString();
        custDetails = cust.getUser(custEmail);

        fnametxt.Text = custDetails.FName;
        lnametxt.Text = custDetails.LName;
        emailtxt.Text = custDetails.Email;
        contacttxt.Text = custDetails.Hp;

        //addresses
        addresstxt.Text = custDetails.Address;
        postaltxt.Text = custDetails.Postal;
        citytxt.Text = custDetails.City;
        countrytxt.Text = custDetails.Country;

        //SqlConnection conn = new SqlConnection(_connStr);
        //conn.Open();
        //string query = "select * from customer where custEmail='" + Session["user"] + "'";
        //SqlCommand cmd = new SqlCommand(query, conn);
        //SqlDataAdapter da = new SqlDataAdapter(cmd);
        //DataSet ds = new DataSet();
        //da.Fill(ds);
        //sda.SelectCommand = cmd;
        //fnametxt.Text = ds.Tables[0].Rows[0]["custFName"].ToString();
        //lnametxt.Text = ds.Tables[0].Rows[0]["custLName"].ToString();
        //emailtxt.Text = ds.Tables[0].Rows[0]["custEmail"].ToString();
        //contacttxt.Text = ds.Tables[0].Rows[0]["custContact"].ToString();

        if (Session["user"] != null)
        {
            txtuser.Text = "Hello, " + fnametxt.Text;
        }
    }

    public void profileUpdate()
    {
        int result = 0;
        string custEmail = Session["user"].ToString();
        Customer cust = new Customer();

        result = cust.userUpdateProfile(Fname.Text, Lname.Text, MobileNumber.Text, custEmail);
        if (result > 0)
        {
            Response.Write("<script>alert('Profile updated successfully');</script>");
            Response.Redirect("~/account.aspx");
        }
        else
        {
            Response.Write("<script>alert('Profile NOT updated');</script>");
        }

    }

    public void addressUpdate()
    {
        
        string country = null;
        if(ddl_country.SelectedIndex > -1)
        {
            country = ddl_country.SelectedItem.Text;
        }

        int result = 0;
        string custEmail = Session["user"].ToString();
        Customer cust = new Customer();

        result = cust.userUpdateAddress(address.Text, postal.Text, city.Text, country, custEmail);
        if (result > 0)
        {
            Response.Write("<script>alert('Address updated successfully');</script>");
            Response.Redirect("~/account.aspx");
        }
        else
        {
            Response.Write("<script>alert('Address NOT updated');</script>");
        }
    }

}