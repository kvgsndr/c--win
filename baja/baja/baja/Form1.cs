using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baja
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mutatBtn_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked) {
                pictureBox1.Image = new Bitmap("baja_regi.png");
            } else {
                pictureBox1.Image = new Bitmap("baja.jpg");
            }
        }

        private void kilepBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
