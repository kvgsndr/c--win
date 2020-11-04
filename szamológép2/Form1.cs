using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace szamológép2
{
    public partial class Form1 : Form
    {
        double a, b;
        char m;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void plussz_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            m = '+';
            textBox1.Clear();
        }

        private void egyenlo_Click(object sender, EventArgs e)
        {
            b = Convert.ToDouble(textBox1.Text);
            
             if(m =='+')
                   textBox1.Text=(a + b).ToString();
            else if(m=='-')
                textBox1.Text = (a - b).ToString();
            else if (m == '*')
                textBox1.Text = (a * b).ToString();
            else if (m == '/')
                textBox1.Text = ((double)a / b).ToString();
        }

        private void b2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void b3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void b4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void b5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void b6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void b7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void b8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void b9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void b0_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void minusz_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            m = '-';
            textBox1.Clear();
        }

        private void szor_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            m = '*';
            textBox1.Clear();
        }

        private void oszt_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            m = '/';
            textBox1.Clear();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += ',';
        }

        private void torol_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            //textBox1.Text="";
        }
    }
}
