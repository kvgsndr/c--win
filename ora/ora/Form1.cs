using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            kijelzoLbl.Text = DateTime.Now.ToString("HH:mm:ss:fff");

        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            startBtn.Enabled = false;
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            startBtn.Enabled = true;
        }
    }
}
