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
            int kezdo = int.Parse(kezdoTxb.Text);
            int vegso = int.Parse(vegsoTxb.Text);
            int szum = 0;
            for (int i = kezdo; i <= vegso; i++)
            {
                szum = szum + i;    //szum+=i;
            }
            osszegLbl.Text = szum.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kezdo = int.Parse(kezdoTxb.Text);
            int vegso = int.Parse(vegsoTxb.Text);
            int szumparos = 0;

            for (int i = kezdo; i <= vegso; i++)
            {
                if (i % 2 == 0)
                {
                    szumparos = szumparos + i;
                }

            }
            parososszegLbl.Text = szumparos.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int kezdo = int.Parse(kezdoTxb.Text);
            int vegso = int.Parse(vegsoTxb.Text);
            int szumparatlan = 0;

            for (int i = kezdo; i <= vegso; i++)
            {
                if (i % 2 == 1)
                {
                    szumparatlan = szumparatlan + i;
                }

            }
            paratlanosszegLbl.Text = szumparatlan.ToString();
        }

        private void osztokBtn_Click(object sender, EventArgs e)
        {
            int szam = int.Parse(szamTxb.Text);
            for (int i = 1; i <= szam; i++)
            {
                if (szam % i == 0)
                {
                    osztokRTxb.AppendText(i.ToString());
                    if (i < szam)
                    {
                        osztokRTxb.AppendText("\r\n");
                    }
                }
            }
        }

        private void torolBtn_Click(object sender, EventArgs e)
        {
            osztokRTxb.Clear();
            kezdoTxb.Clear();
            vegsoTxb.Clear();
            szamTxb.Clear();
        }
    }
}
