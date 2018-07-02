using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;
/// <summary>
/// Summary description for Products
/// </summary>
public class Products
{
    //private class variables accessible only within this class
    string connStr = ConfigurationManager.ConnectionStrings["BoxWearDB"].ConnectionString;
    private string _ProdName = string.Empty;
    private string _ProdDesc = "";
    private string _ProdID = null;
    private string _ProdBrand = ""; //added
    private int _ProdQuantity = 0; //added
    private decimal _ProdPrice = 0;
    private string _ProdImage = "";
    private string _ProdCategory = ""; //added
    private string _ProdStatus = "";


    /**public Products()
    {
        this.ProdName = null;
        this.ProdDesc = null;
        this.ProdID = null;
        this.ProdPrice = null;
    }**/
    public Products()
    {

    }


    public Products(string prodID, string prodName, string prodDesc, string prodBrand, int prodQuantity, decimal prodPrice, string prodImage, string prodCategory, string prodStatus) //Have change - prodBrand
    {
        _ProdID = prodID;
        _ProdName = prodName;
        _ProdDesc = prodDesc;
        _ProdBrand = prodBrand;
        _ProdQuantity = prodQuantity;
        _ProdPrice = prodPrice;
        _ProdImage = prodImage;

        _ProdCategory = prodCategory;
        _ProdStatus = prodStatus;
    }

    public Products(string prodName, string prodDesc, string prodBrand, int prodQuantity, decimal prodPrice, string prodImage, string prodCategory, string prodStatus) //Have change -prodBrand
         : this(null, prodName, prodDesc, prodBrand, prodQuantity, prodPrice, prodImage, prodCategory, prodStatus)
    {
    }


    public Products(string prodID)
       : this(prodID, "", "", "", 0, 0, "", "", "")
    {
    }

    public string Product_ID
    {
        get { return _ProdID; }
        set { _ProdID = value; }
    }
    public string Product_Name
    {
        get { return _ProdName; }
        set { _ProdName = value; }
    }
    public string Product_Desc
    {
        get { return _ProdDesc; }
        set { _ProdDesc = value; }
    }
    public string Product_Brand //Changes - Product_Brand
    {
        get { return _ProdBrand; }
        set { _ProdBrand = value; }
    }
    public int Product_Quantity
    {
        get { return _ProdQuantity; }
        set { _ProdQuantity = value; }
    }
    public decimal Product_Price
    {
        get { return _ProdPrice; }
        set { _ProdPrice = value; }
    }
    public string Product_Image
    {
        get { return _ProdImage; }
        set { _ProdImage = value; }
    }
    public string Product_Category
    {
        get { return _ProdCategory; }
        set { _ProdCategory = value; }
    }
    public string Product_Status
    {
        get { return _ProdStatus; }
        set { _ProdStatus = value; }
    }


    public Products getProduct(string prodID)
    {
        Products prodDetail = null;

        string prod_Name, prod_Desc, prod_Image, prod_Category, prod_Brand, stock_Level;
        decimal unit_Price;
        int stock_Quantity;

        string queryStr = "SELECT * FROM Outfits WHERE OutfitID = @ProdID";
        SqlConnection conn = new SqlConnection(connStr);
        SqlCommand cmd = new SqlCommand(queryStr, conn);
        cmd.Parameters.AddWithValue("@ProdID", prodID);
        conn.Open();
        SqlDataReader dr = cmd.ExecuteReader();


        //Check if there are any resultsets
        if (dr.Read())
        {
            prod_Name = dr["OutfitName"].ToString();
            prod_Desc = dr["OutfitDesc"].ToString();
            prod_Image = dr["OutfitImage"].ToString();
            prod_Category = dr["OutfitCategory"].ToString();
            prod_Brand = dr["OutfitBrand"].ToString();
            unit_Price = decimal.Parse(dr["OutfitPrice"].ToString());
            stock_Level = dr["OutfitStatus"].ToString(); //Change in datatype
            stock_Quantity = int.Parse(dr["OutfitQuantity"].ToString());


            prodDetail = new Products(prodID, prod_Name, prod_Desc, prod_Brand, stock_Quantity, unit_Price, prod_Image, prod_Category, stock_Level); //Changes - prod_Brand
        }
        else
        {
            prodDetail = null;
        }
        conn.Close();
        dr.Close();
        dr.Dispose();
        return prodDetail;
    }

    public List<Products> getProductAll()
    {
        List<Products> prodList = new List<Products>();

        string prod_Name, prod_Desc, prod_Image, prod_ID, prod_Category, prod_Brand, stock_Level;
        decimal unit_Price;
        int stock_Quantity;

        string queryStr = "SELECT * FROM Outfits Order By OutfitName";


        SqlConnection conn = new SqlConnection(connStr);
        SqlCommand cmd = new SqlCommand(queryStr, conn);
        conn.Open();
        SqlDataReader dr = cmd.ExecuteReader();


        //continue to read the resultsets row by row if not the end
        while (dr.Read())
        {
            prod_ID = dr["OutfitID"].ToString();
            prod_Name = dr["OutfitName"].ToString();
            prod_Desc = dr["OutfitDesc"].ToString();
            prod_Image = dr["OutfitImage"].ToString();
            prod_Category = dr["OutfitCategory"].ToString();
            prod_Brand = dr["OutfitBrand"].ToString();
            unit_Price = decimal.Parse(dr["OutfitPrice"].ToString());
            stock_Level = dr["OutfitStatus"].ToString();
            stock_Quantity = int.Parse(dr["OutfitQuantity"].ToString());


            Products a = new Products(prod_ID, prod_Name, prod_Desc, prod_Brand, stock_Quantity, unit_Price, prod_Image, prod_Category, stock_Level); //Changes prod_Brand
            prodList.Add(a);
        }
        conn.Close();
        dr.Close();
        dr.Dispose();

        return prodList;
    }
}