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

    string _connStr = ConfigurationManager.ConnectionStrings["BoxWearDB"].ConnectionString;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Register_Click(object sender, EventArgs e)
    {
        //int result = 0;

        //customer cust = new customer(fnametxt.text, lnametxt.text, email.text, mobilenumber.text, password.text);
        //result = cust.productinsert();
        //if (result > 0)
        //{
        //    //string saveimg = server.mappath(" ") + "\\" + image;
        //    //lbl_result.text = saveimg.tostring();
        //    //fileupload1.saveas(saveimg);
        //    //loadproductinfo();
        //    //loadproduct();
        //    //clear1();
        //    response.write("<script>alert('insert successful');</script>");
        //    response.redirect("~/login.aspx");
        //}
        //else { response.write("<script>alert('insert not successful');</script>"); }

        int result = 0;

        Customer cust = new Customer(FnameTxt.Text, LnameTxt.Text, MobileNumber.Text, Email.Text, Password.Text, 0);
        Email mail = new Email(Email.Text);
        mail.CreateTestMessage3(Email.Text);
        result = cust.UserInsert();

        if(result > 0)
        {
            Response.Write("<script>alert('Insert successful');</script>");
            Response.Redirect("login.aspx");
        }
        else
        {
            Response.Write("<script>alert('Insert NOT successful');</script>");
        }
    }
}