using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tippelős
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TippBtn_Click(object sender, EventArgs e)
        {
            Random veletlen = new Random();
            int gondoltam = veletlen.Next(1 , 11);
            int tipp = int.Parse(tippBtx.Text);

            if (tipp > 10 || tipp < 1)
            {



                MessageBox.Show("1 és 10 között tippelj!", "Hiba");
            }
            else
            {
                if (tipp == gondoltam) ;
                label2.Text = "Sajnos nem találtad el a számot, mert" + gondoltam + "-ra gondoltam";




            }
        }
    }
}
    

