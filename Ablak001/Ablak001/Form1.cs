using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ablak001
{
    public partial class ablakForm : Form
    {
        public ablakForm()
        {
            InitializeComponent();

            aquaBtn.Visible = false;
            redBtn.Visible = false;
        }

        private void kilepBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Viszlát!!!!");
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BackColor = Color.Aqua;
        }

        private void redBtn_Click(object sender, EventArgs e)
        {
            BackColor = Color.Red;
        }

        private void szinezBtn_Click(object sender, EventArgs e)
        {
            szinezBtn.Visible = false;
            aquaBtn.Visible = true;
            redBtn.Visible = true;
        }
    }
}
