using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace belepok
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void fizetesBtn_Click(object sender, EventArgs e)
        {
            int kor;
            double ar;
            kor = int.Parse(korTxt.Text);
            if (d3chbx.Checked)
            {
                if (kor < 15)
                {
                    ar = 1500*1.1;
                    kiirLbl.Text = ar.ToString();
                    kepPcBx.Image = new Bitmap("gyerek.jpg");

                }
                else if (kor < 60)
                {
                    ar = 2000 * 1.1;
                    kiirLbl.Text = ar.ToString();
                    kepPcBx.Image = new Bitmap("felnott.jpg");
                }
                else
                {

                    ar = 1800*1.1;
                    kiirLbl.Text = ar.ToString();
                    kepPcBx.Image = new Bitmap("nyugdijas.jpg");
                }
            }
            else
            {
                if (kor < 15)
                {
                    ar = 1500;
                    kiirLbl.Text = ar.ToString();
                    kepPcBx.Image = new Bitmap("gyerek.jpg");

                }
                else if (kor < 60)
                {
                    ar = 2000;
                    kiirLbl.Text = ar.ToString();
                    kepPcBx.Image = new Bitmap("felnott.jpg");
                }
                else
                {

                    ar = 1800;
                    kiirLbl.Text = ar.ToString();
                    kepPcBx.Image = new Bitmap("nyugdijas.jpg");
                }

            }
        }

        
    }
}
