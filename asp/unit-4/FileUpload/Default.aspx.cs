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
        //DeleteCommand="DELETE FROM [products] WHERE [id] = @id" 
        //InsertCommand="INSERT INTO [products] ([name], [price], [image]) VALUES (@name, @price, @image)" 
        //ProviderName="<%$ ConnectionStrings:DatabaseConnectionString1.ProviderName %>" 
        //SelectCommand="SELECT [id], [name], [price], [image] FROM [products]" 
        //UpdateCommand="UPDATE [products] SET [name] = @name, [price] = @price, [image] = @image WHERE [id] = @id">

        con = new SqlConnection(ConfigurationManager.ConnectionStrings["DatabaseConnectionString1"].ConnectionString);
        print();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (FileUpload1.HasFile)
        {
            FileUpload1.SaveAs(Server.MapPath("~/uploads/" + FileUpload1.FileName));
            SqlCommand cmd = new SqlCommand("INSERT INTO [products] ([name], [price], [image]) VALUES (@name, @price, @image)", con);
            cmd.Parameters.AddWithValue("@name", TextBox1.Text);
            cmd.Parameters.AddWithValue("@price", TextBox2.Text);
            cmd.Parameters.AddWithValue("@image", FileUpload1.FileName);
            con.Open();
            int s = cmd.ExecuteNonQuery();
            con.Close();
            if (s == 1)
            {
                Literal1.Text = "Data Inserted Successfully!";
                clear();
                print();
            }
            else
            {
                Literal1.Text = "Please fill all details!";
            }
        }
        else
        {
            Literal1.Text = "Please select Image or file!";
        }
    }
    public void print()
    {
        SqlDataAdapter adpt = new SqlDataAdapter("SELECT [id], [name], [price], [image] FROM [products]", con);
        DataTable dt = new DataTable();
        adpt.Fill(dt);
        GridView1.DataSource = dt;
        GridView1.DataBind();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Button btn = (Button)sender;
        SqlCommand cmd = new SqlCommand("DELETE FROM [products] WHERE [id] = @id", con);
        cmd.Parameters.AddWithValue("@id", btn.CommandArgument);
        con.Open();
        int s = cmd.ExecuteNonQuery();
        con.Close();
        if (s == 1)
        {
            Literal1.Text = "Data Deleted Successfully!";
            clear();
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
        SqlDataAdapter adpt = new SqlDataAdapter("SELECT [id], [name], [price], [image] FROM [products] WHERE [id] = " + btn.CommandArgument, con);
        DataTable dt = new DataTable();
        adpt.Fill(dt);
        TextBox1.Text = dt.Rows[0][1].ToString();
        TextBox2.Text = dt.Rows[0][2].ToString();
        Image2.ImageUrl = "~/uploads/" + dt.Rows[0][3].ToString();
        ViewState["id"] = dt.Rows[0][0].ToString();
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        if (FileUpload1.HasFile)
        {
            FileUpload1.SaveAs(Server.MapPath("~/uploads/" + FileUpload1.FileName));
            SqlCommand cmd = new SqlCommand("UPDATE [products] SET [name] = @name, [price] = @price, [image] = @image WHERE [id] = @id", con);
            cmd.Parameters.AddWithValue("@name", TextBox1.Text);
            cmd.Parameters.AddWithValue("@price", TextBox2.Text);
            cmd.Parameters.AddWithValue("@image", FileUpload1.FileName);
            cmd.Parameters.AddWithValue("@id", ViewState["id"]);
            con.Open();
            int s = cmd.ExecuteNonQuery();
            con.Close();
            if (s == 1)
            {
                Literal1.Text = "Data Updated Successfully!";
                clear();
                print();
            }
            else
            {
                Literal1.Text = "Please fill all details!";
            }
        }
        else
        {
            SqlCommand cmd = new SqlCommand("UPDATE [products] SET [name] = @name, [price] = @price WHERE [id] = @id", con);
            cmd.Parameters.AddWithValue("@name", TextBox1.Text);
            cmd.Parameters.AddWithValue("@price", TextBox2.Text);
            cmd.Parameters.AddWithValue("@id", ViewState["id"]);
            con.Open();
            int s = cmd.ExecuteNonQuery();
            con.Close();
            if (s == 1)
            {
                Literal1.Text = "Data Updated Successfully!";
                clear();
                print();
            }
            else
            {
                Literal1.Text = "Please fill all details!";
            }
        }
    }
    public void clear()
    {
        TextBox1.Text = string.Empty;
        TextBox2.Text = string.Empty;
        FileUpload1.Attributes.Clear();
        Image2.ImageUrl = string.Empty;
    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Default2.aspx");
    }
    protected void Button6_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Default3.aspx");
    }
}