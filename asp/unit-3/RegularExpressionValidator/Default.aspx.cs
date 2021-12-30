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
            Literal2.Text = "Your email is " + TextBox1.Text + "</br>";
            Literal2.Text += "Your phone is " + TextBox2.Text + "</br>";
        }
        else
        {
            Literal2.Text = "Error";
        }
    }
}