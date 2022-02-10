using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminMasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["email"] == null)
        {
            Response.Redirect("~/Login.aspx");
        }
        else
        {
            Literal1.Text = Session["email"].ToString();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Session["email"] = null;
        Response.Redirect("~/Login.aspx");
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Session["email"] = null;
        Response.Redirect("~/Login.aspx");
    }
}
