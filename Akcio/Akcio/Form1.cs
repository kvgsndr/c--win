using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Akcio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void szamolBtn_Click(object sender, EventArgs e)
        {
            int ar = int.Parse(arTxt.Text);
            int enged = int.Parse(engedTxt.Text);

            int ujar = ar * (100 - enged) / 100;
            /*
            valaszLbl.Text = "Akciós ár: " + ujar.ToString() + " Ft";
            valaszLbl.Visible = true;
             */
            ujarTxt.Text = ujar.ToString();
        }

        private void kilepBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
