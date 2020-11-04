using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SzerkeszthetoHaromszog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kileoBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ellenorBtn_Click(object sender, EventArgs e)
        {
            double a = double.Parse(aTxt.Text);
            double b = double.Parse(bTxt.Text);
            double c = double.Parse(cTxt.Text);
   
            if(a>0 && b>0 && c>0 && a+b>c && a+c>b && b+c>a){
                pictureBox1.Image = new Bitmap(@"H:\CSharp\SzerkeszthetoHaromszog\SzerkeszthetoHaromszog\haromszog.png");
            }else{
                pictureBox1.Image = new Bitmap(@"H:\CSharp\SzerkeszthetoHaromszog\SzerkeszthetoHaromszog\nemharomszog.png");
            }
        }
    }
}
