using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rádió_gomb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MegseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            if (kekBtn.Checked)
             {
                BackColor = Color.Blue;
             }
            else if (zoldBtn.Checked)
             {
                    BackColor = Color.Green;
             }
            else
             {
                BackColor = Color.Brown;
             }



        }
    }
}
