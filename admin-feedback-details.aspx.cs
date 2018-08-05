using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_feedback_details : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Feedback feedback = new Feedback();
        // Get Product ID from querystring
        int Id = Int32.Parse(Request.QueryString["id"].ToString());
        feedback = feedback.getfeedback(Id);

        lbl_FName.Text = feedback.feedbackFName;
        lbl_LName.Text = feedback.feedbackLName;
        lbl_Email.Text = feedback.feedbackEmail;
        lbl_Message.Text = feedback.feedbackMessage;
        lbl_OrderNo.Text = feedback.feedbackOrderNo;
        lbl_Id.Text = Id.ToString();

    }
}