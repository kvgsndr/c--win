using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EGÉRKATTLABEL
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        int osszeg = 0, n = 0;
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Random rnd = new Random();
            Label a = new Label();
            a.Location = new Point(e.X, e.Y);
            int szam = rnd.Next(1, 100);
            a.Text = szam.ToString();
            Controls.Add(a);
            osszeg += szam;
            n++;
            if (n == 1)
                label1.Visible = true;
            label1.Text = "ÁTLAG= "+((double)osszeg / n).ToString();

        }
    }
}
