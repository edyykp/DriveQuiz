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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox2.Text = "Username";
            textBox3.Text = "Password";
        }
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }     

        private void textBox2_Enter(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBox2.Text))
                textBox2.Text = "Username";
        }

        private void textBox3_Enter_1(object sender, EventArgs e)
        {
            textBox3.Text = "";
            textBox3.PasswordChar = '•';
        }

        private void textBox3_Leave_1(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBox3.Text))
            { textBox3.Text = "Password";
                textBox3.PasswordChar = '\0'; }
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            if (!(button1.Font.Bold))
            {
                button1.Font = new Font(button1.Font, FontStyle.Bold);
            }
            button1.BackColor = Color.Transparent;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            if ((button1.Font.Bold))
            {
                button1.Font = new Font(button1.Font, FontStyle.Regular);
            }
            button1.BackColor = Color.Transparent;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            if (!(button2.Font.Bold))
            {
                button2.Font = new Font(button2.Font, FontStyle.Bold);
            }
            button2.BackColor = Color.Transparent;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            if ((button2.Font.Bold))
            {
                button2.Font = new Font(button2.Font, FontStyle.Regular);
            }
            button2.BackColor = Color.Transparent;
        }

        private bool CompareStrings(string string1, string string2)
        {
            return String.Compare(string1, string2, true, System.Globalization.CultureInfo.InvariantCulture) == 0 ? true : false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand sda = new SqlCommand("select * from user2 where username='" + textBox2.Text + "' and password ='" + textBox3.Text + "'", con);
            SqlDataReader dr;

            dr = sda.ExecuteReader();

            int ok = 0;
            while (dr.Read())
            {

                if (this.CompareStrings(dr["username"].ToString(), textBox2.Text) &&
                    this.CompareStrings(dr["password"].ToString(), textBox3.Text))
                {
                  

                    ok = 1;
                }
            }
            if (ok == 0) MessageBox.Show("Incorrect");
            else
            {
                this.Hide();
                Form2 ss = new Form2();
                ss.Show();
            }
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 ss = new Form3();
            ss.Show();
            
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.ForeColor = Color.Maroon;
            button3.FlatAppearance.BorderColor = Color.Maroon;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.ForeColor = Color.Black;
            button3.FlatAppearance.BorderColor = Color.Black;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
