using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csuszka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SBnegyzeth_ValueChanged(object sender, EventArgs e)
        {
            lbl.Text = "" + SBnegyzeth.Value;
            lblnegyzet.Width = SBnegyzeth.Value;
            lblnegyzet.Height = SBnegyzeth.Value;
        }

        private void hScrollBar2_Scroll_1(object sender, ScrollEventArgs e)
        {
            lblnegyzet.BackColor = Color.FromArgb(sbpiros.Value, sbzold.Value, sbkek.Value);
        }

        private void sbzold_Scroll(object sender, ScrollEventArgs e)
        {
            lblnegyzet.BackColor = Color.FromArgb(sbpiros.Value, sbzold.Value, sbkek.Value);
        }

        private void sbkek_Scroll(object sender, ScrollEventArgs e)
        {
            lblnegyzet.BackColor = Color.FromArgb(sbpiros.Value, sbzold.Value, sbkek.Value);
        }

    }
}
