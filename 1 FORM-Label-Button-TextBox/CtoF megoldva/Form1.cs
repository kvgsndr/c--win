using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CtoF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fToc_Click(object sender, EventArgs e)
        {
            double f = Convert.ToDouble(textBox2.Text);
            double c = (f - 32) / 1.8;
            textBox1.Text = c.ToString();
        }

        private void cTof_Click(object sender, EventArgs e)
        {
            double c = Convert.ToDouble(textBox1.Text);
            double f = 1.8 * c + 32;
            textBox2.Text = f.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
