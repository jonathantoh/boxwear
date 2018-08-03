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
        string recbot = null;
        string recFoot = null;
       
        double height = double.Parse(tb_height.Text);
        double weight = double.Parse(tb_weight.Text);
        
        double bottomsize = double.Parse(tb_bottomSize.Text);
        double footlenght = double.Parse(tb_footlength.Text);
        

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


        // BottomSize // 
        if (bottomsize>= 27 && bottomsize<=29)
        {
            recbot = "S";
            Bsize.Text = "S";
            
        }

        else if (bottomsize >= 29 && bottomsize <= 31)
        {
            recbot = "M";
            Bsize.Text = "M";
        }

        else if (bottomsize >= 31 && bottomsize <= 33)
        {
            recbot = "L";
            Bsize.Text = "L";
        }




        // Footlength //
        if (footlenght >= 21.5 && footlenght <= 22.5)
        {
            recFoot = "EU35";
            Flength.Text = "EU35";
        }


        else if (footlenght >= 22.5 && footlenght <= 23.5)
        {
            recFoot = "EU36";
            Flength.Text = "EU36";
        }


        else if (footlenght >= 23 && footlenght <= 24)
        {
            recFoot = "EU37";
            Flength.Text = "EU37";
        }

        else if (footlenght >= 24 && footlenght <= 24.5)
        {
            recFoot = "EU38";
            Flength.Text = "EU38";
        }
        else if (footlenght >= 24.5 && footlenght <= 25.5)
        {
            recFoot = "EU39";
            Flength.Text = "EU39";
        }
        else if (footlenght >= 25.5 && footlenght <= 26)
        {
            recFoot = "EU40";
            Flength.Text = "EU40";
        }
        else if (footlenght >= 26 && footlenght <= 27)
        {
            recFoot = "EU41";
            Flength.Text = "EU41";
        }
        else if (footlenght >= 27 && footlenght <= 28)
        {
            recFoot = "EU42";
            Flength.Text = "EU42";
        }
        else if (footlenght >= 28 && footlenght <= 28.5)
        {
            recFoot = "EU43";
            Flength.Text = "EU43";
        }
        else if (footlenght >= 28.5 && footlenght <= 29.5)
        {
            recFoot = "EU44";
            Flength.Text = "EU44";
        }
        else if (footlenght >= 29.5 && footlenght <= 30)
        {
            recFoot = "EU45";
            Flength.Text = "EU45";
        }


        // Footlength Sesssion//
        Session.Remove("foot");
        Session["foot"] = recFoot;

        // BottomSize Session//
        Session.Remove("bot");
        Session["bot"] = recbot;

        //TopSize Session// 
        Session.Remove("size");
        Session["size"] = recSize;



        Response.Redirect("suitableSize.aspx");
        
        





       







    }
}