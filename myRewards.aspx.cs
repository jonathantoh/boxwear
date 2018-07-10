using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class myRewards : System.Web.UI.Page
{
    //randomizer
    private static Random random = new Random();
    public static string RandomString(int length)
    {
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        return new string(Enumerable.Repeat(chars, length)
          .Select(s => s[random.Next(s.Length)]).ToArray());
    }   

    Customer custDetails;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["user"] == null)
        {
            Response.Redirect("login.aspx");
        }

        Customer cust = new Customer();
        string custEmail = Session["user"].ToString();
        custDetails = cust.getUser(custEmail);


        if (Session["user"] != null)
        {
            txtuser.Text = "Hello, " + custDetails.FName;
        }

        //show reward points
        int points = custDetails.RewardPoints;
        lbl_points.Text = points.ToString();

        ////create gift card code
        //codeGeneratered.Text = myRewards.RandomString(10);
    }

    protected void btnlogout_Click(object sender, EventArgs e)
    {
        Session.Remove("user");
        Response.Redirect("~/login.aspx");
    }

    protected void dailyReward_Click(object sender, EventArgs e)
    {
        int result = 0;
        string custEmail = Session["user"].ToString();

        Customer cust = new Customer();
        custDetails = cust.getUser(custEmail);

        result = cust.addDailyReward(custEmail, custDetails.RewardPoints);

        if (result > 0)
        {
            Response.Write("<script>alert('Points updated successfully');</script>");
            Response.Redirect("~/myRewards.aspx");
        }
        else
        {
            Response.Write("<script>alert('Points NOT updated');</script>");
        }

    }

    protected void btn_buy25_Click(object sender, EventArgs e)
    {

        int result = 0;
        string custEmail = Session["user"].ToString();

        Customer cust = new Customer();
        custDetails = cust.getUser(custEmail);

        if (custDetails.RewardPoints < 250)
        {
            Response.Write("<script>alert('NOT ENOUGH POINTS HOBO!');</script>");
        }
        else
        {
            result = cust.buyGitCards(custEmail, custDetails.RewardPoints, 250);

            if (result > 0)
            {
                Response.Write("<script>alert('Your gift code " + myRewards.RandomString(10) + "');</script>");
                
                
                //Response.Redirect("~/myRewards.aspx");
            }
            else
            {
                Response.Write("<script>alert('Points NOT updated');</script>");
            }
        }

        
    }


    //public void getCode()
    //{
    //    //create gift card code
    //    codeGeneratered.Text = myRewards.RandomString(10);
    //}


    protected void btn_buy50_Click(object sender, EventArgs e)
    {

    }
}