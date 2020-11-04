using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ok_Btn_MouseEnter(object sender, EventArgs e)
        {
            hello_Lbl.Visible = true;
        }

        private void ok_Btn_MouseLeave(object sender, EventArgs e)
        {
            hello_Lbl.Visible = false;
        }
    }
}
