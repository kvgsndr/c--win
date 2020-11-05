using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jegy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nev = nevTbx.Text;
            int szam = int.Parse(vegerTbx.Text);

            string jegysz = "";
            {
                switch (szam)
                {




                    case 1:
                        jegysz = "elégtelen";
                        pictureBox1.Image = Image.FromFile("1.png");
                        label2.Text = nev + " a végeredmény: " + jegysz;
                        break;

                    case 2:
                        jegysz = "elégséges";
                        pictureBox1.Image = Image.FromFile("2.png");
                        label2.Text = nev + " a végeredmény: " + jegysz;
                        break;

                    case 3:
                        jegysz = "közepes";
                        pictureBox1.Image = Image.FromFile("3.png");
                        label2.Text = nev + " a végeredmény " + jegysz;
                        break;

                    case 4:
                        jegysz = "jó";
                        pictureBox1.Image = Image.FromFile("4.png");
                        label2.Text = nev + " a végeredmény " + jegysz;
                        break;

                    case 5:
                        jegysz = "kiváló";
                        pictureBox1.Image = Image.FromFile("5.png");
                        label2.Text = nev + " a végeredmény " + jegysz;
                        break;

                    default:
                        label2.Text = "nem megfelelő a paraméter";
                        break;
                }
            }
        }
    }
    }
            
