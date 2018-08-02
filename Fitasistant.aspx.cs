using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Fitasistant : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string _connStr = System.Configuration.ConfigurationManager.ConnectionStrings["BoxWearDB"].ConnectionString.ToString();

        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter sda = new SqlDataAdapter();
        DataSet ds = new DataSet(); 

    }











 

    protected void btn_Submit_Click(object sender, EventArgs e)
    {

        int result = 0;
        string image = "";
        string tummyValue = rbl_tummy.SelectedItem.Value;
        string shoulderValue = rbl_shoulder.SelectedItem.Value;

       
        string recSize = null;
        string recTight = null;
        string recLoose = null;

        double height = double.Parse(tb_height.Text);
        double weight = double.Parse(tb_weight.Text);
        string topsize = tb_topsize.Text;
        string bottomsize = tb_bottomSize.Text;
        string footlenght = tb_footlength.Text;
        

        //XL Size//
        if ((height > 190) && (weight > 110))
        {
            recSize = "XL";
            suitableSize.Text = "XL";
       
        }

        //L Size//

        else if ((height >= 180 && height <= 190) && (weight >= 90 && weight <= 110))
        {
            recSize = "L";
            suitableSize.Text = "L";

        }
        else if ((height >= 180 && height <= 190) && (weight >= 70 && weight <= 90))
        {
            recSize = "L";
            suitableSize.Text = "L";
            
        }
        //M Size//
        else if ((height >= 170 && height <= 180) && (weight >= 70 && weight <= 90))
        {
            recSize = "M";
            suitableSize.Text = "M";
           
        }
        else if ((height >= 170 && height <= 180) && (weight >= 60 && weight <= 80))
        {
            recSize = "M";
            suitableSize.Text = "M";
        }

        //S Size//
        else if ((height >= 160 && height <= 170) && (weight >= 50 && weight <= 70))
        {
            recSize = "S";
            suitableSize.Text = "S";
            
        }
        else if ((height >= 160 && height <= 170) && (weight >= 50 && weight <= 70))
        {
            recSize = "S";
            suitableSize.Text = "S";
            
        }

        //XS Size//
        else if ((height >= 150 && height <= 160) && (weight >= 50 && weight <= 70))
        {
            recSize = "XS";
            suitableSize.Text = "XS";
        }
        else if ((height >= 150 && height <= 160) && (weight >= 40 && weight <= 60))
        {
            recSize = "XS";
            suitableSize.Text = "XS";
        }


        //Tummy Radio Button//
        if (tummyValue == "L")
        {
            recSize = "L";
            suitableSize.Text = "L";

        }

        else if (tummyValue == "M")
        {
            recSize = "M";
            suitableSize.Text = "M";
        }

        else if (tummyValue == "S")
        {
            recSize = "S";
            suitableSize.Text = "S";
        }


        //Shoudler Radio Button//
        if (shoulderValue == "L")
        {
            recSize = "L";
            suitableSize.Text = "L";

        }

        else if (shoulderValue == "M")
        {

            recSize = "M";
            suitableSize.Text = "M";
        }

        else if (shoulderValue == "S")
        {

            recSize = "S";
            suitableSize.Text = "S";
        }


       


        Session.Remove("size");
        Session["size"] = recSize;
                

        Session.Remove("tight");
        Session["tight"] = recTight;


        Session.Remove("loose");
        Session["loose"] = recLoose;

        Response.Redirect("suitableSize.aspx");
        
        





       







    }
}