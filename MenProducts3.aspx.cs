using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MenProducts3 : System.Web.UI.Page
{
    Products prod = null;
    Products aProd = new Products();

    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["BoxWearDB"].ToString());
    Products prodItem = new Products();


    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            bind();
        }
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

        prodList = prodItem.getProductMen();

        DataList1.DataSource = prodList;
        DataList1.DataBind();
    }

    protected void bind2()
    {
        string txtName = tb_Name.Text;
        string cmdstr = "Select * from Outfits";
        SqlCommand cmd = new SqlCommand(cmdstr, conn);
        SqlDataAdapter adp = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        conn.Open();
        adp.Fill(ds);


        List<Products> prodList = new List<Products>();

        prodList = prodItem.getProductAllByProductName(txtName);

        DataList1.DataSource = prodList;
        DataList1.DataBind();
    }

    protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
    {
        DataList1.SelectedIndex = e.Item.ItemIndex;
        bind();
        string prodID = ((Label)DataList1.SelectedItem.FindControl("lbl_ProdID")).Text;
        string queryString = "?ProdID=" + prodID;
        Response.Redirect("Selectedproduct.aspx?ProdID=" + prodID);
    }

    protected void img_Products_Click(object sender, ImageClickEventArgs e)
    {



    }


    protected void btnSearch_Click(object sender, EventArgs e)
    {
        bind2();
    }
}