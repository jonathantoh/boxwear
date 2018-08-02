using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class FitGridview : System.Web.UI.Page
{

    fitassitant afit = new fitassitant();

    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
           DataBind();
        }
        
    }

    protected void DataBind()
    {
        List<fitassitant> prodList = new List<fitassitant>();


        prodList = afit.getProductAll();
        gvsize.DataSource = prodList;
        gvsize.DataBind();

    }




}