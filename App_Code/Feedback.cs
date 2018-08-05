using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Feedback
/// </summary>
public class Feedback
{
    private string _FName;
    private string _LName;
    private string _Email;
    private string _OrderNo;
    private string _Message;
    private int _Id;

    string _connStr = ConfigurationManager.ConnectionStrings["BoxWearDB"].ConnectionString;

    public Feedback(int Id, string FName, string LName, string Email, string OrderNo, string Message)
    {
        _Id = Id;
        _FName = FName;
        _LName = LName;
        _Email = Email;
        _OrderNo = OrderNo;
        _Message = Message;

    }

    public Feedback(string FName, string LName, string Email, string OrderNo, string Message)
        : this(0, FName, LName, Email, OrderNo, Message)
    {
    }

    public Feedback(int Id)
        : this(Id, "", "", "", "", "")
    {
    }

    public Feedback()
    {
    }

    //overloaded class constructor with 4 parameters
    /**public Feedback(string FName, string LName, string Email, string OrderNo, string Message, int Id)
    {
        this.FName = FName;
        this.LName = LName;
        this.Email = Email;
        this.OrderNo = OrderNo;
        this.Message = Message;
        this.Id = Id;
    }
    //Empty or Default class constructo
    public Feedback()
    {
        this.FName = null;
        this.LName = null;
        this.Email = null;
        this.OrderNo = null;
        this.Message = null;
        this.Id = 0;   
    } **/



    public string feedbackFName
    {
        get { return _FName; }
        set { _FName = value; }
    }
    public string feedbackLName
    {
        get { return _LName; }
        set { _LName = value; }
    }

    public string feedbackEmail
    {
        get { return _Email; }
        set { _Email = value; }
    }
    public string feedbackOrderNo
    {
        get { return _OrderNo; }
        set { _OrderNo = value; }
    }
    public string feedbackMessage
    {
        get { return _Message; }
        set { _Message = value; }
    }
    public int feedbackId
    {
        get { return _Id; }
        set { _Id = value; }
    }

    public object Id { get; private set; }

    public int feedbackinsert()
    {
        string msg = null;
        int result = 0;
        string queryStr = "INSERT INTO feedback(feedbackFName, feedbackLName, feedbackEmail, feedbackOrderNo,feedbackMessage)" + "values (@feedbackFName,@feedbackLName, @feedbackEmail, @feedbackOrderNo,@feedbackMessage)";
        //+ "values (@Product_ID, @Product_Name, @Product_Desc, @Unit_Price,@Product_Image,@Stock_Level)";
        try
        {
            SqlConnection conn = new SqlConnection(_connStr);
            SqlCommand cmd = new SqlCommand(queryStr, conn);
            cmd.Parameters.AddWithValue("@feedbackFName", this._FName);
            cmd.Parameters.AddWithValue("@feedbackLName", this._LName);
            cmd.Parameters.AddWithValue("@feedbackEmail", this._Email);
            cmd.Parameters.AddWithValue("@feedbackOrderNo", this._OrderNo);
            cmd.Parameters.AddWithValue("@feedbackMessage", this._Message);

            conn.Open();
            result += cmd.ExecuteNonQuery(); // Returns no. of rows affected. Must be > 0
            conn.Close();
            return result;
        }
        catch (Exception ex)
        {
            return 0;
        }
    }//end Insert

    //DELTE METHOD FROM FEEDBACK ADMIN
    public int FeedbackDelete(int Id)
    {
        string queryStr = "DELETE FROM feedback WHERE feedbackId= '" + Id + "'";
        SqlConnection conn = new SqlConnection(_connStr);
        SqlCommand cmd = new SqlCommand(queryStr, conn);
        cmd.Parameters.AddWithValue("@Id", Id);
        conn.Open();
        int nofRow = 0;
        nofRow = cmd.ExecuteNonQuery();
        conn.Close();
        return nofRow;
    }//end DELTE

    //ADMIN PART
    public Feedback getfeedback(int Id)
    {

        Feedback feedbackDetails = null;

        string FName, LName, Email, Message, OrderNo;
        SqlConnection conn = new SqlConnection(_connStr);
        conn.Open();
        string query = "select * from feedback where feedbackId ='" + Id + "'";
        SqlCommand cmd = new SqlCommand(query, conn);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        da.SelectCommand = cmd;

        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            FName = ds.Tables[0].Rows[0]["feedbackFName"].ToString();
            LName = ds.Tables[0].Rows[0]["feedbackLName"].ToString();
            Email = ds.Tables[0].Rows[0]["feedbackEmail"].ToString();
            OrderNo = ds.Tables[0].Rows[0]["feedbackOrderNo"].ToString();
            Message = ds.Tables[0].Rows[0]["feedbackMessage"].ToString();



            feedbackDetails = new Feedback(FName, LName, Email, OrderNo, Message);
        }
        else
        {
            feedbackDetails = null;
        }

        conn.Close();
        dr.Close();
        dr.Dispose();

        return feedbackDetails;
    }

    //retrieve all data out method
    public List<Feedback> getFeedbackAll()
    {
        List<Feedback> feedbackList = new List<Feedback>();

        string queryStr = "SELECT * FROM feedback Order By feedbackEmail";


        SqlConnection conn = new SqlConnection(_connStr);
        SqlCommand cmd = new SqlCommand(queryStr, conn);
        conn.Open();
        SqlDataReader dr = cmd.ExecuteReader();


        //Continue to read the resultsets row by row if not the end
        while (dr.Read())
        {

            _FName = dr["feedbackFName"].ToString();
            _LName = dr["feedbackLName"].ToString();
            _Email = dr["feedbackEmail"].ToString();
            _OrderNo = dr["feedbackOrderNo"].ToString();
            _Message = dr["feedbackMessage"].ToString();
            _Id = int.Parse(dr["feedbackId"].ToString());



            Feedback feedbackDetails = null;
            feedbackDetails = new Feedback(_Id, _FName, _LName, _Email, _OrderNo, _Message);
            feedbackList.Add(feedbackDetails);
        }
        conn.Close();
        dr.Close();
        dr.Dispose();

        return feedbackList;


    }


}


