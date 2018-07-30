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
    private string FName;
    private string LName;
    private string Email;
    private string OrderNo;
    private string Message;

    string _connStr = ConfigurationManager.ConnectionStrings["BoxWearDB"].ConnectionString;


    //overloaded class constructor with 4 parameters
    public Feedback(string FName, string LName, string Email, string OrderNo, string Message)
    {
        this.FName = FName;
        this.LName = LName;
        this.Email = Email;
        this.OrderNo = OrderNo;
        this.Message = Message;
    }
    //Empty or Default class constructo
    public Feedback()
    {
        this.FName = null;
        this.LName = null;
        this.Email = null;
        this.OrderNo = null;
        this.Message = null;
    }

    //DELTE METHOD FROM FEEDBACK ADMIN
    public int FeedbackDelete(string OrderNo)
    {
        string queryStr = "DELETE FROM feedback WHERE feedbackOrderNo=@OrderNo";
        SqlConnection conn = new SqlConnection(_connStr);
        SqlCommand cmd = new SqlCommand(queryStr, conn);
        cmd.Parameters.AddWithValue("@OrderNo", OrderNo);
        conn.Open();
        int nofRow = 0;
        nofRow = cmd.ExecuteNonQuery();
        conn.Close();
        return nofRow;
    }//end DELTE

    public string feedbackFName
    {
        get { return FName; }
        set { FName = value; }
    }
    public string feedbackLName
    {
        get { return LName; }
        set { LName = value; }
    }

    public string feedbackEmail
    {
        get { return Email; }
        set { Email = value; }
    }
    public string feedbackOrderNo
    {
        get { return OrderNo; }
        set { OrderNo = value; }
    }
    public string feedbackMessage
    {
        get { return Message; }
        set { Message = value; }
    }

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
            cmd.Parameters.AddWithValue("@feedbackFName", this.FName);
            cmd.Parameters.AddWithValue("@feedbackLName", this.LName);
            cmd.Parameters.AddWithValue("@feedbackEmail", this.Email);
            cmd.Parameters.AddWithValue("@feedbackOrderNo", this.OrderNo);
            cmd.Parameters.AddWithValue("@feedbackMessage", this.Message);

            conn.Open();
            result += cmd.ExecuteNonQuery(); // Returns no. of rows affected. Must be > 0
            conn.Close();
            return result;
        }
        catch (Exception ex)
        { return 0;
        }
    }//end Insert

    //ADMIN PART
    public Feedback getfeedback(string OrderNo)
    {

        Feedback feedbackDetails = null;

        string FName, LName, Email, Message;
        SqlConnection conn = new SqlConnection(_connStr);
        conn.Open();
        string query = "select * from feedback where feedbackOrderNo ='" + OrderNo + "'";
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

            FName = dr["feedbackFName"].ToString();
            LName = dr["feedbackLName"].ToString();
            Email = dr["feedbackEmail"].ToString();
            OrderNo = dr["feedbackOrderNo"].ToString();
            Message = dr["feedbackMessage"].ToString();



            Feedback feedbackDetails = null;
            feedbackDetails = new Feedback(FName, LName, Email, OrderNo, Message);
            feedbackList.Add(feedbackDetails);
        }
        conn.Close();
        dr.Close();
        dr.Dispose();

        return feedbackList;


    }

 
}

    
