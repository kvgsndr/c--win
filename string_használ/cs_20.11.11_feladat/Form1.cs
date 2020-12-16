using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cs_20._11._11_feladat
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = String.Empty;

            string alapSzöveg = textBox1.Text;
            alapSzöveg = alapSzöveg.Trim();

            textBox2.Text = alapSzöveg;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = String.Empty;

            string alapSzöveg = textBox1.Text;

            alapSzöveg = alapSzöveg.ToUpper();

            textBox2.Text = alapSzöveg;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text = String.Empty;
            string alapSzöveg = textBox1.Text;

            alapSzöveg = alapSzöveg.ToLower();

            textBox2.Text = alapSzöveg;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox2.Text = String.Empty;
            string alapSzöveg = textBox1.Text;
             int db = Convert.ToInt32(this.textBox3.Text);
             alapSzöveg = alapSzöveg.Substring(db);
             textBox2.Text = alapSzöveg;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox2.Text = String.Empty;
            string alapSzöveg = textBox1.Text;
            string keresSzöveg = textBox4.Text;
            int válasz;

            válasz = alapSzöveg.IndexOf(keresSzöveg);
            textBox2.Text = válasz.ToString() + ". helyen található a keresett szöveg!";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox2.Text = String.Empty;
            string alapSzöveg = textBox1.Text;
            string válasz;

            válasz = alapSzöveg.Length.ToString();
            textBox2.Text = válasz + " db karaktert tartalmaz a szöveg.";
        }
    }
}
