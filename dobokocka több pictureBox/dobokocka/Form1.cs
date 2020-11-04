using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dobokocka
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random d = new Random();
            int dobott = d.Next(1, 7);

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;

            switch (dobott)
            {
                case 1 : pictureBox1.Visible = true; break;
                case 2 : pictureBox2.Visible = true; break;
                case 3 : pictureBox3.Visible = true; break;
                case 4 : pictureBox4.Visible = true; break;
                case 5 : pictureBox5.Visible = true; break;
                case 6 : pictureBox6.Visible = true; break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;

        }
    }
}
