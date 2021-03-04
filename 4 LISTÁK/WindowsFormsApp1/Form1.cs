using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            for (int i = 0; i < 100; i++)
            {
                int a, b, c;
                a = rnd.Next(20) + 1;
                b = rnd.Next(20) + 1;
                c = rnd.Next(20) + 1;
                if (a<b+c && b<a+c && c<a+b)
                    listBox1.Items.Add(a.ToString() + " " + b.ToString() + " " + c.ToString()+ " Háromszög");
                else
                    listBox1.Items.Add(a.ToString() + " " + b.ToString() + " " + c.ToString()+ " NEM Háromszög");




            }
        }
    }
}
