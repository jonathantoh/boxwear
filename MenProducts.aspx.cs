using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MenProducts : System.Web.UI.Page
{
    Products prod = null;
    protected void Page_Load(object sender, EventArgs e)
    {
        string prodName = "Box1";
        string prodDesc = "Casual box";
        string prodID = "B1";
        decimal prodPrice = 40.0M;
        string prodImage = "";
        int prodStock = 10;
        prod = new Products(prodName, prodDesc, prodID, prodPrice, prodImage, prodStock);

        lbl_ProdName.Text = prod.Product_Name.ToString();
        lbl_ProdDesc.Text = prod.Product_Desc.ToString();
        lbl_ProdID.Text = prod.Product_ID.ToString();
        lbl_Price.Text = prod.Product_Price.ToString("C");
        img_Product.ImageUrl = "C:/Users/gohji/OneDrive/Documents/GitHub/boxwear/images/boxwear-logo.png" ;
    }

    protected void Btn_Add_Click(object sender, EventArgs e)
    {

    }
}