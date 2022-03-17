using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class _Default : System.Web.UI.Page
{
    SqlConnection con;
    protected void Page_Load(object sender, EventArgs e)
    {
        con = new SqlConnection(ConfigurationManager.ConnectionStrings["DatabaseConnectionString1"].ConnectionString);
        print();
        //DeleteCommand="DELETE FROM [categories] WHERE [category_id] = @category_id" 
        //InsertCommand="INSERT INTO [categories] ([category_name]) VALUES (@category_name)" 
        //ProviderName="<%$ ConnectionStrings:DatabaseConnectionString1.ProviderName %>" 
        //SelectCommand="SELECT [category_id], [category_name] FROM [categories]" 
        //UpdateCommand="UPDATE [categories] SET [category_name] = @category_name WHERE [category_id] = @category_id">
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (Button1.Text == "Update")
        {
            SqlCommand cmd = new SqlCommand("UPDATE [categories] SET [category_name] = @category_name WHERE [category_id] = @category_id", con);
            cmd.Parameters.AddWithValue("@category_name", TextBox1.Text);
            cmd.Parameters.AddWithValue("@category_id", ViewState["id"]);
            con.Open();
            int s = cmd.ExecuteNonQuery();
            con.Close();
            if (s == 1)
            {
                Literal1.Text = "Category Updated Successfully!";
                TextBox1.Text = string.Empty;
                print();
            }
            else
            {
                Literal1.Text = "Please fill the details!";
            }
            Button1.Text = "Submit";
        }
        else
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO [categories] ([category_name]) VALUES (@category_name)", con);
            cmd.Parameters.AddWithValue("@category_name", TextBox1.Text);
            con.Open();
            int s = cmd.ExecuteNonQuery();
            con.Close();
            if (s == 1)
            {
                Literal1.Text = "Category Inserted Successfully!";
                TextBox1.Text = string.Empty;
                print();
            }
            else
            {
                Literal1.Text = "Please fill the details!";
            }
            Button1.Text = "Submit";
        }
        
    }
    public void print()
    {
        SqlDataAdapter adpt = new SqlDataAdapter("SELECT [category_id], [category_name] FROM [categories]", con);
        DataTable dt = new DataTable();
        adpt.Fill(dt);
        GridView1.DataSource = dt;
        GridView1.DataBind();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Button btn = (Button)sender;
        SqlCommand cmd = new SqlCommand("DELETE FROM [categories] WHERE [category_id] = @category_id", con);
        cmd.Parameters.AddWithValue("@category_id", btn.CommandArgument);
        con.Open();
        int s = 0;
        try
        {
            s = cmd.ExecuteNonQuery();
        }
        catch (Exception)
        {
            Response.Write("<script language=javascript>alert('You can not delete because system having products of this category...');</script>");
        }
        con.Close();
        if (s == 1)
        {
            Literal1.Text = "Category Deleted Successfully!";
            TextBox1.Text = string.Empty;
            print();
        }
        else
        {
            Literal1.Text = "Error!";
        }
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Button btn = (Button)sender;
        SqlDataAdapter adpt = new SqlDataAdapter("SELECT [category_id], [category_name] FROM [categories] WHERE [category_id] = " + btn.CommandArgument, con);
        DataTable dt = new DataTable();
        adpt.Fill(dt);
        TextBox1.Text = dt.Rows[0][1].ToString();
        ViewState["id"] = btn.CommandArgument;
        Button1.Text = "Update";
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Default.aspx");
    }
}