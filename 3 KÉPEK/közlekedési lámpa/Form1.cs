using közlekedési_lámpa.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace közlekedési_lámpa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int kép = 1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (kép)
            {
                case 1: pictureBox1.Image = Resources.piros;break;
                case 2: pictureBox1.Image = Resources.pirossarga; break;
                case 3: pictureBox1.Image = Resources.zold; break;
                case 4: pictureBox1.Image = Resources.sarga; break;
            }
            kép++;
            if (kép == 5) kép = 1;
        }
    }
}
