using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ablak01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pirosBtn.Visible = false;
            zoldBtn.Visible = false;
        }

        private void kilepesBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Viszlát!!!");
            Close();
        }

        private void pirosBtn_Click(object sender, EventArgs e)
        {
            BackColor = Color.Red;
        }

        private void zoldBtn_Click(object sender, EventArgs e)
        {
            BackColor = Color.Green;
        }

        private void szinezBtn_Click(object sender, EventArgs e)
        {
            pirosBtn.Visible = true;
            zoldBtn.Visible = true;
            szinezBtn.Visible = false;
        }
    }
}
