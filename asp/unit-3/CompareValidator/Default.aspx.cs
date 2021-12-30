using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            Literal5.Text = "You are loged in" + "</br>";
            Literal5.Text += "Age = " + TextBox3.Text + "</br>";
            Literal5.Text += "Registration Date = " + TextBox4.Text + "</br>";
        }
    }
}