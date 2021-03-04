using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kepmeretezo
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

        private void meretBtn_Click(object sender, EventArgs e)
        {
            int szeles = hScrollBar1.Value;
            int magas = vScrollBar1.Value;

            pictureBox1.Width = szeles;
            pictureBox1.Height = magas;
        }

        private void visszaBtn_Click(object sender, EventArgs e)
        {
            pictureBox1.Width = 550;
            pictureBox1.Height = 550;

            hScrollBar1.Value = 550;
            vScrollBar1.Value = 550;
        }
    }
}
