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
            DateTime karacsony = new DateTime(DateTime.Now.Year, 12, 24);

            //aktuális dátum
            DateTime aktualisido = DateTime.Now;
            TimeSpan kulombseg = karacsony - aktualisido;

            //napok kiiratása
            kiirLbl.Text = "Már csak "+ kulombseg.Days.ToString() + " nap van karácsonyig.";

        }
    }
}
