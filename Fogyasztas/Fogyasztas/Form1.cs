using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fogyasztas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void szamolBtn_Click(object sender, EventArgs e)
        {
            double l = double.Parse(lTxt.Text);
            double km = double.Parse(kmTxt.Text);

            double fogyasztas = l / km * 100;
            fogyasztasLbl.Text = "Fogyasztás: " + fogyasztas.ToString("N1") +" l/100 km";
            fogyasztasLbl.Visible = true;

        }
    }
}
