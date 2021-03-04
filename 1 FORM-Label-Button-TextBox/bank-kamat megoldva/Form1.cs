using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bank_kamat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {   int m = Convert.ToInt16(ido.Text);
            double ö1 = Convert.ToDouble(osszeg.Text);
            double ö = ö1;
            double k = Convert.ToDouble(kamat.Text);
            for (int i = 0; i < m; i++)  // i=i+1
            {
                ö = ö * (1 + k / 100);         //    ö=ö+ö*k/100;
            }
            kereset.Text = "PROFIT: " +(ö - ö1).ToString()+" ft";
        }
    }
}
