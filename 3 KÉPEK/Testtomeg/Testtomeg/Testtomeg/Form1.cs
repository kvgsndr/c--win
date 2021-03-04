using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testtomeg
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

        private void szamolBtn_Click(object sender, EventArgs e)
        {
            int kg = int.Parse(kgTxt.Text);
            int cm = int.Parse(cmTxt.Text);

            double m2 = Math.Pow(1.0 * cm / 100, 2);
            double tti = kg / m2;

           if (ffiChk.Checked) {
                
                if ()

            }
            else {
                
               

            }

            valaszTxt.Visible = true;
            hosszuTxt.Visible = true;

        }
    }
}
