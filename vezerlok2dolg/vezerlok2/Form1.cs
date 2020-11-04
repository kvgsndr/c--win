using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vezerlok2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void nevTxt_TextChanged(object sender, EventArgs e)
        {
            udvLbl.Visible = true;
            kilepBtn.Enabled = true;
            udvBtn.ForeColor = Color.Red;
            udvLbl.Text = "Szia ...";

        }

        private void udvBtn_Click(object sender, EventArgs e)
        {
            udvLbl.Text = "Szia " + nevTxt.Text + "!";
            BackColor = Color.Yellow;
        }

        private void kilepBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
