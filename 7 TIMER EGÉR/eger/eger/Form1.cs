using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            
            //Text = String.Format("Az egér koordinátái X:{0}, Y:{1}", Cursor.Position.X, Cursor.Position.Y);
        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {
            Text = "Belépett";
        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            Text = "Kilépett";
        }

        private void elsoBtn_Click(object sender, EventArgs e)
        {
            masodikBtn.Visible = !masodikBtn.Visible;


        }

        private void harmadikBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void masodikBtn_Click(object sender, EventArgs e)
        {
            elsoBtn.Enabled = !elsoBtn.Enabled;
        }

        private void kilepBtn_MouseEnter(object sender, EventArgs e)
        {
            kilepBtn.Visible = false;
        }

        private void kilepBtn_MouseLeave(object sender, EventArgs e)
        {
            kilepBtn.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sikerült!","Üdvözlet", MessageBoxButtons.OK,MessageBoxIcon.Information);

        }

        private void Form1_MouseMove_1(object sender, MouseEventArgs e)
        {
            label1.Text = MousePosition.ToString();
        }

        private void kilepBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
