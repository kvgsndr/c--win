using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Magasság(cm): ";
            label2.Text = "Testsúlyn (kg): ";
            button1.Text = "OK";
            label3.Text = "TestTömegIndex:";
            label4.Text = "";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            double testsuly;
            double magasság;
            testsuly = Convert.ToDouble(textBox2.Text);
            magasság = Convert.ToDouble(textBox1.Text);
            magasság /= 100;  // magasság=magasság/100;
            double tti = testsuly / (magasság * magasság);
            string stti = String.Format("{0}", tti);
            if(tti<16)
                label4.Text = stti+ "\nsúlyos soványság";
            else if(tti<16.99)
                label4.Text = stti + "\nmérsékelt soványság";
            else if(tti<18.49)
                label4.Text = stti + "\nenyhe soványság";
            else if (tti < 24.99)
                label4.Text = stti + "\nnormál testsúly";
            else if (tti < 29.99)
                 label4.Text = stti + "\ntulsúlyos";
            else if (tti < 34.99)
                 label4.Text = stti + "\n1.fokú elhízás";
            else if (tti < 34.99)
                label4.Text = stti + "\n2.fokú elhízás";
            else
                label4.Text = stti + "\n3.fokú elhízás";



        }
    }
}
