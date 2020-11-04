using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ugras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ugrikBtn_Click(object sender, EventArgs e)
        {
            ushort x = ushort.Parse(xTxt.Text);
            ushort y = ushort.Parse(yTxt.Text);

            ugrikBtn.Location = new Point(x,y);
            

        }
    }
}
