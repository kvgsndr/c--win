using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace szinkeverő
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            lbSzin.BackColor = Color.FromArgb(scbRed.Value, scbGreen.Value, scbBlue.Value);
            lbVörös.Text = scbRed.Value.ToString();
            lbZöld.Text = scbGreen.Value.ToString();
            lbKék.Text = scbBlue.Value.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbVörös.Text = "0";
            lbZöld.Text = "0";
            lbKék.Text = "0";
            scbSzéles.Maximum = Width - 120 ;
        }

        private void scbSzéles_Scroll(object sender, ScrollEventArgs e)
        {
            lbSzin.Width = scbSzéles.Value;
            label8.Text = scbSzéles.Value.ToString();
            label8.Location = new Point( lbSzin.Location.X + lbSzin.Width+5, label8.Location.Y);
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            lbSzin.Height = scbMagas.Value;
            label9.Text = scbMagas.Value.ToString();
            label9.Location = new Point( lbSzin.Location.X+lbSzin.Width/2, lbSzin.Location.Y + lbSzin.Height + 5);
        }
    }
}
