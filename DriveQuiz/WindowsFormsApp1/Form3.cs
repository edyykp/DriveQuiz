using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True;Connect Timeout=30";
        public Form3()
        {
            InitializeComponent();
        }

        void Clear()
        {
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = textBox6.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "")
            { MessageBox.Show("Complete every blank space"); }
            else
                if (textBox2.Text != textBox3.Text) MessageBox.Show("Wrong password");
            else
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("UserAdd", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@username", textBox1.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@password", textBox2.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@email", textBox4.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@firstname", textBox5.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@lastname", textBox6.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Register sucessful");
                }
                this.Hide();
                Form1 ss =new Form1();
                ss.Show();
            }
            Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 ss = new Form1();
            ss.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
