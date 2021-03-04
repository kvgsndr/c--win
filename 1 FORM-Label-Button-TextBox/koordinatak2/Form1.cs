using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace koordinatak2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x, y;
            x = double.Parse(textBox1.Text);
            y = double.Parse(textBox2.Text);
            if (x>0 && y>0)
            {
                label3.Text = "Első kvadráns";
            }
            else if(x < 0 && y > 0)
            {
                label3.Text = "Második kvadráns";
            }
            else if(x < 0 && y < 0)
            {
                label3.Text = "Harmadik kvadráns";
            }
            else if (x > 0 && y < 0)
            {
                label3.Text = "Negyedik kvadráns";
            }
            else
                label3.Text = "Tengelyen helyezkedik el";

        }
    }
}
