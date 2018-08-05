using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

public partial class ProductViewDlist : System.Web.UI.Page
{
    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["BoxWearDB"].ToString());
    Products aProd = new Products();
    Products prodItem = new Products();
    Products prod = null;
    protected void Page_Load(object sender, EventArgs e)
    {
        //  statusqty();
        List<Products> prodList = new List<Products>();
        prodList = aProd.getProductStatusUpdate();
        if (!IsPostBack)
        {
           
            bind2();

        }
    }

    protected void statusqty()
    {
       // int stockqty = prod.Product_Quantity;
       // if (stockqty <= 0)
       // {
            List<Products> prodList = new List<Products>();
            prodList = aProd.getProductStatusUpdate();
            gvProduct.DataSource = prodList;
            gvProduct.DataBind();
      //  }
      //  else
      //  {
        //    List<Products> prodList = new List<Products>();
        //    prodList = aProd.getProductStatusUpdate2();
        //    gvProduct.DataSource = prodList;
        //    gvProduct.DataBind();
        //}

        
    }

    protected void bind() //bind by ID
    {
        string txtID = tb_InputID.Text;
        List<Products> prodList = new List<Products>();
        prodList = aProd.getProductAllByProductID(txtID);
        gvProduct.DataSource = prodList;
        gvProduct.DataBind();
    }

    protected void bind2() //bind all products
    {

        List<Products> prodList = new List<Products>();
        prodList = aProd.getProductAll();
        
        gvProduct.DataSource = prodList;
        gvProduct.DataBind();
    }

    protected void bind3()
    {
        
        string quantity = DropDownList1.SelectedItem.Text;
        if (quantity == "Low")
        {
            List<Products> prodList = new List<Products>();
            prodList = aProd.getProductByQuantityLow();
            gvProduct.DataSource = prodList;
            gvProduct.DataBind();
        }
        else
        {
            List<Products> prodList = new List<Products>();
            prodList = aProd.getProductByQuantityHigh();
            gvProduct.DataSource = prodList;
            gvProduct.DataBind();
        }
    }

    protected void gvProduct_SelectedIndexChanged(object sender, EventArgs e)
    {

        //Get the currently selected row.
        GridViewRow row = gvProduct.SelectedRow;

        ////Get Product ID from the selected row, which is the 
        // first row, i.e. index 0.
        string prodID = row.Cells[0].Text;
        string queryString = "?ProdID=" + prodID;
        //Redirect to next page, with the Product id added to the URL,
        //e.g. ProductDetails.aspx?ProdID = 1
        Response.Redirect("SelectedProduct.aspx?ProdID=" + prodID);
        //Response.Redirect("MenProducts2.aspx" + prodID);
    }

    protected void btn_AddProduct_Click(object sender, EventArgs e)
    {
        Response.Redirect("ProductInsert.aspx");
    }

    protected void gvProduct_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        int result = 0;
        Products prod = new Products();
        string categoryID = gvProduct.DataKeys[e.RowIndex].Value.ToString();
        result = prod.ProductDelete(categoryID);
        if (result > 0)
        {
            Response.Write("<script>alert('Product Remove successfully');</script>");
        }
        else
        {
            Response.Write("<script>alert('Product Removal NOT successfully');</script>");
        }
        Response.Redirect("ProductViewDlist.aspx");
    }

    protected void gvProduct_RowEditing(object sender, GridViewEditEventArgs e)
    {
        gvProduct.EditIndex = e.NewEditIndex;
        bind2();
    }

    protected void gvProduct_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        gvProduct.EditIndex = -1;
        bind2();
    }

    protected void gvProduct_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        int result = 0;
        Products prod = new Products();
        GridViewRow row = (GridViewRow)gvProduct.Rows[e.RowIndex];
        string id = gvProduct.DataKeys[e.RowIndex].Value.ToString();
        string tid = ((TextBox)row.Cells[0].Controls[0]).Text;
        string tname = ((TextBox)row.Cells[1].Controls[0]).Text;
        string tdesc = ((TextBox)row.Cells[2].Controls[0]).Text;
        string tcategory = ((TextBox)row.Cells[3].Controls[0]).Text;
        string tquantity = ((TextBox)row.Cells[4].Controls[0]).Text; //
        string tprice = ((TextBox)row.Cells[5].Controls[0]).Text;
        string tstatus = ((TextBox)row.Cells[6].Controls[0]).Text;
        string tsize = ((TextBox)row.Cells[7].Controls[0]).Text;


        result = prod.ProductUpdate(tid, tname, tdesc, tcategory, decimal.Parse(tquantity), decimal.Parse(tprice), tstatus, tsize);  //decimal.Parse(tquantity),
        if (result > 0)
        {
            Response.Write("<script>alert('Product updated successfully');</script>");
        }
        else
        {
            Response.Write("<script>alert('Product NOT updated. ID cannot be changed!');</script>");
        }
        gvProduct.EditIndex = -1;
        bind2();
    }

    protected void btnSearch_Click(object sender, EventArgs e)
    {

        bind();

        //string txtID = tb_InputID.Text;
        //string ProdIDs = txtID;
        //string connStr = ConfigurationManager.ConnectionStrings["ProductDBContext"].ConnectionString;
        //SqlConnection conn = new SqlConnection(connStr);
        //conn.Open();
        //SqlCommand cmd = new SqlCommand();
        ////string queryStr = "select * from Outfits where OutfitID like '% - M%'+ @Product_ID";
        ////string queryStr = "SELECT * FROM Outfits where OutfitID LIKE '% - M%' Order By OutfitName";
        ////string queryStr = "select * from Outfits where OutfitID ='" + @OutfitID + "'";
        ////SqlCommand cmd = new SqlCommand(queryStr, conn);
        //string queryStr = "SELECT * FROM Outfits WHERE OutfitID='" + ProdIDs + "'";
        //cmd.CommandText = queryStr;
        //cmd.Connection = conn;
        //cmd.Parameters.AddWithValue("OutfitID", txtID   );
        //DataTable dt = new DataTable();
        //SqlDataAdapter sda = new SqlDataAdapter(cmd);
        //sda.Fill(dt);
        //gvProduct.DataSource = dt;
        //gvProduct.DataBind();


    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        bind3();
    }

    protected void btn_retrieveAll_Click(object sender, EventArgs e)
    {
        bind2();
    }
}