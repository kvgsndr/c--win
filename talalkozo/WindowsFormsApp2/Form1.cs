using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            DateTime dat1 = new DateTime();
            

            dat1 = DateTime.Now;
            //2019.11.12.   10:20
            int ev = Int32.Parse(textBox1.Text.Substring(0, 4));
            int ho = Int32.Parse(textBox1.Text.Substring(5, 2));
            int nap = Int32.Parse(textBox1.Text.Substring(8, 2));
            int ora = Int32.Parse(textBox2.Text.Substring(0, 2));
            int perc = Int32.Parse(textBox2.Text.Substring(3, 2));
            DateTime dat2 = new DateTime(ev, ho, nap, ora, perc, 0);
            label2.Text = "Találkozó időpontja: " + dat2.ToShortDateString() + " " + dat2.ToShortTimeString();
            label3.Text = "Jelenlegi idő: " + dat1.ToShortDateString() + " " + dat1.ToShortTimeString();

            var kulombseg = dat2 - dat1;
            if (kulombseg.Minutes > 0)
                label4.Text =kulombseg.Days+" nap " +kulombseg.Hours + " óra " + kulombseg.Minutes + " perc "+kulombseg.Seconds+ " másodperc van hátra";
            else
                label4.Text = "Elkéstél!";


        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }
    }
}
