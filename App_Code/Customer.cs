using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;
/// <summary>
/// Summary description for Customer
/// </summary>
public class Customer
{
    string _connStr = ConfigurationManager.ConnectionStrings["customerDBContext"].ConnectionString;
    //private class variables accessible only within this class
    private string _FName = null;
    private string _LName = null;
    private string _NRIC = null;
    private string _Hp = null;
    private string _Email = null;
    private string _Gender = null;
    private string _Notifications = null;
    private string _BirthdayMonth = null;
    private string _Password = null;


    //Empty or Default class constructor
    public Customer()
    {
        this.FName = null;
        this.LName = null;
        this.Hp = null;
        this.Email = null;
        this.Password = null;
    }
    //overloaded class constructor with 4 parameters
    public Customer(string p_FName, string p_LName, string p_Hp, string p_Email, string p_Password)
    {
        this._FName = p_FName;
        this._LName = p_LName;
        this.Hp = p_Hp;
        this.Email = p_Email;
        this.Password = p_Password;
    }
    public Customer(string p_FName, string p_LName, string p_Hp, string p_Password): this(null, p_FName, p_LName, p_Hp, p_Password)
    {

    }

    public Customer(string p_Email)
        : this(p_Email, "", "", "")
    {
    }

    //public class properties, accessing from outside the class is possible
    public string FName
    {
        get { return _FName; }
        set { _FName = value; }
    }
    public string LName
    {
        get { return _LName; }
        set { _LName = value; }
    }
    public string NRIC
    {
        get { return _NRIC; }
        set { _NRIC = value; }
    }
    public string Hp
    {
        get { return _Hp; }
        set { _Hp = value; }
    }
    public string Email
    {
        get { return _Email; }
        set { _Email = value; }
    }
    public string Gender
    {
        get { return _Gender; }
        set { _Gender = value; }
    }
    public string Notifications
    {
        get { return _Notifications; }
        set { _Notifications = value; }
    }
    public string BirthdayMonth
    {
        get { return _BirthdayMonth; }
        set { _BirthdayMonth = value; }
    }
    public string Password
    {
        get { return _Password; }
        set { _Password = value; }
    }


    public int ProductInsert()
    {
        int result = 0;
        string queryStr = "INSERT INTO customer(custFName, custLName, custContact, custEmail, custPassword)" + "values (@custFName,@custLName, @custContact, @custEmail,@custPassword)";
 //+ "values (@Product_ID, @Product_Name, @Product_Desc, @Unit_Price,@Product_Image,@Stock_Level)";
        SqlConnection conn = new SqlConnection(_connStr);
        SqlCommand cmd = new SqlCommand(queryStr, conn);
        cmd.Parameters.AddWithValue("@custFName", this.FName);
        cmd.Parameters.AddWithValue("@custLName", this.LName);
        cmd.Parameters.AddWithValue("@custContact", this.Hp);
        cmd.Parameters.AddWithValue("@custEmail", this.Email);
        cmd.Parameters.AddWithValue("@custPassword", this.Password);
        conn.Open();
        result += cmd.ExecuteNonQuery(); // Returns no. of rows affected. Must be > 0
        conn.Close();
        return result;
    }//end Insert
}