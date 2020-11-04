using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace másodfoku_egyenlet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c;
            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);
            c = Convert.ToDouble(textBox3.Text);
            double d = b * b - 4 * a * c;
            if (d < 0)
                lbEredmeny.Text = "Nincs megoldás!!!";
            else if (d == 0)
                lbEredmeny.Text = "X=" + (-b / (2 * a)).ToString();
            else
                // lbEredmeny.Text = "X1=" + (-b + Math.Sqrt(d) / (2 * a)).ToString() + "   X2=" + (-b - Math.Sqrt(d) / (2 * a)).ToString();
                lbEredmeny.Text = "X1=" + String.Format("{0:0.00}", (-b + Math.Sqrt(d) / (2 * a))) + "  X2=" + String.Format("{0:0.00}", (-b - Math.Sqrt(d) / (2 * a)));

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Biztosan kilép???", "Kilépés", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Close();
        }
    }
}
