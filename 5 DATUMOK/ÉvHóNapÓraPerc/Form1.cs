using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ÉvHóNapÓraPerc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btOK_Click(object sender, EventArgs e)
        { DateTime dt = DateTime.Now;
            label1.Text = "Most: " + dt.ToString();
            if (chbEv.Checked) listBox1.Items.Add(dt.Year); 
                               //listBox1.Items.Add(dt.ToString().SubString(0,4))
            if (chbHo.Checked) listBox1.Items.Add(dt.Month);
            if (chbNap.Checked) listBox1.Items.Add(dt.Day);
            if (chbOra.Checked) listBox1.Items.Add(dt.Hour);
            if (chbPerc.Checked) listBox1.Items.Add(dt.Minute);
            if (chbMperc.Checked) listBox1.Items.Add(dt.Second);
        }


        private void btTorol_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
