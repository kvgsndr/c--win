using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace számkitaláló
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        int szam;
        int tipp;
        int tippekszama = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            szam = rnd.Next(1, 101);
        }
        private void btErtekel_Click(object sender, EventArgs e)
        {
            tipp = int.Parse(textBox1.Text);
            if (tipp > szam)
                lbUzenet.Text = "A szám kissebb";
            else if (tipp < szam)
                lbUzenet.Text = "A szám nagyobb";
            else
            {
                lbUzenet.Text = "Kitaláltad!!!";
                btErtekel.Enabled = false;
            }

            tippekszama++;
            lbTipp.Text = tippekszama.ToString();
            textBox1.Focus();
            textBox1.SelectAll();
        }

        private void btUjJatek_Click(object sender, EventArgs e)
        {
            tippekszama = 0;
            lbTipp.Text = "0";
            textBox1.Clear();
            textBox1.Focus();
            szam = rnd.Next(1, 101);
            lbUzenet.Text = "";
            btErtekel.Enabled = true;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar ==(char) Keys.Enter)     btErtekel_Click(sender, e);
        }

        /*
         private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar ==(char) Keys.Enter)     
             {
                tipp = int.Parse(textBox1.Text);
            if (tipp > szam)
                lbUzenet.Text = "A szám kissebb";
            else if (tipp < szam)
                lbUzenet.Text = "A szám nagyobb";
            else
            {
                lbUzenet.Text = "Kitaláltad!!!";
                btErtekel.Enabled = false;
            }

            tippekszama++;
            lbTipp.Text = tippekszama.ToString();
            textBox1.Focus();
            textBox1.SelectAll();
        
             }
        }
         
         
         */

    }
}
