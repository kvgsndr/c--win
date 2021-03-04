using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stopper
{
    public partial class Form1 : Form
    { DateTime dt1;
        DateTime dt2;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {   dt2 = DateTime.Now;
            TimeSpan dt = dt2 - dt1;
            label1.Text = dt.Hours.ToString().PadLeft(2,'0') + ":" 
                + dt.Minutes.ToString().PadLeft(2,'0') + ":" 
                + dt.Seconds.ToString().PadLeft(2,'0')+"."
                +(dt.Milliseconds/100).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Tag.ToString() =="1")
            {
                dt1 = DateTime.Now;
                timer1.Enabled = true;
                button1.Text = "Stop";
                button1.Tag = "2";

            }
            else
            {
                timer1.Enabled = false;
                button1.Text = "Start";
                button1.Tag = "1";

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(label1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
