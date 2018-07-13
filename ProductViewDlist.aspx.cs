﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ProductViewDlist : System.Web.UI.Page
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
        prodList = aProd.getProductAll();
        gvProduct.DataSource = prodList;
        gvProduct.DataBind();
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
        Response.Redirect("MenProducts2.aspx?ProdID=" + prodID);
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
        bind();
    }

    protected void gvProduct_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        gvProduct.EditIndex = -1;
        bind();
    }

    protected void gvProduct_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        int result = 0;
        Products prod = new Products();
        GridViewRow row = (GridViewRow)gvProduct.Rows[e.RowIndex];
        string id = gvProduct.DataKeys[e.RowIndex].Value.ToString();
        string tid = ((TextBox)row.Cells[0].Controls[0]).Text;
        string tname = ((TextBox)row.Cells[1].Controls[0]).Text;
        string tprice = ((TextBox)row.Cells[2].Controls[0]).Text;

        result = prod.ProductUpdate(tid, tname, decimal.Parse(tprice));
        if (result > 0)
        {
            Response.Write("<script>alert('Product updated successfully');</script>");
        }
        else
        {
            Response.Write("<script>alert('Product NOT updated');</script>");
        }
        gvProduct.EditIndex = -1;
        bind();
    }
}