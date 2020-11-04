using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jegy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nev = nevTxt.Text;
            int jegy = int.Parse(jegyTxt.Text);
            string jegysz = "";
            switch (jegy)
            {
                case 1:
                    jegysz = "elégtelen";
                    jegyPtx.Image = new Bitmap("1.png");
                    break;
                case 2:
                    jegysz = "elégséges";
                    jegyPtx.Image = new Bitmap("2.png");
                    break;
                case 3:
                    jegysz = "közepes";
                    jegyPtx.Image = new Bitmap("3.png");
                    break;
                case 4:
                    jegysz = "jó";
                    jegyPtx.Image = new Bitmap("4.png");
                    break;
                case 5:
                    jegysz = "jeles";
                    jegyPtx.Image = new Bitmap("5.png");
                    break;
                
     
            }
            eredmenyLbl.Text = nev + " " + jegysz + " " + "eredménnyel végzett a programozás vizsgán.";
            eredmenyLbl.Visible = true;
        }
    }
}
