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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\venka\\OneDrive\\Documents\\seller.mdf;Integrated Security=True;Connect Timeout=30");
        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.ShowDialog();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form7 form = new Form7();
            form.ShowDialog();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String user_id, passwor_d;
            user_id = textBox1.Text;
            passwor_d = textBox2.Text;
            conn.Open();
            try
            {
                String querry = "select * from buyerreg WHERE USERNAME= '" + textBox1.Text + "' AND PASSWORD = '" + textBox2.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);
                DataTable dataTable = new DataTable();
                sda.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    user_id = textBox1.Text;
                    passwor_d = textBox2.Text;
                    Form14 f = new Form14();
                    f.ShowDialog();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid login details", "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Text = "";
                    textBox2.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                conn.Close();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form22 f = new Form22();
            f.ShowDialog();
            this.Hide();
        }
    }
}
