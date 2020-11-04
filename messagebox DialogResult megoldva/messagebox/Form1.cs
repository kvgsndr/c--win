using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace messagebox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult eredmeny;
            eredmeny=MessageBox.Show("Üzenet","Címsor szöveg",MessageBoxButtons.YesNo, MessageBoxIcon.Stop,MessageBoxDefaultButton.Button3);
            if (eredmeny == DialogResult.Yes)
                button1.Text = "yes";
            else
                button1.Text = "No";

        }
    }
}
