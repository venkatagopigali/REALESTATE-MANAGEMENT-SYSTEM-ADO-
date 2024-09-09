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
    public partial class Form20 : Form
    {
        string Connectionstring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\venka\\OneDrive\\Documents\\seller.mdf;Integrated Security=True;Connect Timeout=30";
        public Form20()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form19 form = new Form19();
            form.ShowDialog();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\venka\\OneDrive\\Documents\\seller.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select property from sell where num ='Form19.buyer_num'",conn);
            cmd.ExecuteNonQuery();
            conn.Close();

        }

        private void label17_Click(object sender, EventArgs e)
        {
            
        }

        private void Form20_Load(object sender, EventArgs e)
        {
            label17.Text = Form19.buyer_num;
            string query = "select property from sell where num='" + label17.Text + "'";
            using(SqlConnection conn = new SqlConnection(Connectionstring))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader re = cmd.ExecuteReader();
                    if(re.Read())
                    {
                        string data = re["property"].ToString();
                        label9.Text = data;
                    }
                    re.Close();
                }
                catch (Exception ex)
                {
                    label9.Text = "error"+ex.Message;
                }
            }
            string query1 = "select width from sell where num='" + label17.Text + "'";
            using (SqlConnection conn = new SqlConnection(Connectionstring))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query1, conn);
                    SqlDataReader re = cmd.ExecuteReader();
                    if (re.Read())
                    {
                        string data = re["width"].ToString();
                        label10.Text = data;
                    }
                    re.Close();
                }
                catch (Exception ex)
                {
                    label10.Text = "error" + ex.Message;
                }
            }
            string query2 = "select height from sell where num='" + label17.Text + "'";
            using (SqlConnection conn = new SqlConnection(Connectionstring))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query2, conn);
                    SqlDataReader re = cmd.ExecuteReader();
                    if (re.Read())
                    {
                        string data = re["height"].ToString();
                        label11.Text = data;
                    }
                    re.Close();
                }
                catch (Exception ex)
                {
                    label11.Text = "error" + ex.Message;
                }
            }
            string query3 = "select price from sell where num='" + label17.Text + "'";
            using (SqlConnection conn = new SqlConnection(Connectionstring))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query3, conn);
                    SqlDataReader re = cmd.ExecuteReader();
                    if (re.Read())
                    {
                        string data = re["price"].ToString();
                        label12.Text = data;
                    }
                    re.Close();
                }
                catch (Exception ex)
                {
                    label12.Text = "error" + ex.Message;
                }
            }
            string query4 = "select price from sell where num='" + label17.Text + "'";
            using (SqlConnection conn = new SqlConnection(Connectionstring))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query4, conn);
                    SqlDataReader re = cmd.ExecuteReader();
                    if (re.Read())
                    {
                        string data = re["price"].ToString();
                        float data1=Convert.ToInt32(data);
                        double data2 = (data1 * 25) / 100;
                        string data3=Convert.ToString(data2);
                        label13.Text = data3;
                    }
                    re.Close();
                }
                catch (Exception ex)
                {
                    label13.Text = "error" + ex.Message;
                }
            }
            string query5 = "select price from sell where num='" + label17.Text + "'";
            using (SqlConnection conn = new SqlConnection(Connectionstring))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query5, conn);
                    SqlDataReader re = cmd.ExecuteReader();
                    if (re.Read())
                    {
                        string data = re["price"].ToString();
                        float data4 = Convert.ToInt32(data);
                        double data5 = (data4 * 10) / 100;
                        string data6 = Convert.ToString(data5);
                        label14.Text = data6;
                    }
                    re.Close();
                }
                catch (Exception ex)
                {
                    label14.Text = "error" + ex.Message;
                }
            }
            string query6 = "select price from sell where num='" + label17.Text + "'";
            using (SqlConnection conn = new SqlConnection(Connectionstring))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query6, conn);
                    SqlDataReader re = cmd.ExecuteReader();
                    if (re.Read())
                    {
                        string data = re["price"].ToString();
                        float data4 = Convert.ToInt32(data);
                        double data7 = (data4 * 25) / 100;
                        double data5 = (data4 * 10) / 100;
                        double data8 = data5 + data7 + data4;
                        string data6 = Convert.ToString(data8);
                        label15.Text = data6;
                    }
                    re.Close();
                }
                catch (Exception ex)
                {
                    label15.Text = "error" + ex.Message;
                }
            }
        }
        Bitmap  bitmap;
        private void button2_Click(object sender, EventArgs e)
        {
            Panel panel = new Panel();
            this.Controls.Add(panel);
            Graphics graphics = panel.CreateGraphics();
            Size size = this.ClientSize;
            bitmap =  new Bitmap(size.Width, size.Height, graphics);
            graphics = Graphics.FromImage(bitmap);
            Point point = PointToScreen(panel.Location);
            graphics.CopyFromScreen(point.X,point.Y,0,0,size);
            printPreviewDialog1.ShowDialog();
            Form21  f = new Form21();
            f.ShowDialog();
            this.Hide();
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form22 form = new Form22();
            form.ShowDialog();
            this.Hide();
        }
    }
}
