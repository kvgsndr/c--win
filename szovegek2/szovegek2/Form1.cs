using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace szovegek2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      

        private void ellenorizBtn_Click_1(object sender, EventArgs e)
        {
            //kezdőbetű
            string nev = nevTxt.Text;
            char b = nev[0];
            kbetuLbl.Text = "A név kezdő betűje: " + b;

        }

        private void kodolBtn_Click(object sender, EventArgs e)
        {
             //Karakterek kódokkal
            int i = int.Parse(karTxt.Text);
            char k = (char)i;

            karLbl.Text = k.ToString();
            karLbl.Visible = true;
        }

        private void generalBtn_Click(object sender, EventArgs e)
        {
            //vezetéknév keresztnév levágása
            string v = vnevTxt.Text;
            string k = knevTxt.Text;
            string v3 = v.Substring(0, 3);
            string k3 = k.Substring(0, 3);
            
            //életlenszám
            Random vsz = new Random();

            //felhasználónév kiiratás
            string fnev = v3 + k3;
            fnevLbl.Text = fnev + vsz.Next(100, 1000);

        }
    }
}
