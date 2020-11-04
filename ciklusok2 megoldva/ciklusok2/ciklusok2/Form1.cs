using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ciklusok2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void osszegBtn_Click(object sender, EventArgs e)
        {
            int kezdo = Convert.ToInt32(kezdoTxb.Text);
            int vegso = Convert.ToInt32(vegsoTxb.Text);
            listBox1.Items.Clear();
            int szum = 0;
            for (int i = kezdo; i <= vegso; i++)
            {
                listBox1.Items.Add(i);
                szum = szum + i;  
                //szum+=i; így is működik
            }
            osszegLbl.Text = szum.ToString();
            
         }

        private void button1_Click(object sender, EventArgs e)
        {
            int szam = Convert.ToInt32(szamTxb.Text);
            for (int i = 1; i <= szam; i++)
            {
                if (szam % i == 0)
                {
                    listBox1.Items.Add(i);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
