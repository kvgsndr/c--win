using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace háromszögek2
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
            int a, b, c;

            for (int i = 0; i < 100; i++)
            {
                a = rnd.Next(1, 21);
                b = rnd.Next(1, 21);
                c = rnd.Next(1, 21);

                if (a < c + b && b < a + c && c < a + b)
                    listBox1.Items.Add(a.ToString() + " " + b.ToString() + " " + c.ToString() + "  Háromszög lehetséges");
                else
                    listBox1.Items.Add(a.ToString() + " " + b.ToString() + " " + c.ToString() + "  Háromszög NEM lehetséges");

            }
        }
    }
}
