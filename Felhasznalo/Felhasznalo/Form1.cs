using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Felhasznalo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kilepBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fnevBtn_Click(object sender, EventArgs e)
        {
            String vNev = vnevTxt.Text;
            String kNev = knevTxt.Text;

            if (vNev.Length < 3 || kNev.Length < 3) {
                MessageBox.Show("A nevek legalább 3 betűből kell álljanak...");
            } else {
                vNev = vNev.Trim();
                MessageBox.Show("-" + vNev + "-");
                kNev = kNev.Trim();
                MessageBox.Show("-" + kNev + "-");

                vNev = vNev.ToUpper();
                kNev = kNev.ToUpper();

                String monogram = vNev.Substring(0,1) + kNev.Substring(0,1);
              
                Random veletlen = new Random();
                int szam = veletlen.Next(100,1000);
                String fNev = monogram + szam.ToString();

                fnevTxt.Text = fNev;
                fnevLbl.Visible = true;
                fnevTxt.Visible = true;


            }
        }
    }
}
