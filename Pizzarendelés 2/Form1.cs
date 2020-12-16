using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzarendelés_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int osszeg = 0;
            if (rbHavaii.Checked==true)
                osszeg += int.Parse(rbHavaii.Text.Split(' ')[1]);
            else if(rbTengeri.Checked)
                osszeg += int.Parse(rbTengeri.Text.Split(' ')[1]);
            else if (rbUres.Checked)
                osszeg += int.Parse(rbUres.Text.Split(' ')[1]);

            if(rbKicsi.Checked)
                osszeg += int.Parse(rbKicsi.Text.Split(' ')[1]);
            else if (rbKozepes.Checked)
                osszeg += int.Parse(rbKozepes.Text.Split(' ')[1]);
            else if (rbNagy.Checked)
                osszeg += int.Parse(rbNagy.Text.Split(' ')[1]);

            if (chbCsipos.Checked)
                osszeg += int.Parse(chbCsipos.Text.Split(' ')[1]);
            if (chbMajonez.Checked)
                osszeg += int.Parse(chbMajonez.Text.Split(' ')[1]);
            if (chbMustar.Checked)
                osszeg += int.Parse(chbMustar.Text.Split(' ')[1]);
            if (chbParadicsom.Checked)
                osszeg += int.Parse(chbParadicsom.Text.Split(' ')[1]);



            lbOsszeg.Text = "Összeg: " + osszeg.ToString()+" ft";
        }
    }
}
