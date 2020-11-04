using dobokocka6.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dobokocka6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int kocka = rnd.Next(1, 7);
            string nev = "kocka" + kocka.ToString() + ".PNG";

            //pictureBox1.ImageLocation = "..\\..\\Resources\\"+nev;
            pictureBox1.ImageLocation = @"..\..\Resources\" + nev;


        }
    }
}
