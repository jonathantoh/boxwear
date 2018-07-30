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
    Order order = new Order();

    protected void Page_Load(object sender, EventArgs e)
    {


        if (Session["user"] == null)
        {
            Response.Redirect("login.aspx");
        }
        else
        {

                showdata();
                int points = custDetails.RewardPoints;
                lbl_points.Text = points.ToString();


            if (points > 0 && points < 150)
            {

            }
        }

        


        if (!IsPostBack)
        {
            bind();
        }
    }

    protected void btnlogout_Click(object sender, EventArgs e)
    {
        Session.Remove("user");
        Response.Redirect("~/login.aspx");
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


        if (Session["user"] != null)
        {
            txtuser.Text = "Hello, " + fnametxt.Text;
        }
    }

    



    protected void bind()
    {
        string custEmail = Session["user"].ToString();

        List<Order> orderList = new List<Order>();
        orderList = order.getOrderAllUser(custEmail);
        gvOrders.DataSource = orderList;
        gvOrders.DataBind();
    }


    protected void gvOrders_SelectedIndexChanged(object sender, EventArgs e)
    {

        //Get the currently selected row.
        GridViewRow row = gvOrders.SelectedRow;

        ////Get Product ID from the selected row, which is the 
        // first row, i.e. index 0.
        string orderID = row.Cells[0].Text;
        string queryString = "?OrderID=" + orderID;
        //Redirect to next page, with the Product id added to the URL,
        //e.g. ProductDetails.aspx?ProdID = 1
        Response.Redirect("receipt-review.aspx?OrderID=" + orderID);
    }

}