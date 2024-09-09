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
    public partial class Form18 : Form
    {
        public Form18()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\venka\\OneDrive\\Documents\\seller.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete mediatorreg WHERE USERNAME=@USERNAME", conn);
            if (textBox1.Text == "")
            {
                MessageBox.Show("fill the data", "FILL", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                cmd.Parameters.AddWithValue("@USERNAME", textBox1.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("deleted successfully...................:)");
                Form1 f = new Form1();
                f.ShowDialog();
                this.Hide();
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
