using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kockajáték
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btJatek_Click(object sender, EventArgs e)
        {
            Random dob = new Random();
            int dobás1 = dob.Next(1, 7);
            int jatekos = dobás1;
            switch(dobás1)
            {
                case 1:
                    pictureBox1.Image = new Bitmap("1.jpg");
                    break;
                case 2:
                    pictureBox1.Image = new Bitmap("2.jpg");
                    break;
                case 3:
                    pictureBox1.Image = new Bitmap("3.jpg");
                    break;
                case 4:
                    pictureBox1.Image = new Bitmap("4.jpg");
                    break;
                case 5:
                    pictureBox1.Image = new Bitmap("5.jpg");
                    break;
                default:
                    pictureBox1.Image = new Bitmap("6.jpg");
                    break;
            }
        }
    }
}
