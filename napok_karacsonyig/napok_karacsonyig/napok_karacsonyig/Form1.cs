using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace napok_karacsonyig
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime karacsony = new DateTime(2020, 12, 24);
            DateTime aktualis = DateTime.Now;
            TimeSpan elteltido = karacsony - aktualis;
            label1.Text = elteltido.ToString("dd");
        }
    }
}
