using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace szövegek
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

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mondat = textBox1.Text;
            textBox2.Text = mondat.ToLower();
            textBox3.Text = mondat.ToUpper();
            textBox4.Text = mondat.Trim();
            textBox5.Text = mondat.Substring(5,2);

            textBox6.Text = mondat.GetType().ToString();
            listBox1.Items.Clear();
            listBox1.Items.AddRange(mondat.Split(' '))  ;
            textBox7.Text = mondat.IndexOf("egy").ToString();
            textBox8.Text = mondat.Remove(6, 3);
            textBox9.Text = mondat.Replace("Ez", "Ez az az ");
        }
    }
}
