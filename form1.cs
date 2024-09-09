using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f=new Form2();
            f.ShowDialog();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.ShowDialog();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.ShowDialog();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form22 f = new Form22();
            f.ShowDialog();
            this.Hide();
        }
    }
}
