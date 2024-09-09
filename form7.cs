using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\venka\\OneDrive\\Documents\\seller.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into sellerreg values(@USERNAME,@PASSWORD,@CONFIRMPASSWORD,@NAME,@GENDER,@PHONE,@AGE,@EMAIL)",conn);
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "")
            {
                MessageBox.Show("PLESE FILL THE DATA", "FILL", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                cmd.Parameters.AddWithValue("@USERNAME", textBox1.Text);
                cmd.Parameters.AddWithValue("@PASSWORD", textBox2.Text);
                cmd.Parameters.AddWithValue("@CONFIRMPASSWORD", textBox3.Text);
                if (textBox2.Text == textBox3.Text)
                {
                    cmd.Parameters.AddWithValue("@NAME", textBox4.Text);
                    cmd.Parameters.AddWithValue("@GENDER", textBox5.Text);
                    cmd.Parameters.AddWithValue("@PHONE", textBox6.Text);
                    cmd.Parameters.AddWithValue("@AGE", textBox7.Text);
                    cmd.Parameters.AddWithValue("EMAIL", textBox8.Text);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                    textBox7.Text = "";
                    textBox8.Text = "";
                    MessageBox.Show("regestered successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("password and coinfirm password mustbe same", "password", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    textBox2.Text = "";
                    textBox3.Text = "";

                }
            }
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form22 form22 = new Form22();
            form22.ShowDialog();
            this.Hide();
        }
    }
}
