using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void gombBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nyertél!");
        }

        private void gombBtn_MouseEnter(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int x = rnd.Next(15,500);
            int y = rnd.Next(15,300);
            gombBtn.Location = new Point(x, y);
        }
    }
}
