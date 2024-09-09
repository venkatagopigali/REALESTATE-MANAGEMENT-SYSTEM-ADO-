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
    public partial class Form21 : Form
    {
        public Form21()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\venka\\OneDrive\\Documents\\seller.mdf;Integrated Security=True;Connect Timeout=30");

        private void button5_Click(object sender, EventArgs e)
        {
            Form19 form19 = new Form19();
            form19.ShowDialog();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text==""||textBox2.Text==""||textBox3.Text=="")
            {
                MessageBox.Show("FILL THE DATA","FILL",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
            }
            else
            {
                string propertynumber;
                
                propertynumber = textBox1.Text;
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into buyerin values(@num,@name,@phone)", conn);
                try
                {
                    String query = "select * from sell where num = '" + textBox1.Text + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        propertynumber = textBox1.Text;
                        cmd.Parameters.AddWithValue("@num", propertynumber);
                        cmd.Parameters.AddWithValue("@name",textBox2.Text);
                        cmd.Parameters.AddWithValue("@phone",textBox3.Text);
                        cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Property number!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox1.Text = "";
                    }
                    MessageBox.Show("THANKYOU FOR THE PUCHASE","GTDA VENTURES",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    Form1 form1 = new Form1();
                    form1.ShowDialog();
                    this.Hide();
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
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form22 f = new Form22();
            f.ShowDialog();
            this.Hide();
        }

        /*private void button2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.ShowDialog();
            this.Hide();
        }*/
    }
}
