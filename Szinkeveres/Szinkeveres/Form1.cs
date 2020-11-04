using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Szinkeveres
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

        private void szinezBtn_Click(object sender, EventArgs e)
        {
            int red = redScrollBar.Value;
            int green = greenScrollBar.Value;
            int blue = blueScrollBar.Value;

            int bred = 255-red;
            int bgreen = 255-green;
            int bblue = 255-blue;

            BackColor = Color.FromArgb(red, green, blue);
            label1.ForeColor = Color.FromArgb(bred, bgreen, bblue);
            label2.ForeColor = Color.FromArgb(bred, bgreen, bblue);
            label3.ForeColor = Color.FromArgb(bred, bgreen, bblue);
            label4.ForeColor = Color.FromArgb(bred, bgreen, bblue);
            label5.ForeColor = Color.FromArgb(bred, bgreen, bblue);
            label6.ForeColor = Color.FromArgb(bred, bgreen, bblue);

            rgbTxt.Text = "RGB(" + red.ToString() + "," + green.ToString() + "," + blue.ToString() + ")";
            rgbTxt.Visible = true;
        }
    }
}
