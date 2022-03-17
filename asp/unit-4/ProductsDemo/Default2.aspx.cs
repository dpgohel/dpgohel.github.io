using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Default2 : System.Web.UI.Page
{
    SqlConnection con;
    protected void Page_Load(object sender, EventArgs e)
    {
        con = new SqlConnection(ConfigurationManager.ConnectionStrings["DatabaseConnectionString1"].ConnectionString);
        if (!IsPostBack)
        {
            print();
            binddropdown();
        }
        //DeleteCommand="DELETE FROM [products] WHERE [product_id] = @product_id" 
        //InsertCommand="INSERT INTO [products] ([product_category_id], [product_name], [product_price]) VALUES (@product_category_id, @product_name, @product_price)" 
        //ProviderName="<%$ ConnectionStrings:DatabaseConnectionString1.ProviderName %>" 
        //SelectCommand="SELECT [product_id], [product_category_id], [product_name], [product_price] FROM [products]" 
        //UpdateCommand="UPDATE [products] SET [product_category_id] = @product_category_id, [product_name] = @product_name, [product_price] = @product_price WHERE [product_id] = @product_id">
    }
    public void binddropdown()
    {
        SqlDataAdapter adpt = new SqlDataAdapter("SELECT [category_id], [category_name] FROM [categories]", con);
        DataTable dt = new DataTable();
        adpt.Fill(dt);
        DropDownList1.DataSource = dt;
        DropDownList1.DataTextField = "category_name";
        DropDownList1.DataValueField = "category_id";
        DropDownList1.DataBind();
        DropDownList1.Items.Insert(0, new ListItem("Please select category", ""));
        DropDownList1.Items[0].Selected = true;
        DropDownList1.Items[0].Attributes["disabled"] = "disabled";
    }
    public void print()
    {
        //SqlDataAdapter adpt = new SqlDataAdapter("SELECT * FROM products p,categories c where p.category_id=c.id", con);
        SqlDataAdapter adpt = new SqlDataAdapter("SELECT [product_id], [product_category_id], [product_name], [product_price], [category_id], [category_name] FROM [products], [categories] WHERE [product_category_id] = [category_id]", con);
        DataTable dt = new DataTable();
        adpt.Fill(dt);
        GridView1.DataSource = dt;
        GridView1.DataBind();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (Button1.Text == "Update")
        {
            SqlCommand cmd = new SqlCommand("UPDATE [products] SET [product_category_id] = @product_category_id, [product_name] = @product_name, [product_price] = @product_price WHERE [product_id] = @product_id", con);
            cmd.Parameters.AddWithValue("@product_category_id", Convert.ToInt32(DropDownList1.SelectedValue));
            cmd.Parameters.AddWithValue("@product_name", TextBox1.Text);
            cmd.Parameters.AddWithValue("@product_price", TextBox2.Text);
            cmd.Parameters.AddWithValue("@product_id", ViewState["id"]);
            con.Open();
            int s = cmd.ExecuteNonQuery();
            con.Close();
            if (s == 1)
            {
                Literal1.Text = "Product Updated Successfully!";
                clear();
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
            SqlCommand cmd = new SqlCommand("INSERT INTO [products] ([product_category_id], [product_name], [product_price]) VALUES (@product_category_id, @product_name, @product_price)", con);
            cmd.Parameters.AddWithValue("@product_category_id", Convert.ToInt32(DropDownList1.SelectedItem.Value));
            cmd.Parameters.AddWithValue("@product_name", TextBox1.Text);
            cmd.Parameters.AddWithValue("@product_price", TextBox2.Text);
            con.Open();
            int s = cmd.ExecuteNonQuery();
            con.Close();
            if (s == 1)
            {
                Literal1.Text = "Product Inserted Successfully!";
                clear();
                print();
            }
            else
            {
                Literal1.Text = "Please fill the details!";
            }
            Button1.Text = "Submit";
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Button btn = (Button)sender;
        SqlCommand cmd = new SqlCommand("DELETE FROM [products] WHERE [product_id] = @product_id", con);
        cmd.Parameters.AddWithValue("@product_id", btn.CommandArgument);
        con.Open();
        int s = cmd.ExecuteNonQuery();
        con.Close();
        if (s == 1)
        {
            Literal1.Text = "Product Deleted Successfully!";
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
        SqlDataAdapter adpt = new SqlDataAdapter("SELECT [product_id], [product_category_id], [product_name], [product_price] FROM [products] WHERE [product_id] = " + btn.CommandArgument, con);
        DataTable dt = new DataTable();
        adpt.Fill(dt);
        TextBox1.Text = dt.Rows[0][2].ToString();
        DropDownList1.Text = dt.Rows[0][1].ToString();
        TextBox2.Text = dt.Rows[0][3].ToString();
        ViewState["id"] = btn.CommandArgument;
        Button1.Text = "Update";
        DropDownList1.Items[0].Attributes["disabled"] = "disabled";
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Default.aspx");
    }
    public void clear()
    {
        TextBox1.Text = string.Empty;
        TextBox2.Text = string.Empty;
        DropDownList1.SelectedIndex = -1;
    }
}