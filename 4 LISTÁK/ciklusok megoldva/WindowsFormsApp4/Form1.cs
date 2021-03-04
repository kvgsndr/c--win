using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void elsoBtn_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 11; i++)
            {
                listaLb.Items.Add(i);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void masodikBtn_Click(object sender, EventArgs e)
        {
            for (int i = 2; i <=30; i+=2)
            {
                listaLb.Items.Add(i);
            }
        }

        private void harmadikBtn_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <=12; i++)
            {
                listaLb.Items.Add(i*i);
            }
        }

        private void torolBtn_Click(object sender, EventArgs e)
        {
            listaLb.Items.Clear();
        }

        private void negyedikBtn_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <=10; i++)
                       listaLb.Items.Add(Math.Pow(2, i));
            
        }

        private void otodikBtn_Click(object sender, EventArgs e)
        {
            long hatvány = 1;
            for (int i = 0; i < 10; i++)
            {
                listaLb.Items.Add(hatvány *= 2);
            }
        }

        private void ABCBTN_Click(object sender, EventArgs e)
        {
            for (char i = 'A'; i <= 'Z'; i++)
            {
                listaLb.Items.Add(i);
            }
        }

        private void kilepesBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
