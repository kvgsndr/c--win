using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void bf_Btn_Click(object sender, EventArgs e)
        {
            Left = 0;
            Top = 0;
        }

        private void jfBtn_Click(object sender, EventArgs e)
        {
            Top = 0;
            Left = Screen.PrimaryScreen.Bounds.Width - Width;
        }

        private void bl_Btn_Click(object sender, EventArgs e)
        {
            Left = 0;
            Top = Screen.PrimaryScreen.Bounds.Height - Height;
        }

        private void jl_Btn_Click(object sender, EventArgs e)
        {
            Left = Screen.PrimaryScreen.Bounds.Width - Width;
            Top = Screen.PrimaryScreen.Bounds.Height - Height;
        }
    }
}
