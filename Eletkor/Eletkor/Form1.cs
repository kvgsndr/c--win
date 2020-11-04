using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eletkor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void eletkorTxt_KeyUp(object sender, KeyEventArgs e)
        {
            int karakter = e.KeyValue;
            if (karakter<48 || karakter>57)
            {
                eletkorTxt.Clear();
                MessageBox.Show("Csak számot!", "Figyelmeztetés");
            }
        }

        private void belepBtn_Click(object sender, EventArgs e)
        {
            int eletkor = int.Parse(eletkorTxt.Text);
            if (eletkor < 18)
            {
                MessageBox.Show("Ön még kiskorú, nem jogosult a belépésre!","Figyelmeztetés",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
            else
            {
                MessageBox.Show("Belépés engedélyezve!", "Belépés");
            }
        }
    }
}
