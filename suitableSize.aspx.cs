using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class suitableSize : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        size_lbl.Text = Session["size"].ToString();
        tight_lbl.Text = Session["tight"].ToString();
        loose_lbl.Text = Session["loose"].ToString();
    }
}