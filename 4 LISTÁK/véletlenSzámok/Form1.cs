using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace véletlenSzámok
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 0; i < 10; i++)
            {
                listBox1.Items.Add(rnd.Next(11));  // x>=0 és x<11
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 0; i < 10; i++)
            {
                listBox1.Items.Add(rnd.Next(11)+5);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 0; i < 10; i++)
            {
                listBox1.Items.Add(rnd.Next(101) -50);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 0; i < 10; i++)
            {
                listBox1.Items.Add(rnd.Next(-30, 51 ));
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear();
            for (int i = 0; i < 10; i++)
            {
                listBox1.Items.Add(rnd.NextDouble());// 0<= x <1
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 0; i < 10; i++)
            {
                listBox1.Items.Add(rnd.NextDouble()*100);  //0<= X <100
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 0; i < 10; i++)
            {
                listBox1.Items.Add(rnd.NextDouble() * 100 -50);//  -50 <=` x < 50
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 0; i < 10; i++)
            {
                listBox1.Items.Add(rnd.Next());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "MAXINT32=" + Int32.MaxValue.ToString();
            label2.Text = "MININT32=" + Int32.MinValue.ToString();
            label3.Text = "UMaxInt32= " + UInt32.MaxValue.ToString();
            label4.Text = "UMinInt32= " + UInt32.MinValue.ToString();
        }
    }
}
