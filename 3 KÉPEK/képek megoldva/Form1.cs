using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace képek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            pictureBox4.Image = pictureBox1.Image;
            pictureBox1.Image = pictureBox2.Image;
            pictureBox2.Image = pictureBox3.Image;
            pictureBox3.Image = pictureBox4.Image;
        }
    }
}
