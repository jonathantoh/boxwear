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

    string _connStr = ConfigurationManager.ConnectionStrings["customerDBContext"].ConnectionString;

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

        string queryStr = "INSERT INTO customer(custFName, custLName, custContact, custEmail, custPassword)" + "values (@custFName,@custLName, @custContact, @custEmail,@custPassword)";
        //+ "values (@Product_ID, @Product_Name, @Product_Desc, @Unit_Price,@Product_Image,@Stock_Level)";

        try
        {
            SqlConnection conn = new SqlConnection(_connStr);
            SqlCommand cmd = new SqlCommand(queryStr, conn);
            cmd.Parameters.AddWithValue("@custFName", FnameTxt.Text);
            cmd.Parameters.AddWithValue("@custLName", LnameTxt.Text);
            cmd.Parameters.AddWithValue("@custEmail", Email.Text);
            cmd.Parameters.AddWithValue("@custContact", MobileNumber.Text);
            cmd.Parameters.AddWithValue("@custPassword", Password.Text);

            conn.Open();
            cmd.ExecuteNonQuery(); // Returns no. of rows affected. Must be > 0

            Response.Write("<script>alert('Registeration successful');</script>");
            System.Threading.Thread.Sleep(3000);
            Response.Redirect("~/login.aspx");
        }
        catch
        {
            Response.Write("<script>alert('Registeration unsuccessful, Email has already been registered');</script>");
        }
    }
}