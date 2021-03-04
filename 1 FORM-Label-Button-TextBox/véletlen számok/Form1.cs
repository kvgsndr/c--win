using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace véletlen_számok
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            textBox2.Text = "";
            int N = int.Parse(textBox1.Text);  //int N=Convert.ToInt32(textBox1.Text);
            for (int i = 0; i < N; i++)
            {
                int véletlenSzám = rnd.Next(50,100);
                textBox2.Text += String.Format("{0,15}", véletlenSzám.ToString());
            }
            
           

        }
    }
}
