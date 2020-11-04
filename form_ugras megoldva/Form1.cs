using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_ugras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Left = 0;
            Top = 0;
            Text = "Left=" + Left.ToString() + " Top=" + Top.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Top = 0;
            Left = Screen.PrimaryScreen.Bounds.Width - Width;
            Text = "Left=" + Left.ToString() + " Top=" + Top.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Left = 0;
            Top = Screen.PrimaryScreen.Bounds.Height - Height;
            Text = "Left=" + Left.ToString() + " Top=" + Top.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Left = Screen.PrimaryScreen.Bounds.Width - Width;
            Top = Screen.PrimaryScreen.Bounds.Height - Height;
            Text = "Left=" + Left.ToString() + " Top=" + Top.ToString();

        }
    }
}
