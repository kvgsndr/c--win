using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rachgrpane
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
                Text = "Hétfő";
            if (radioButton2.Checked == true)
                Text = "Kedd";
            if (radioButton3.Checked == true)
                Text = "Szerda";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            string s = "";
            if (checkBox1.CheckState == CheckState.Checked)
                s = "Első";
            if (checkBox2.CheckState == CheckState.Checked)
                s = s+" Második";
            if (checkBox3.CheckState == CheckState.Checked)
                s += " Harmadik";
            Text = s;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
