using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void piros_Btn_Click(object sender, EventArgs e)
        {
            BackColor = Color.Red;
        }

        private void zold_Btn_Click(object sender, EventArgs e)
        {
            BackColor = Color.Green;
        }

        private void kek_Btn_Click(object sender, EventArgs e)
        {
            BackColor = Color.Blue;
        }

        private void kilep_Btn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
