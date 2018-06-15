using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Products
/// </summary>
public class Products
{
    //private class variables accessible only within this class
    private string _ProdName = string.Empty;
    private string _ProdDesc = "";
    private string _ProdID = null;
    private decimal _ProdPrice = 0;
    private string _ProdImage = "";
    private int _ProdStock = 0;


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


    public Products(string prodName, string prodDesc, string prodID, decimal prodPrice, string prodImage, int prodStock)
    {
        _ProdName = prodName;
        _ProdDesc = prodDesc;
        _ProdID = prodID;
        _ProdPrice = prodPrice;
        _ProdImage = prodImage;
        _ProdStock = prodStock;
    }

    public Products(string prodName, string prodDesc, decimal prodPrice, string prodImage, int prodStock)
        : this(null, prodName, prodDesc, prodPrice, prodImage, prodStock)
    {
    }


    public Products(string prodID)
        : this(prodID, "", "", 0, "", 0)
    {
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
    public string Product_ID
    {
        get { return _ProdID; }
        set { _ProdID = value; }
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
    public int Product_Stock
    {
        get { return _ProdStock; }
        set { _ProdStock = value; }
    }
}