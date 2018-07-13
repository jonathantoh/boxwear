using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ProductInsert : System.Web.UI.Page
{

    protected void btn_Insert_Click(object sender, EventArgs e)
    {
        int result = 0;
        string image = "";

        if (FileUpload.HasFile == true)
        {
            image = "Images\\" + FileUpload.FileName;
        }

        Products prod = new Products(tb_ProductID.Text, tb_ProductName.Text, tb_ProductDesc.Text, tb_ProductBrand.Text, int.Parse(tb_StockQuantity.Text), decimal.Parse(tb_UnitPrice.Text), FileUpload.FileName, tb_ProductCat.Text, tb_StockStatus.Text);

        result = prod.ProductInsert();

        if (result > 0)
        {
            string saveimg = Server.MapPath("") + "\\" + image;
            lbl_Result.Text = saveimg.ToString();
            FileUpload.SaveAs(saveimg);

            //loadProductInfo();
            //loadProduct();
            //clear1();

            Response.Write("<script> alert('Insert successful');</script>");
        }
        else { Response.Write("<script> alert('Insert NOT  succesful');</script>"); }
    }
}