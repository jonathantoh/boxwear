using CreditCard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class receipt_review : System.Web.UI.Page
{
    
    protected void Page_Load(object sender, EventArgs e)
    {
        //try
        //{
        if (Session["user"] == null)
        {
            Response.Redirect("login.aspx");
        }

        string orderid = Request.QueryString["OrderID"].ToString();
            Order order = new Order();
            Order orderDetails = null;
            orderDetails = order.getOrderOrderID(orderid);

            string custEmail = Session["user"].ToString();



            if (orderDetails == null)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "redirect",
                "alert('Order not found'); window.location='" +
                Request.ApplicationPath + "account.aspx';", true);
                //show error
            }
            else
            {
                if (custEmail != orderDetails.CustEmail)
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "redirect",
                "alert('You are not allowed to access'); window.location='" +
                Request.ApplicationPath + "account.aspx';", true);
                }
                else
                {
                    orderid_lbl.Text = orderDetails.OrderID;
                    date_lbl.Text = orderDetails.OrderDate;
                    status_lbl.Text = orderDetails.OrderStatus;

                    email_lbl.Text = orderDetails.CustEmail;
                    postal_lbl.Text = orderDetails.Postal;
                    address_lbl.Text = orderDetails.Address;
                    city_lbl.Text = orderDetails.City;
                    type_lbl.Text = orderDetails.DeliveryType;
                    tracking_lbl.Text = orderDetails.TrackingID;

                    emailtxt.Text = orderDetails.CustEmail;
                    addresstxt.Text = orderDetails.Address;
                    postaltxt.Text = orderDetails.Postal;
                    orderDatetxt.Text = orderDetails.OrderDate;
                    ordernotxt.Text = orderDetails.OrderID;

                    var ccNo = orderDetails.CcNo;
                    String cardType = CreditCardUtility.GetTypeName(ccNo);
                    cardtype.Text = cardType;

                    
                    var lastDigits = ccNo.Substring(ccNo.Length - 4, 4);
                    cardNo.Text= "• • • •" + lastDigits;
                    showOrderDetails();

                decimal sum = 0;
                for (int i = 0; i < gvUser.Rows.Count; ++i)
                {
                    sum += Convert.ToDecimal(gvUser.Rows[i].Cells[4].Text);
                }
                lbl_TotalPrice.Text = sum.ToString();


            }
            }
        //}
        //catch
        //{
        //    Response.Redirect("error.aspx");
        //}
    }

    private void showOrderDetails()
    {
        string orderid = Request.QueryString["OrderID"].ToString();
        Order order = new Order();

        List<Order> userList = new List<Order>();
        userList = order.showOrderDetails(orderid);




        //lbl_TotalPrice.Text = userList[0].TotalPrice;

        gvUser.DataSource = userList;
        gvUser.DataBind();

    }


    
}