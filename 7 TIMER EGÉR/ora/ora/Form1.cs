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
            kijelzoLbl.Text = DateTime.Now.ToString("HH : mm : ss");
            //kijelzoLbl.Text = DateTime.Now.ToLongTimeString();

        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            startBtn.Enabled = false;
            stopBtn.Enabled = true;
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            startBtn.Enabled = true;
            stopBtn.Enabled = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
           // lbDatum.Text = DateTime.Now.ToString("yyyy.MMMM.dd dddd");
            lbDatum.Text = DateTime.Now.ToLongDateString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbDatum.Text = DateTime.Now.ToString("yyyy.MMMM.dd dddd");
        }
    }
}
