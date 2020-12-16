using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace groupbox
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
            else if (radioButton2.Checked == true)
                Text = "Kedd";
            else if (radioButton3.Checked == true)
                Text = "Szerda";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        { string s="";
            if (checkBox1.CheckState == CheckState.Checked)
                 s= "Első";
            if (checkBox2.Checked == true)
                s = s + " Második";
            if (checkBox3.Checked == true)
                s = s+" Harmadik";
            Text = s;
        }
    }
}
