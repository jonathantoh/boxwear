using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ProductInsert : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
        if (!IsPostBack)
        {

        }
    }
    protected void btn_Insert_Click(object sender, EventArgs e)
    {
        int result = 0;
        string image = "";
        string category = "";


        if (FileUpload.HasFile == true)
        {
            image = "Images\\" + FileUpload.FileName;
        }



        Products prod = new Products(tb_ProductID.Text, tb_ProductName.Text, tb_ProductDesc.Text, int.Parse(tb_StockQuantity.Text), decimal.Parse(tb_UnitPrice.Text), FileUpload.FileName, ddl_ProdCat.SelectedItem.Text, ddl_ProdStatus.SelectedItem.Text, ddl_Size.SelectedItem.Text); //tb_ProductCat can change to ddl_ProdCat

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



    protected void btn_ProductView_Click(object sender, EventArgs e)
    {
        Response.Redirect("ProductViewDlist.aspx");
    }
}