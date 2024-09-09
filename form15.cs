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
    public partial class Form17 : Form
    {
        public Form17()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\venka\\OneDrive\\Documents\\seller.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand cmd = new SqlCommand("update mediatorreg set PASSWORD=@PASSWORD,CONFIRMPASSWORD=@CONFIRMPASSWORD,NAME=@NAME,GENDER=@GENDER,PHONE=@PHONE,AGE=@AGE,EMAIL=@EMAIL WHERE USERNAME=@USERNAME", conn);
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
                    cmd.Parameters.AddWithValue("@EMAIL", textBox8.Text);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("updated successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form1 f = new Form1();
                    f.ShowDialog();
                    this.Hide();
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                    textBox7.Text = "";
                    textBox8.Text = "";
                }
                else
                {
                    MessageBox.Show("password and coinfirm password mustbe same", "password", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    textBox2.Text = "";
                    textBox3.Text = "";
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.ShowDialog();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form22 form = new Form22();
            form.ShowDialog();
            this.Hide();
        }
    }
}
