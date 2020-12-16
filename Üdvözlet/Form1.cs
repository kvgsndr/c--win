using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Üdvözlet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUdvozles_Click(object sender, EventArgs e)
        {
            if (txtVeznev.Text.Length == 0 || txtKernev.TextLength == 0 || txtTelefon.Text.Length == 0)
                MessageBox.Show("Nem adta meg az összes adatát!!!");
            else
            {    
                txtUdvozlet.Text = "Üdvözöllek " + txtVeznev.Text + " " + txtKernev.Text + "!" +
                    Environment.NewLine + "Telefon:" + txtTelefon.Text +
                    "\r\nTelefon2:" + maskedTextBox1.Text;

                txtVeznev.Clear();
                txtKernev.Clear();
                txtTelefon.Text = "";
                maskedTextBox1.Clear();
                txtVeznev.Focus();
            }

        }

        private void btnBezar_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
