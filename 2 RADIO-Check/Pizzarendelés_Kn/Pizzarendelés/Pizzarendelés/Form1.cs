using Pizzarendelés.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzarendelés
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nev = textBox5.Text;
            int bolognai=0;
            int hawaii=0;
            int carbonara=0;

            if (checkBox1.Checked)
            {
                int darab = int.Parse(textBox1.Text);
                bolognai = 1200 * darab;
            }
            if (checkBox2.Checked)
            {
                
                int darab1 = int.Parse(textBox2.Text);
                carbonara = darab1 * 1300;
            }
            if (checkBox3.Checked)
            {
                
                int darab2 = int.Parse(textBox3.Text);                
                hawaii = darab2 * 1350;
            }
            int összeg = hawaii + carbonara + bolognai;
            //int összeg=darab*1200 + darab1*1300 +darab2*1350;

            label6.Text =összeg.ToString()+" ft "+ nev;

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("..\\..\\Resources\\hawaii.png");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap("..\\..\\Resources\\carbonara.jpg");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image =Resources.bolognai;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            label6.Text = "";
            textBox5.Text = "";
            radioButton1.Checked = false ;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
            textBox1.SelectAll();
        }
    }
}
