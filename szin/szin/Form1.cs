using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace szin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            pictureBox1.BackColor = Color.FromArgb(vScrollBar1.Value, vScrollBar2.Value, vScrollBar3.Value);
            label2.Text = vScrollBar1.Value.ToString();
            label3.Text = vScrollBar2.Value.ToString();
            label4.Text = vScrollBar3.Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    label1.BackColor= Color.FromArgb(vScrollBar1.Value, vScrollBar2.Value, vScrollBar3.Value);
                    break;
                case 1:
                    textBox1.BackColor= Color.FromArgb(vScrollBar1.Value, vScrollBar2.Value, vScrollBar3.Value);
                    break;
                case 2:
                    button1.BackColor= Color.FromArgb(vScrollBar1.Value, vScrollBar2.Value, vScrollBar3.Value);
                    break;
                case 3:
                    listBox1.BackColor = Color.FromArgb(vScrollBar1.Value, vScrollBar2.Value, vScrollBar3.Value);
                    break;
                default:
                    this.BackColor = Color.FromArgb(vScrollBar1.Value, vScrollBar2.Value, vScrollBar3.Value);
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.BackColor= Color.FromArgb(vScrollBar1.Value, vScrollBar2.Value, vScrollBar3.Value);
        }
    }
}
