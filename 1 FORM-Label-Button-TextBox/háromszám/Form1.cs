using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace háromszám
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtA.Text);
            int b = int.Parse(txtB.Text);
            int c = int.Parse(txtC.Text);
            if (a>b) { int tmp = a;a = b;b = tmp; }
            if (b>c) { int tmp = b; b = c; c = tmp; }
            if (a>b) { int tmp = a; a = b; b = tmp; }

            txtRendA.Text = a.ToString();
            txtRendB.Text = b.ToString();
            txtRendC.Text = c.ToString();
           
            
        }
    }
}
