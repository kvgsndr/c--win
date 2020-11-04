using dobokocka.Properties;
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

        private void dobasBtn_Click(object sender, EventArgs e)
        {
            Random veletlen = new Random();
            int szam = veletlen.Next(1, 7);
            switch (szam)
            {
                case 1:
                    //pictureBox1.Image = new Bitmap("1.jpg"); 
                    pictureBox1.Image = Resources._1;
                    break;
                case 2:
                    //pictureBox1.Image = new Bitmap("2.jpg");
                    pictureBox1.Image = Resources._2;
                    break;
                case 3:
                    //pictureBox1.Image = new Bitmap("3.jpg");
                    pictureBox1.Image = Resources._3;
                    break;
                case 4:
                    //pictureBox1.Image = new Bitmap("4.jpg");
                    pictureBox1.Image = Resources._4;
                    break;
                case 5:
                    //pictureBox1.Image = new Bitmap("5.jpg");
                    pictureBox1.Image = Resources._5;
                    break;
                default:
                    //pictureBox1.Image = new Bitmap("6.jpg");
                    pictureBox1.Image = Resources._6;
                    break;
            }
           

        }

        private void kilepBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
