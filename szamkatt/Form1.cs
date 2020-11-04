using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace szamkatt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Label lb = new Label();
            Random rnd = new Random();
            lb.Text = rnd.Next(100).ToString();
            lb.Location = new Point(e.X, e.Y);
            lb.AutoSize = true;
            lb.Visible = true;
            Controls.Add(lb);
        }
    }
}
