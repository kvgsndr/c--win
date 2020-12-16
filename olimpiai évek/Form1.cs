using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace olimpiai_évek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int  ev= 1896; ev <= 2020; ev=ev+4)
            {
                if ((ev % 4 == 0 && ev % 100 != 0) || ev % 400 == 0)
                    listBox1.Items.Add(ev.ToString() + " Szökőév");
                else
                    listBox1.Items.Add(ev.ToString());



            }
        }
    }
}
