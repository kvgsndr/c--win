using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace datumido
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //karácsony dátuma
            DateTime d1 = new DateTime(2018, 12, 24);

            //aktuális dátum
            DateTime aktualisido = DateTime.Now;
            TimeSpan elteltido = d1 - aktualisido;

            //napok kiiratása
            kiirLbl.Text = "Már csak "+ elteltido.Days.ToString() + " nap van karácsonyig.";

        }
    }
}
