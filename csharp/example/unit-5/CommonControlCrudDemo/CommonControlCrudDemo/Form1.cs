using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CommonControlCrudDemo
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        int id;
        string gender = "";
        string language = "";
        public Form1()
        {
            InitializeComponent();
            con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=c:\users\divyesh\documents\visual studio 2010\Projects\CommonControlCrudDemo\CommonControlCrudDemo\Database1.mdf;Integrated Security=True;User Instance=True");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
                gender = "Male";
            if (radioButton2.Checked == true)
                gender = "Female";
            if (checkBox1.Checked == true)
                language = "English,";
            if (checkBox2.Checked == true)
                language += "Hindi,";
            if (checkBox3.Checked == true)
                language += "Gujarati";
            SqlCommand cmd = new SqlCommand("INSERT INTO [users] ([name], [cast], [age], [gender], [language], [city]) VALUES (@name, @cast, @age, @gender, @language, @city)", con);
            cmd.Parameters.AddWithValue("@name", textBox1.Text);
            cmd.Parameters.AddWithValue("@cast", comboBox1.SelectedItem);
            cmd.Parameters.AddWithValue("@age", numericUpDown1.Value);
            cmd.Parameters.AddWithValue("@gender", gender);
            cmd.Parameters.AddWithValue("@language", language);
            cmd.Parameters.AddWithValue("@city", listBox1.SelectedItem);
            con.Open();
            int s=cmd.ExecuteNonQuery();
            con.Close();
            if (s == 1)
            {
                textBox1.Clear();
                comboBox1.SelectedIndex = -1;
                numericUpDown1.Value = 0;
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                listBox1.SelectedIndex = -1;
                MessageBox.Show("Data Insert Successfully!");
            }
            else
            {
                MessageBox.Show("Error!");
            }
            Print();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Print();
        }

        private void Print()
        {
            SqlDataAdapter adpt = new SqlDataAdapter("SELECT * FROM [users]", con);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string ls= "";
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            comboBox1.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            numericUpDown1.Value = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[3].Value);
            gender = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            if (gender == "Male")
                radioButton1.Checked = true;
            if (gender == "Female")
                radioButton2.Checked = true;
            language = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            string[] list=language.Split(',');
            foreach (var item in list)
            {
                if (item == "English")
                    checkBox1.Checked = true;
                if (item == "Hindi")
                    checkBox2.Checked = true;
                if (item == "Gujarati")
                    checkBox3.Checked = true;
            }
            listBox1.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            language = "";
            if (radioButton1.Checked == true)
                gender = "Male";
            if (radioButton2.Checked == true)
                gender = "Female";
            if (checkBox1.Checked == true)
                language = "English,";
            if (checkBox2.Checked == true)
                language += "Hindi,";
            if (checkBox3.Checked == true)
                language += "Gujarati";
            SqlCommand cmd = new SqlCommand("UPDATE [users] SET [name]=@name, [cast]=@cast, [age]=@age, [gender]=@gender, [language]=@language [city]=@city WHERE [id]=@id", con);
            cmd.Parameters.AddWithValue("@name", textBox1.Text);
            cmd.Parameters.AddWithValue("@cast", comboBox1.SelectedItem);
            cmd.Parameters.AddWithValue("@age", numericUpDown1.Value);
            cmd.Parameters.AddWithValue("@gender", gender);
            cmd.Parameters.AddWithValue("@language", language);
            cmd.Parameters.AddWithValue("@city", listBox1.SelectedItem);
            cmd.Parameters.AddWithValue("@id", id);
            con.Open();
            int s = cmd.ExecuteNonQuery();
            con.Close();
            if (s == 1)
            {
                textBox1.Clear();
                comboBox1.SelectedIndex = -1;
                numericUpDown1.Value = 0;
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                listBox1.SelectedIndex = -1;
                MessageBox.Show("Data Update Successfully!");
            }
            else
            {
                MessageBox.Show("Error!");
            }
            Print();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM [users] WHERE [id]=@id", con);
            cmd.Parameters.AddWithValue("@id", id);
            con.Open();
            int s = cmd.ExecuteNonQuery();
            con.Close();
            if (s == 1)
            {
                textBox1.Clear();
                comboBox1.SelectedIndex = -1;
                numericUpDown1.Value = 0;
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                listBox1.SelectedIndex = -1;
                MessageBox.Show("Data Delete Successfully!");
            }
            else
            {
                MessageBox.Show("Error!");
            }
            Print();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adpt = new SqlDataAdapter("SELECT * FROM [users] WHERE [name] LIKE @name + '%'", con);
            adpt.SelectCommand.Parameters.AddWithValue("@name", textBox2.Text.Trim());
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
            }
            else
            {
                dataGridView1.DataSource = null;
                MessageBox.Show("No Record Found!");
            }
        }

    }
}
