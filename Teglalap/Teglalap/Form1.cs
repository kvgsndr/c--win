using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teglalap
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
            terLbl.Text = "Terület: " + (double.Parse(aTxt.Text) * double.Parse(bTxt.Text)).ToString();
            terLbl.Visible = true;

            kerLbl.Text = "Kerület: " + (2 * (double.Parse(aTxt.Text) + double.Parse(bTxt.Text))).ToString();
            kerLbl.Visible = true;
        }
    }
}
