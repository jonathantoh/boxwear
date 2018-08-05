using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ViewCart : System.Web.UI.Page
{
    Products aProd = new Products();
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            LoadCart();
        }


    }
    protected void LoadCart()
    {
        gv_CartView.DataSource = ShoppingCart.Instance.Items;
        gv_CartView.DataBind();

        decimal total = 0.0m;
        foreach (ShoppingCartItem item in ShoppingCart.Instance.Items)
        {
            total = total + item.TotalPrice;
        }
        lbl_TotalPrice.Text = total.ToString();

    }

    protected void gv_CartView_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        foreach (GridViewRow row in gv_CartView.Rows)
        {


            if (e.CommandName == "Remove")
            {
                lbl_Error.Text = "Message : " + e.CommandArgument.ToString() + " " + "was successfully removed!";
                string productId = e.CommandArgument.ToString();
                ShoppingCart.Instance.RemoveItem(productId);
                LoadCart();



                string str = ((Label)row.FindControl("lbl_qty")).Text;
                int increasingQuantity = int.Parse(str);
                string increasingID = e.CommandArgument.ToString();
                List<Products> prodList = new List<Products>();
                prodList = aProd.getProductAllIncrease(increasingQuantity, increasingID);

            }
        }
    }



    protected void btn_Clear_Click(object sender, EventArgs e)
    {
        ShoppingCart.Instance.Items.Clear();
        LoadCart();
    }

    //protected void btn_Update_Click(object sender, EventArgs e)
    //{
    //    foreach (GridViewRow row in gv_CartView.Rows)
    //    {
    //        try
    //        {
    //            string productId = gv_CartView.DataKeys[row.RowIndex].Value.ToString();

    //            int quantity = int.Parse(((TextBox)row.Cells[2].FindControl("tb_Quantity")).Text);
    //            ShoppingCart.Instance.SetItemQuantity(productId, quantity);
    //        }
    //        catch (FormatException e1)
    //        {
    //            lbl_Error.Text = e1.Message.ToString();
    //        }
    //    }
    //    LoadCart();
    //} 


    protected void btn_Remove_Click(object sender, EventArgs e)
    {

    }

    protected void gv_CartView_SelectedIndexChanged(object sender, EventArgs e)
    {
         
    }
}