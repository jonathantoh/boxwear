using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ShoppingCartItem
/// </summary>
public class ShoppingCartItem : IEquatable<ShoppingCartItem>
{
    public int Quantity { get; set; }

    private string _ItemID;
    public string ItemID
    {
        get { return _ItemID; }
        set { _ItemID = value; }
    }

    private string _ItemName;
    public string Product_Name
    {
        get { return _ItemName; }
        set { _ItemName = value; }
    }

    private string _ItemDesc;
    public string Product_Desc
    {
        get { return _ItemDesc; }
        set { _ItemDesc = value; }

    }

    private decimal _ItemPrice;
    public decimal Product_Price
    {
        get { return _ItemPrice; }
        set { _ItemPrice = value; }
    }

    private string _ItemSize;
    public string Product_Size
    {
        get { return _ItemSize; }
        set { _ItemSize = value; }
    }

    private string _ItemSizeCust;
    public string Product_SizeCust
    {
        get { return _ItemSizeCust; }
        set { _ItemSizeCust = value; }
    }

    private string _ItemImage;
    public string Product_Image
    {
        get { return _ItemImage; }
        set { _ItemImage = value; }
    }

    public decimal TotalPrice
    {
        get { return Product_Price * Quantity; }
    }

    public ShoppingCartItem(string productID)
    {
        this.ItemID = productID;
    }

    public ShoppingCartItem(string productID, Products prod)
    {
        this.ItemID = productID;
        this.Product_Name = prod.Product_Name;
        this.Product_Desc = prod.Product_Desc;
        this.Product_Price = prod.Product_Price;
        this.Product_Size = prod.Product_Size;
        this.Product_SizeCust = prod.Product_SizeCust;
        this.Product_Image = prod.Product_Image;
    }

    public ShoppingCartItem(string productID, string productName, string productDesc, decimal productPrice, string productSize, string productSizeCust, string productImage)
    {
        this.ItemID = productID;
        this.Product_Name = productName;
        this.Product_Desc = productDesc;
        this.Product_Price = productPrice;
        this.Product_Size = productSize;
        this.Product_SizeCust = productSizeCust;
        this.Product_Image = productImage;

    }

    public bool Equals(ShoppingCartItem anItem)
    {
        return anItem.ItemID == this.ItemID;
    }

    //public bool Equals(ShoppingCartItem product)
    //{
    //    return product.ItemID == this.ItemID;
    //}

}