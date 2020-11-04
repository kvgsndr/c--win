using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace szolanc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ellenorzesBtn_Click(object sender, EventArgs e)
        {
            string szoveg = szovegTxb.Text;
            string kiszoveg = szoveg.ToLower();
            if (szoveg.StartsWith("a"))
            {
                eredmenyLbl.Text = "A megadott szöveg a betűvel kezdődik.";
            } else
            {
                eredmenyLbl.Text = "A megadott szöveg NEM a betűvel kezdődik.";
            }
        }

        private void ellenorzes2Btn_Click(object sender, EventArgs e)
        {
            string szoveg = szovegTxb.Text;
            string kiszoveg = szoveg.ToLower();
            if (szoveg.EndsWith("a"))
            {
                eredmeny2Lbl.Text = "A megadott szöveg a betűre végződik.";
            }
            else
            {
                eredmeny2Lbl.Text = "A megadott szöveg NEM a betűre végződik.";
            }
        }

        private void szolanceBtn_Click(object sender, EventArgs e)
        {
            string szo1 = szo1Txb.Text;
            string szo2 = szo2Txb.Text;

            string ut = szo1.Substring(szo1.Length-1, 1);
            string el = szo2.Substring(0, 1);

            if (ut==el)
                {
                szolancLbl.Text = "Szóláncot alkotnak.";
            }else
            {
                szolancLbl.Text = "Nem szólánc.";
            }
        }
    }
}
