using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace haromszog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = double.Parse(aTxt.Text);
            double b = double.Parse(bTxt.Text);
            double c = double.Parse(cTxt.Text);
            if (a<b+c && b<a+c && c<a+b)
            {
                kiirLbl.Text = " A megadott oldalak: " + (a) + ", " + (b) + ", " + (c);
                kiir2Lbl.Text = "A megadott adatokkal szekeszthető háromszög.";
                kiirLbl.Visible = true;
                kiir2Lbl.Visible = true;
            }

            else
            {
                kiirLbl.Text = " A megadott oldalak: " + (a) + ", " + (b) + ", " + (c);
                kiir2Lbl.Text = "A megadott adatokkal NEM szekeszthető háromszög.";
                kiirLbl.Visible = true;
                kiir2Lbl.Visible = true;
            }
        }
    }
}
