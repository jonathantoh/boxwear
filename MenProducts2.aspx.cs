using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MenProducts2 : System.Web.UI.Page
{
    //List<Products> prodList = new List<Products>();
    Products prod = null;
    Products aProd = new Products();

    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["BoxWearDB"].ToString());
    Products prodItem = new Products();


    protected void Page_Load(object sender, EventArgs e)
    {
        bind();
        //Try to get productID another way instead of using QueryString method
    }

    protected void bind()
    {
        string cmdstr = "Select * from Outfits";
        SqlCommand cmd = new SqlCommand(cmdstr, conn);
        SqlDataAdapter adp = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        conn.Open();
        adp.Fill(ds);


        List<Products> prodList = new List<Products>();

        prodList = prodItem.getProductAll();

        DataList1.DataSource = prodList;
        DataList1.DataBind();


    }

    protected void DataList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        /* Products aProd = new Products();

         string prodID = item.Controls[0].Text;
         prod = aProd.getProduct(prodID);
         */

    }

    protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
    {

        if (e.CommandName == "call")
        {
            DataListItem item = (DataListItem)(((Button)(e.CommandSource)).NamingContainer);
            Response.Redirect("MenProducts.aspx?ProdID=" + e.CommandArgument.ToString());
            string prodID = ((Label)item.FindControl("lbl_ProdID")).Text;
            string queryString = "?ProdID=" + prodID;

            //   prod = aProd.getProduct(prodID);
        }

    }

    protected void Btn_Add_Click(object sender, EventArgs e)
    {
        //Products aProd = new Products();
        // string prodID = Request.QueryString["ProdID"].ToString();      
        //  prod = aProd.getProduct(prodID);

        // string queryString = "?CustID" + lbl_ProdID.Text;    

        string iProductID = prod.Product_ID.ToString();
        ShoppingCart.Instance.AddItem(iProductID, prod);
    }
}
