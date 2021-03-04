using kőpapirolló.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kőpapirolló
{
    public partial class Form1 : Form
    {   enum kepek { ko, papir, ollo};
        
        public Form1()
        {
             InitializeComponent();
        }
        int jatekos = 0, szamitogep = 0;
        Random rnd = new Random();
        private void button1_Click(object sender, EventArgs e)
        { switch (listBox1.SelectedIndex)
            {
                case 0 : pictureBox1.Image = Resources.ko; break;
                case 1: pictureBox1.Image = Resources.papir; break;
                case 2: pictureBox1.Image = Resources.ollo; break;

            }
            int c = rnd.Next(3);
            switch (c)
            {
                case 0: pictureBox2.Image = Resources.ko; break;
                case 1: pictureBox2.Image = Resources.papir; break;
                case 2: pictureBox2.Image = Resources.ollo; break;

            }
            if (listBox1.SelectedIndex == 0 && c == 1) szamitogep++;
            if (listBox1.SelectedIndex == 0 && c == 2) jatekos++;
            if (listBox1.SelectedIndex == 1 && c == 0) jatekos++;
            if (listBox1.SelectedIndex == 1 && c == 2) szamitogep++;
            if (listBox1.SelectedIndex == 2 && c == 0) szamitogep++;
            if (listBox1.SelectedIndex == 2 && c == 1) jatekos++;
            label1.Text = jatekos.ToString() + " : " + szamitogep.ToString();
        }
    }
}
