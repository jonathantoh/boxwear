using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class registration : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Register_Click(object sender, EventArgs e)
    {
        int result = 0;

        Customer cust = new Customer(FnameTxt.Text, LnameTxt.Text, Email.Text, MobileNumber.Text, Password.Text);
        result = cust.ProductInsert();
        if (result > 0)
        {
            //string saveimg = Server.MapPath(" ") + "\\" + image;
            //lbl_Result.Text = saveimg.ToString();
            //FileUpload1.SaveAs(saveimg);
            //loadProductInfo();
            //loadProduct();
            //clear1();
            Response.Write("<script>alert('Insert successful');</script>");
        }
        else { Response.Write("<script>alert('Insert NOT successful');</script>"); }
    }
}