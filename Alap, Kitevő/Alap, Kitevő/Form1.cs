using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alap__Kitevő
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void hatvBtn_Click(object sender, EventArgs e)
        {
            int alap = int.Parse(alapTbx.Text);
            int kitevo = int.Parse(kitevoTbx.Text);
            for (int i = 0; i <= kitevo; i++)
            {
                hatvRtbx.AppendText(Math.Pow(alap, i).ToString() + "\n");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hatvRtbx.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 1001; i++)
                hatvRtbx.AppendText(i.ToString());







        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 300; i++)

             if (i % 4 == 0) {
                    hatvRtbx.AppendText((i).ToString() + "\n");

                }
            }

        private void button5_Click(object sender, EventArgs e)
        {
            for (int i = 500; i <= 800; i++)

            {if (i % 2 == 1) {
                    hatvRtbx.AppendText((i).ToString() + "\n");



            }
        }
    }

        private void button6_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 1000; i++)
            {if (i % 3 == 0 && i % 5 != 0)
                    hatvRtbx.AppendText((i).ToString() + "\n");

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Random veletlen = new Random();
            for (int i = 1; i <= 50; i++)
            {
                int szam = veletlen.Next(1, 50);
                hatvRtbx.AppendText(szam.ToString()+"\n");



            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Random veletlen = new Random();
            for (int i = -20; i <=20 ; i++)

            {
                int szam = veletlen.Next(-20, 20);
                hatvRtbx.AppendText(szam.ToString() + "\n");

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            for (int i = 65; i >= 1; i--)
            {
                hatvRtbx.AppendText((i).ToString() + ", ");

            }
        }
    }
}
