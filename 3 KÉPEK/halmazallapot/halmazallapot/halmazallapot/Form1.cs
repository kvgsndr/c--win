using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace halmazallapot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void okBtn_Click(object sender, EventArgs e)
        {
            double fok = double.Parse(textBox1.Text);
            if (fok>100)
            {
                kepPbx.Image = new Bitmap("goz.jpg");
                halmazLbl.Text = "A víz gáz halmazállapotú.";
                
            } else
            {
               if (fok<0)
            {
                kepPbx.Image = new Bitmap("szilard.jpg");
                halmazLbl.Text = "A víz szilárd halmazállapotú.";
                } else
            {
                kepPbx.Image = new Bitmap("folyekony.jpg");
                halmazLbl.Text = "A víz folyékony halmazállapotú.";
                }
            }
            
        }
    }
}
