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
        /**
        string prodName = "Box1";
        string prodDesc = "Casual box";
        string prodID = "B1";
        decimal prodPrice = 40.0M;
        string prodImage = "";
        int prodQuantity = 10;
        string prodBrand = "";
        string prodType = "";
        string prodCategory = "";
        string prodStatus = "";
        prod = new Products(prodID, prodName, prodDesc, prodBrand, prodQuantity, prodPrice, prodImage, prodType, prodCategory, prodStatus);

        lbl_ProdName.Text = prod.Product_Name.ToString();
        lbl_ProdDesc.Text = prod.Product_Desc.ToString();
        lbl_ProdID.Text = prod.Product_ID.ToString();
        lbl_Price.Text = prod.Product_Price.ToString("C");
        img_Products.ImageUrl = "~/Images/unknown.png" + prod.Product_Image;
        **/

        Products aProd = new Products();
        // Get Product ID from queryString 
        string prodID = Request.QueryString["ProdID"].ToString();
        prod = aProd.getProduct(prodID);

        //Diplay product details on webform
        lbl_ProdName.Text = prod.Product_Name;
        lbl_ProdDesc.Text = prod.Product_Desc;
        lbl_Price.Text = prod.Product_Price.ToString("c");
        img_Products.ImageUrl = "~/Images/unknown.png";

        // Store the value in invisible fields
        lbl_Price.Text = prod.Product_Price.ToString();
        lbl_ProdID.Text = prodID.ToString();



    }

    protected void Btn_Add_Click(object sender, EventArgs e)
    {

        string iProductID = prod.Product_ID.ToString();
        ShoppingCart.Instance.AddItem(iProductID, prod);
    }
}