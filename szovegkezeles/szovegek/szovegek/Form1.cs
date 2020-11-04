using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace szovegek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void csinaldBtn_Click(object sender, EventArgs e)
        {
            String szoveg = szovegTxt.Text;

            //nagybetűssé alakít
            String nagyb = szoveg.ToUpper();
            nagybetusTxt.Text = nagyb;

            //kisbetűssé alakít
            String kisb = szoveg.ToLower();
            kisbetusTxt.Text = kisb;

            //szöveghossz
            int hossz = szoveg.Length;
            hosszTxt.Text = hossz.ToString();

            //kezdőbetű
            String v = szoveg.Substring(0, 1);
            betuTxt.Text = v;

            //szóköz nélkül
            String szn = szoveg.Trim();
            szokoznTxt.Text = szn;

          

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
