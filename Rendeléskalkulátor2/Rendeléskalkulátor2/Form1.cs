using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rendeléskalkulátor2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                double ar = int.Parse(textBox1.Text);
                int darab = int.Parse(textBox2.Text);
                double termek = ar * darab;
                
                if (radioButton1.Checked)
                {
                    termek = termek * 1.15;
                    label8.Text = ar.ToString();
                }
                else
                {



                    if (radioButton2.Checked)
                    {
                        termek = termek * 1.1;
                        label8.Text = ar.ToString();

                        if (radioButton3.Checked)
                            label8.Text = ar.ToString();
                        else
                            label9.Text = ar.ToString();
                    }
                }
                label8.Text = "" + termek;
                double kedvezmény;
                if (checkBox1.Checked)
                {
                    kedvezmény = termek - (termek * 0.05);
                    label9.Text = "" + kedvezmény;
                }

                if (checkBox2.Checked)
                {
                    kedvezmény = termek - (termek * 0.1);
                    label9.Text = "" + kedvezmény;

                    if (checkBox1.Checked && checkBox2.Checked)
                        kedvezmény = termek - (termek * 0.15);
                    label9.Text = "" + kedvezmény;
                }
               


               
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bőr +15%, Kemény +10%,Papír 0% emelkedést jelent");
        }
    }
}
