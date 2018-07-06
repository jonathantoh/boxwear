using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WomenProducts : System.Web.UI.Page
{
    Products prod = null;
    protected void Page_Load(object sender, EventArgs e)
    {
        /** string prodName = "Box1 - W";
         string prodDesc = "Casual box - W";
         string prodID = "B1 - W";
         decimal prodPrice = 40.0M;
         string prodImage = "";
         int prodQuantity = 10;
         string prodBrand = "";
         string prodCategory = "";
         string prodStatus = "";
         prod = new Products(prodID, prodName, prodDesc, prodBrand, prodQuantity, prodPrice, prodImage, prodCategory, prodStatus);

         lbl_ProdName.Text = prod.Product_Name.ToString();
         lbl_ProdDesc.Text = prod.Product_Desc.ToString();
         lbl_ProdID.Text = prod.Product_ID.ToString();
         lbl_Price.Text = prod.Product_Price.ToString("C");
         img_Products.ImageUrl = "~/Images/unknown.png" + prod.Product_Image; **/

        Products aProd = new Products();

        string prodID = Request.QueryString["ProdID"].ToString();
        prod = aProd.getProduct(prodID);

        lbl_ProdName.Text = prod.Product_Name;
        lbl_ProdDesc.Text = prod.Product_Desc;
        lbl_Price.Text = prod.Product_Price.ToString("c");
        img_Products.ImageUrl = "~/Images/unknown.png" + prod.Product_Image;

        lbl_Price.Text = prod.Product_Price.ToString();
        lbl_ProdID.Text = prodID.ToString();
    }

    protected void Btn_Add_Click(object sender, EventArgs e)
    {
        string iProductID = prod.Product_ID.ToString();
        ShoppingCart.Instance.AddItem(iProductID, prod);
    }
}