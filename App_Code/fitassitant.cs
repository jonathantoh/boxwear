using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;

/// <summary>
/// Summary description for fitassitant
/// </summary>
public class fitassitant
{
    string _connStr = ConfigurationManager.ConnectionStrings["BoxWearDB"].ConnectionString;
    private decimal _Height = 0;
    private decimal _Weight = 0;
    private string _topSize = null;
    private string _bottomSize = null;
    private string _FootLength = null;
    

    public fitassitant()
    {
        this._Height = 0;
        this._Weight = 0;
        this._topSize = null;
        this._bottomSize = null;
        this._FootLength = null;
        //
        // TODO: Add constructor logic here
        //
    }

    public fitassitant(decimal p_Height,decimal p_Weight,string p_FootLength,string p_topSize,string p_bottomSize)
    {
        this._Height = p_Height;
        this._Weight = p_Weight;
        this._topSize = p_topSize;
        this._bottomSize = p_bottomSize;
        this._FootLength = p_FootLength;
        
    }

    public fitassitant(decimal p_Weight, string p_topSize, string p_bottomSize, string p_FootLength)
        : this(0, p_Weight, p_topSize, p_bottomSize, p_FootLength)
    {
    }


    public fitassitant(decimal p_Height)
        : this(p_Height, 0, "", "", "")
    {
    }

    public decimal height
    {
        get { return _Height; }
        set { _Height = value; }
    }
    public decimal weight
    {
        get { return _Weight; }
        set { _Weight = value; }
    }
    public string topSize
    {
        get { return _topSize; }
        set { _topSize = value; }
    }

    public string bottomSize
    {
        get { return _bottomSize; }
        set { _bottomSize = value; }
    }

    public string FootLength
    {
        get { return _FootLength; }
        set { _FootLength = value; }
    }

   





    //Insert Measurement//
    public int fitInsert()
    {

        string msg = null;
        int result = 0;
      


        string queryStr = "INSERT INTO Fit(height, weight, footlength, topsize, bottomsize)"
            + "values (@height, @weight, @Footlength, @topSize, @bottomSize)";
       
        SqlConnection conn = new SqlConnection(_connStr);
        SqlCommand cmd = new SqlCommand(queryStr, conn);
        cmd.Parameters.AddWithValue("@height", this.height);
        cmd.Parameters.AddWithValue("@weight", this.weight);
        cmd.Parameters.AddWithValue("@Footlength", this.FootLength);
        cmd.Parameters.AddWithValue("@topSize", this.topSize);
        cmd.Parameters.AddWithValue("@bottomSize", this.bottomSize);
        
        conn.Open();
        result += cmd.ExecuteNonQuery(); // Returns no. of rows affected. Must be > 0
        conn.Close();
        
        conn.Close();




        return result;
    }

    // Get measurement//
    public fitassitant getmeasure(decimal height)
    {
        fitassitant detail = null;
        decimal Height, Weight;
        string topSize, bottomSize, footlength;


        string queryStr = "SELECT * FROM Fit WHERE height= @height";
        SqlConnection conn = new SqlConnection(_connStr);
        SqlCommand cmd = new SqlCommand(queryStr, conn);
        cmd.Parameters.AddWithValue("@Height", this.height);
        conn.Open();
        SqlDataReader dr = cmd.ExecuteReader();


        if (dr.Read())
        {
            Height = decimal.Parse(dr["height"].ToString());
            Weight = decimal.Parse(dr["weight"].ToString());
            topSize = dr["topSize"].ToString();
            bottomSize = dr["bottomSize"].ToString();
            footlength = dr["footlength"].ToString();
            detail = new fitassitant();
        }
        else
        {
            detail = null;


        }

        conn.Close();
        dr.Close();
        dr.Dispose();
        return detail;

    }



    //Get Product//
    public List<fitassitant> getProductAll()
    {
        List<fitassitant> prodList = new List<fitassitant>();
        string topsize, bottomsize, footlength;
        decimal height, weight;

        string queryStr = "SELECT * FROM Fit Order By height";
        SqlConnection conn = new SqlConnection(_connStr);
        SqlCommand cmd = new SqlCommand(queryStr, conn);
        conn.Open();
        SqlDataReader dr = cmd.ExecuteReader();
        //Continue to read the resultsets row by row if not the end
        while (dr.Read())
        {
            height = decimal.Parse(dr["height"].ToString());
            weight = decimal.Parse(dr["weight"].ToString());
            topsize = dr["topsize"].ToString();
            bottomsize = dr["bottomsize"].ToString();
            footlength = (dr["footlength"].ToString());

            fitassitant a = new fitassitant(height, weight, topsize, bottomsize, footlength);
            prodList.Add(a);
        }
        conn.Close();
        dr.Close();
        dr.Dispose();
        return prodList;
    }



    // Delete//
    public int ProductDelete(decimal height)
    {
        string queryStr = "DELETE FROM Fit WHERE height=@height";
        SqlConnection conn = new SqlConnection(_connStr);
        SqlCommand cmd = new SqlCommand(queryStr, conn);
        cmd.Parameters.AddWithValue("@height", height);
        conn.Open();
        int nofRow = 0;
        nofRow = cmd.ExecuteNonQuery();
        conn.Close();
        return nofRow;
    }//end Delete













    //Insert Measurements//

    public int sizeUpdate(decimal Height, decimal Weight,string topSize,string bottomSize, string FootLength)
    {

        
        string query = "UPDATE customer SET" + " Height= @height," + " Weight = @weight," + "topSize = @topSize," + "bottomSize = @bottomSize," + " FootLength = @shoeSize," +  "'";


        SqlConnection conn = new SqlConnection(_connStr);
        SqlCommand cmd = new SqlCommand(query, conn);
        cmd.Parameters.AddWithValue("@Height", this.height);
        cmd.Parameters.AddWithValue("@weight", this.weight);
        cmd.Parameters.AddWithValue("@topSize", this.topSize);
        cmd.Parameters.AddWithValue("@bottomSize", this.bottomSize);
        cmd.Parameters.AddWithValue("@shoeSize", this.FootLength);
        
        
        conn.Open();
        int nofRow = 0;
        nofRow = cmd.ExecuteNonQuery();

        conn.Close();

        return nofRow;
    }//end Update





}