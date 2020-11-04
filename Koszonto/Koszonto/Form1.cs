using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Koszonto
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

        private void keszBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Jó munkát "+nevTxt.Text+"!");
        }
    }
}
