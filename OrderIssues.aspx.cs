using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class OrderIssues : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        int result = 0;
     
        Feedback feedback = new Feedback(txtFName.Text, txtLName.Text, txtEmail.Text, txtOrderNo.Text, txtMessage.Text);
        result = feedback.feedbackinsert();
        if (result > 0)
        {
            Response.Write("<script>alert('Insert successful');</script>");
            
        }
        else
        {
            Response.Write("<script>alert('Insert NOT successful');</script>");
        }

    }
}