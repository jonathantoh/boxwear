using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ProductViewWomen : System.Web.UI.Page
{
    Products aProd = new Products();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            bind();
        }
    }

    protected void bind()
    {
        List<Products> prodList = new List<Products>();
        prodList = aProd.getProductAllWomen();
        gvProduct.DataSource = prodList;
        gvProduct.DataBind();
    }

    protected void gvProduct_SelectedIndexChanged(object sender, EventArgs e)
    {
        //get the current selected row 
        GridViewRow row = gvProduct.SelectedRow;

        //get Product ID from the selected row, which is the 
        //first row, i.e. index 0.
        string prodID = row.Cells[0].Text;

        //redirect to next page, with the Product id added to the URL,
        //eg. ProductDetails.aspx?ProdID=1
        Response.Redirect("WomenProducts.aspx?ProdID=" + prodID);
    }
}