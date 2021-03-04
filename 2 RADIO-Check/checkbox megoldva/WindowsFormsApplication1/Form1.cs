using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void megseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {   double ar, afa, afasar;
            ar = double.Parse(arTbx.Text);
            afa = double.Parse(afaTbx.Text) / 100;

            if (torzsChbx.Checked)
                 afasar = (ar * afa + ar) * 0.9;
            else
                 afasar = (ar*afa+ar);
            
            afasarLbl.Text = afasar.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
