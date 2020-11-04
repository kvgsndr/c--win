using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parabola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kilepBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void gyokokBtn_Click(object sender, EventArgs e)
        {   //válasz címkék láthatóságának levétele, hogy ne legyenek ott az űrlapon
            valaszLbl.Visible = false;
            valasz1Lbl.Visible = false;

            //együthatók átvétel a szövegdobozokból
            double a = double.Parse(aTxt.Text);
            double b = double.Parse(bTxt.Text);
            double c = double.Parse(cTxt.Text);

            //diszkrimináns meghatározása
            double d = Math.Pow(b,2) - 4*a*c;

            if(d < 0){
                valaszLbl.Text = "Nincs valós gyök.";
                valaszLbl.Visible = true;
            } else {
                if(d == 0){
                    double x = -1 * b / (2 * a);
                    valaszLbl.Text = "Az egyetlen gyöke a " + x.ToString("N3") + " pontban van.";
                    valaszLbl.Visible = true;
                
                }else{
                    double x1 = (-1 * b + Math.Sqrt(d)) / (2 * a);
                    double x2 = (-1 * b - Math.Sqrt(d)) / (2 * a);
                    valaszLbl.Text = "Az egyik gyöke a(z) " + x1.ToString("N3") + " pontban van.";
                    valaszLbl.Visible = true;
                    valasz1Lbl.Text = "A másik gyöke a(z) " + x2.ToString("N3") + " pontban van.";
                    valasz1Lbl.Visible = true;
                }
            }

        }
    }
}
