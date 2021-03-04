using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace szokoev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ev = int.Parse(evTxt.Text);
            if (ev % 400 == 0)
            {
                kiirLbl.ForeColor = Color.Red;
                kiirLbl.Text = "A " + evTxt.Text + " szökőév.";
            }
            else
            {
                if (ev % 4 == 0)
                {

                    kiirLbl.ForeColor = Color.Red; 
                    kiirLbl.Text = "A " + evTxt.Text + " szökőév.";
                }
                else
                {
                    kiirLbl.ForeColor = Color.Black; 
                    kiirLbl.Text = "A " + evTxt.Text + " nem szökőév.";
                }
             }
            kiirLbl.Visible = true;
        }
    }
}
