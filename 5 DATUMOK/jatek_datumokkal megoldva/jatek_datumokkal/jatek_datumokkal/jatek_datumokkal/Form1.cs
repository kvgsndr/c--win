using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jatek_datumokkal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private DateTime ma;

        private void Form1_Load(object sender, EventArgs e)
        {
            ma = DateTime.Now;
            aktualisLbl.Text = ma.ToString();


        }

        private void ertekelBtn_Click(object sender, EventArgs e)
        {
            DateTime datum, ido, talalkozo;
            datum = dtTmPckrDatum.Value;
            ido = dtTmPckrIdo.Value;
            talalkozo = datum.Date + ido.TimeOfDay;

            talalkozoLbl.Text = datum.ToShortDateString() + " " + ido.ToShortTimeString();
            if (talalkozo < ma)
            {
                ertekelesLbl.Text = "Ezt lekésted!";

            }
            else
            {
                TimeSpan hatraLevo = talalkozo - ma;
                ertekelesLbl.Text = "Még " + hatraLevo.Days + " nap " + hatraLevo.Hours + " óra " + hatraLevo.Minutes + " perc.";
            }

        }

        private void bezarBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
