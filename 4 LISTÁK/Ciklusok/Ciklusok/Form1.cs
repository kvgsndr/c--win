using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ciklusok
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kilaapBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i=0; i<=9; i++) {
                listaTxB.AppendText(i.ToString());
                if (i < 9)
                {
                    listaTxB.AppendText("\r\n");
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listaTxB.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 14; i++)
            {
                listaTxB.AppendText((2*i).ToString());
                if (i < 14)
                {
                    listaTxB.AppendText("\r\n");
                }

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 12; i++)
            {
                listaTxB.AppendText((i*i).ToString());
                if (i < 12)
                {
                    listaTxB.AppendText("\r\n");
                }

            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 10; i++)
            {
                listaTxB.AppendText(Math.Pow(2,i).ToString());
                if (i < 10)
                {
                    listaTxB.AppendText("\r\n");
                }

            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            int eddig = 1;
            for (int i = 1; i <= 10; i++)
            {
                eddig *= 2;
                listaTxB.AppendText(eddig.ToString());
                if (i < 10)
                {
                    listaTxB.AppendText("\r\n");
                }

            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            for (int i = 65; i <= 90; i++)
            {
                char betu = (char)i;
                listaTxB.AppendText(betu.ToString());
                if (i < 90)
                {
                    listaTxB.AppendText("\r\n");
                }

            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            for (int i = 97; i <= 122; i++)
            {
                char betu = (char)i;
                listaTxB.AppendText(betu.ToString());
                if (i < 122)
                {
                    listaTxB.AppendText("\r\n");
                }

            }

        }
    }
}
