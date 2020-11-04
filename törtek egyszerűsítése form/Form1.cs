using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace törtek_egyszerűsítése_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            int nevezo = Convert.ToInt32(tbNevező.Text);
            int szamlalo = Convert.ToInt32(tbSzámláló.Text);
            int kis = Math.Min(nevezo, szamlalo);
            int oszto=1;
            for (int i = 2; i <= kis; i++)
            {
                if (nevezo % i == 0 && szamlalo % i == 0 )
                    oszto = i;
            }
            nevezo /= oszto;
            szamlalo /= oszto;
            lbNevező.Text = nevezo.ToString();
            lbSzámláló.Text = szamlalo.ToString();


        }
    }
}
