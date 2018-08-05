using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_feedback : System.Web.UI.Page
{
    string _connStr = ConfigurationManager.ConnectionStrings["BoxWearDB"].ConnectionString;

    Feedback feedback = new Feedback();
    protected void Page_Load(object sender, EventArgs e)
    {


        if (!IsPostBack)
        {
            bind();
        }
    }


    protected void bind()
    {

        List<Feedback> feedbackList = new List<Feedback>();
        feedbackList = feedback.getFeedbackAll();
        gvFeedback.DataSource = feedbackList;
        gvFeedback.DataBind();
    }


    //Gridview Delete Method
    protected void gvFeedback_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        int result = 0;
        Feedback feedback = new Feedback();
        string categoryID = gvFeedback.DataKeys[e.RowIndex].Value.ToString();
        int categoryID1 = Int32.Parse(categoryID);
        result = feedback.FeedbackDelete(categoryID1);

        if (result > 0)
        {
            Response.Write("<script>alert('Product Remove successfully');</script>");
        }
        else
        {
            Response.Write("<script>alert('Product Removal NOT successfully');</script>");
        }

        Response.Redirect("admin-feedback.aspx");
    }
    //Gridview Select Method
    protected void gvFeedback_SelectedIndexChanged(object sender, EventArgs e)
    {
        // Get the currently selected row.
        GridViewRow row = gvFeedback.SelectedRow;
        // Get Product ID from the selected row, which is the
        // first row, i.e. index 0.
        string id = row.Cells[0].Text;
        // Redirect to next page, with the Product Id added to the URL,
        // e.g. ProductDetails.aspx?ProdID=1
        Response.Redirect("admin-feedback-details.aspx?id=" + id);
    }

}