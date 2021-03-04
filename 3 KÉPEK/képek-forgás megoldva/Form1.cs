using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace képek_forgás
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox4.Image = pictureBox1.Image;
            pictureBox1.Image = pictureBox2.Image;
            pictureBox2.Image = pictureBox3.Image;
            pictureBox3.Image = pictureBox4.Image;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox4.Image = pictureBox3.Image;
            pictureBox3.Image = pictureBox2.Image;
            pictureBox2.Image = pictureBox1.Image;
            pictureBox1.Image = pictureBox4.Image;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            pictureBox4.Visible = false;
            int n = rnd.Next(1, 10);
            for (int i = 0; i < n; i++)
            {
                pictureBox4.Image = pictureBox3.Image;
                pictureBox3.Image = pictureBox2.Image;
                pictureBox2.Image = pictureBox1.Image;
                pictureBox1.Image = pictureBox4.Image;
                Thread.Sleep(1000);
            }
            pictureBox4.Visible = true;


        }
    }
}
