using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SelectedProduct : System.Web.UI.Page
{
    Products prod = null;
    Products aProd = new Products();
    protected void Page_Load(object sender, EventArgs e)
    {
        Products aProd = new Products();
        // Get Product ID from queryString 
        string prodID = Request.QueryString["ProdID"].ToString();
        prod = aProd.getProduct(prodID);

        //Diplay product details on webform
        lbl_ProdName.Text = prod.Product_Name;
        lbl_ProdID.Text = prod.Product_ID;
        lbl_ProdDesc.Text = prod.Product_Desc;
        lbl_Price.Text = prod.Product_Price.ToString("c");
        img_Products.ImageUrl = "" + prod.Product_Image;

        // Store the value in invisible fields
        lbl_Price.Text = prod.Product_Price.ToString();

    }

    protected void Btn_Add_Click(object sender, EventArgs e)
    {
        string ID = Request.QueryString["ProdID"].ToString();
        string decreasingID = ID;
        List<Products> prodList = new List<Products>();
        prodList = aProd.getProductAllDescrease(decreasingID);

        prod.Product_SizeCust = DropDownList1.SelectedItem.Text;
        string iProductID = prod.Product_ID.ToString();
        ShoppingCart.Instance.AddItem(iProductID, prod);
    }

    protected void Btn_FitAssist_Click(object sender, EventArgs e)
    {
        Response.Redirect("Fitasistant.aspx");
    }
}