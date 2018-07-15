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
/// TEST 
public class Customer
{
    string _connStr = ConfigurationManager.ConnectionStrings["BoxWearDB"].ConnectionString;
    //private class variables accessible only within this class
    private string _FName = null;
    private string _LName = null;
    private string _NRIC = null;
    private string _Hp = null;
    private string _Email = null;
    private string _Address = null;
    private string _Postal = null;
    private string _City = null;
    private string _Country = null;
    private string _Gender = null;
    private string _Password = null;
    private int _RewardPoints = 0;

    //Empty or Default class constructor
    public Customer()
    {
        this.FName = null;
        this.LName = null;
        this.Hp = null;
        this.Email = null;
        this.Address = null;
        this.Postal = null;
        this.City = null;
        this.Country = null;
        this.Password = null;
        this.RewardPoints = 0;
    }
    //overloaded class constructor with 4 parameters
    public Customer(string p_FName, string p_LName, string p_Hp, string p_Email, string p_Password, int p_RewardPoints)
    {
        this._FName = p_FName;
        this._LName = p_LName;
        this.Hp = p_Hp;
        this.Email = p_Email;
        this.Password = p_Password;
        this.RewardPoints = p_RewardPoints;
    }

    public Customer(string p_FName, string p_LName ,string p_Email, string p_Hp, string p_Address, string p_Postal, string p_City, string p_Country, int p_RewardPoints)
    {
        this._FName = p_FName;
        this._LName = p_LName;
        this.Email = p_Email;
        this.Hp = p_Hp;

        this._Address = p_Address;
        this._Postal = p_Postal;
        this._City = p_City;
        this._Country = p_Country;

        this._RewardPoints = p_RewardPoints;

    }

    public Customer(string p_Email, string p_Password)
    {
        this.Email = p_Email;
        this.Password = p_Password;
    }

    // Constructor that take in all except product ID
    //public Customer(string p_FName, string p_LName, string p_Hp, string p_Password): this(null, p_FName, p_LName, p_Hp, p_Password)
    //{

    //}

    // Constructor that take in only email. The other attributes will be set to 0 or empty.
    public Customer(string p_Email)
        : this(p_Email, "", "", "", "",0)
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

    public string Address
    {
        get { return _Address; }
        set { _Address = value; }
    }
    public string Postal
    {
        get { return _Postal; }
        set { _Postal = value; }
    }

    public string City
    {
        get { return _City; }
        set { _City = value; }
    }

    public string Country
    {
        get { return _Country; }
        set { _Country = value; }
    }
    public string Gender
    {
        get { return _Gender; }
        set { _Gender = value; }
    }

    public string Password
    {
        get { return _Password; }
        set { _Password = value; }
    }

    public int RewardPoints
    {
        get { return _RewardPoints; }
        set { _RewardPoints = value; }
    }


    public int UserInsert()
    {
        int result = 0;
        string queryStr = "INSERT INTO customer(custFName, custLName, custContact, custEmail, custPassword,rewardPoints)" + "values (@custFName,@custLName, @custContact, @custEmail,@custPassword,@rewardPoints)";
        //+ "values (@Product_ID, @Product_Name, @Product_Desc, @Unit_Price,@Product_Image,@Stock_Level)";

        try
        {
            SqlConnection conn = new SqlConnection(_connStr);
            SqlCommand cmd = new SqlCommand(queryStr, conn);
            cmd.Parameters.AddWithValue("@custFName", this.FName);
            cmd.Parameters.AddWithValue("@custLName", this.LName);
            cmd.Parameters.AddWithValue("@custEmail", this.Email);
            cmd.Parameters.AddWithValue("@custContact", this.Hp);
            cmd.Parameters.AddWithValue("@custPassword", this.Password);
            cmd.Parameters.AddWithValue("@rewardPoints", this.RewardPoints);
            conn.Open();
            result += cmd.ExecuteNonQuery(); // Returns no. of rows affected. Must be > 0
            conn.Close();

            return result;
        }
        catch(Exception ex)
        {
            return 0;
        }
    }//end Insert


    public int UserLogin()
    {

        SqlConnection conn = new SqlConnection(_connStr);
        conn.Open();
        string query = "SELECT count(*) FROM customer where custEmail='" + this.Email + "' and custPassword='" + this.Password + "'";

        SqlCommand cmd = new SqlCommand(query, conn);
        string output = cmd.ExecuteScalar().ToString();

        if (output == "1")
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }

    public Customer getUser(string email)
    {

        Customer custDetails = null;
        SqlConnection conn = new SqlConnection(_connStr);
        conn.Open();
        string query = "select * from customer where custEmail='" + email + "'";
        SqlCommand cmd = new SqlCommand(query, conn);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        da.SelectCommand = cmd;

        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            FName = ds.Tables[0].Rows[0]["custFName"].ToString();
            LName = ds.Tables[0].Rows[0]["custLName"].ToString();
            email = ds.Tables[0].Rows[0]["custEmail"].ToString();
            Hp = ds.Tables[0].Rows[0]["custContact"].ToString();

            //address
            Address = ds.Tables[0].Rows[0]["custAddress"].ToString();
            Postal = ds.Tables[0].Rows[0]["postal"].ToString();
            City = ds.Tables[0].Rows[0]["city"].ToString();
            Country = ds.Tables[0].Rows[0]["country"].ToString();

            //Points
            RewardPoints = (int) ds.Tables[0].Rows[0]["rewardPoints"];

            custDetails = new Customer(FName, LName, email, Hp, Address, Postal, City, Country, RewardPoints);
        }
        else
        {
            custDetails = null;
        }

        conn.Close();
        dr.Close();
        dr.Dispose();

        return custDetails;
    }


    //retrieve all data out method
    public List<Customer> getUserAll()
    {
        List<Customer> userList = new List<Customer>();

        string queryStr = "SELECT * FROM customer Order By custEmail";


        SqlConnection conn = new SqlConnection(_connStr);
        SqlCommand cmd = new SqlCommand(queryStr, conn);
        conn.Open();
        SqlDataReader dr = cmd.ExecuteReader();


        //Continue to read the resultsets row by row if not the end
        while (dr.Read())
        {
            int points;
            FName = dr["custFName"].ToString();
            LName = dr["custLName"].ToString();
            Email= dr["custEmail"].ToString();
            Hp= dr["custContact"].ToString();
            Address = dr["custAddress"].ToString();
            Postal = dr["postal"].ToString();
            City = dr["city"].ToString();
            Country = dr["country"].ToString();
            points = 0;
            //points = int.Parse(dr["rewardPoints"].ToString());

            Customer custDetails = null;

            custDetails = new Customer(FName, LName, Email, Hp, Address, Postal, City, Country, points);
            userList.Add(custDetails);
        }
        conn.Close();
        dr.Close();
        dr.Dispose();

        return userList;
    }

    public int userUpdate(string custEmail, string fName, string lName, string hp, string address, string postal, string city)
    {
        string query = "UPDATE customer SET" + " custFName = @custFName," + " custLName = @custLName," + " custContact = @custContact," + " custAddress = @custAddress," + " postal = @postal," + " city = @city" + " WHERE custEmail ='" + custEmail + "'";
        SqlConnection conn = new SqlConnection(_connStr);
        SqlCommand cmd = new SqlCommand(query, conn);
        cmd.Parameters.AddWithValue("@custFName", fName);
        cmd.Parameters.AddWithValue("@custLName", lName);
        cmd.Parameters.AddWithValue("@custContact", hp);
        //cmd.Parameters.AddWithValue("@custPassword", Password.Text);

        cmd.Parameters.AddWithValue("@custAddress", address);
        cmd.Parameters.AddWithValue("@postal", postal);
        cmd.Parameters.AddWithValue("@city", city);

        conn.Open();
        int nofRow = 0;
        nofRow = cmd.ExecuteNonQuery();

        conn.Close();

        return nofRow;
    }//end Update


    public int userUpdateProfile(string fName, string lName, string hp, string custEmail)
    {
        string query = "UPDATE customer SET" + " custFName = @custFName," + " custLName = @custLName," + " custContact = @custContact" + " WHERE custEmail ='" + custEmail + "'";
        SqlConnection conn = new SqlConnection(_connStr);
        SqlCommand cmd = new SqlCommand(query, conn);
        cmd.Parameters.AddWithValue("@custFName", fName);
        cmd.Parameters.AddWithValue("@custLName", lName);
        cmd.Parameters.AddWithValue("@custContact", hp);
        //cmd.Parameters.AddWithValue("@custPassword", Password.Text);

        conn.Open();
        int nofRow = 0;
        nofRow = cmd.ExecuteNonQuery();

        conn.Close();

        return nofRow;
    }//end Update

    public int userUpdateAddress(string address, string postal, string city, string Ccountry, string custEmail)
    {
        string query = "UPDATE customer SET" + " custAddress = @custAddress," + " postal = @postal," + " city = @city," + " country = @country" + " WHERE custEmail ='" + custEmail + "'";
        SqlConnection conn = new SqlConnection(_connStr);
        SqlCommand cmd = new SqlCommand(query, conn);
        cmd.Parameters.AddWithValue("@custAddress", address);
        cmd.Parameters.AddWithValue("@postal", postal);
        cmd.Parameters.AddWithValue("@city", city);
        cmd.Parameters.AddWithValue("@country", Ccountry);

        conn.Open();
        int nofRow = 0;
        nofRow = cmd.ExecuteNonQuery();

        conn.Close();

        return nofRow;
    }//end Update


    //delete
    public int UserDelete(string custEmail)
    {
        string queryStr = "DELETE FROM Customer WHERE custEmail = '" + custEmail + "'";
        SqlConnection conn = new SqlConnection(_connStr);
        SqlCommand cmd = new SqlCommand(queryStr, conn);
        cmd.Parameters.AddWithValue("@custEmail", custEmail);
        conn.Open();
        int nofRow = 0;
        nofRow = cmd.ExecuteNonQuery();
        conn.Close();

        return nofRow;


    }//end Delete




    public int addDailyReward(string custEmail, int points)
    {
        string queryStr = "UPDATE customer SET" + " rewardPoints = @rewardPoints" + " WHERE custEmail = '" + custEmail + "'";
        //+ "values (@Product_ID, @Product_Name, @Product_Desc, @Unit_Price,@Product_Image,@Stock_Level)";

        SqlConnection conn = new SqlConnection(_connStr);
        SqlCommand cmd = new SqlCommand(queryStr, conn);
        cmd.Parameters.AddWithValue("@rewardPoints", (points+1));

        conn.Open();
        int nofRow = 0;
        nofRow = cmd.ExecuteNonQuery();

        conn.Close();

        return nofRow;
    }

    public int buyGitCards(string custEmail, int points, int pointsToDeduct)
    {
        string queryStr = "UPDATE customer SET" + " rewardPoints = @rewardPoints" + " WHERE custEmail = '" + custEmail + "'";
        //+ "values (@Product_ID, @Product_Name, @Product_Desc, @Unit_Price,@Product_Image,@Stock_Level)";

        SqlConnection conn = new SqlConnection(_connStr);
        SqlCommand cmd = new SqlCommand(queryStr, conn);
        cmd.Parameters.AddWithValue("@rewardPoints", (points - pointsToDeduct));

        conn.Open();
        int nofRow = 0;
        nofRow = cmd.ExecuteNonQuery();

        conn.Close();

        return nofRow;
    }
}