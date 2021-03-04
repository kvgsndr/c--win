using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dolg_nov_BD2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
       
        {
            if (benzinRbtn.Checked)
            {
                if (elsoRbtn.Checked)
                {
                    double a, ertek;
                    a = double.Parse(megtettutTbx.Text);
                    ertek = (a * 389 * 7.6 / 100);
                    label6.Text = ertek.ToString() + "Ft";
                }
                else if (masodikRbtn.Checked)
                {
                    double a, ertek;
                    a = double.Parse(megtettutTbx.Text);
                    ertek = (a * 389 * 8.6 / 100);
                    label6.Text = ertek.ToString() + "Ft";
                }
                else if (harmadikRbtn.Checked)
                {
                    double a, ertek;
                    a = double.Parse(megtettutTbx.Text);
                    ertek = (a * 389 * 9.5 / 100);
                    label6.Text = ertek.ToString() + "Ft";
               
               }
                else if (negyedikRbtn.Checked)
                {
                    double a, ertek;
                    a = double.Parse(megtettutTbx.Text);
                    ertek = (a * 389 * 11.4 / 100);
                    label6.Text = ertek.ToString() + "Ft";
                }
                else if (otodikRbtn.Checked)
                {
                    double a, ertek;
                    a = double.Parse(megtettutTbx.Text);
                    ertek = (a * 389 * 13.3 / 100);
                    label6.Text = ertek.ToString() + "Ft";
                }
            }

            else if (gazolajRbtn.Checked)
            {
                if (elsoRbtn.Checked)
                {
                    double b, ertek2;
                    b = double.Parse(megtettutTbx.Text);
                    ertek2 = (b * 423 * 4.7 / 100);
                    label6.Text = ertek2.ToString() + "Ft";
                }
                else if (masodikRbtn.Checked)
                {
                    double b, ertek2;
                    b = double.Parse(megtettutTbx.Text);
                    ertek2 = (b * 423 * 5.7 / 100);
                    label6.Text = ertek2.ToString() + "Ft";
                }
                else if (harmadikRbtn.Checked)
                {
                    double b, ertek2;
                    b = double.Parse(megtettutTbx.Text);
                    ertek2 = (b * 423 * 6.7 / 100);
                    label6.Text = ertek2.ToString() + "Ft";
                }
                else if (negyedikRbtn.Checked)
                {
                    double b, ertek2;
                    b = double.Parse(megtettutTbx.Text);
                    ertek2 = (b * 423 * 7.6 / 100);
                    label6.Text = ertek2.ToString() + "Ft";
                }
                else if (otodikRbtn.Checked)
                {
                    double b, ertek2;
                    b = double.Parse(megtettutTbx.Text);
                    ertek2 = (b * 423 * 9.5/ 100);
                    label6.Text = ertek2.ToString() + "Ft";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
