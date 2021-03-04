using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace openfiledialog
{
    public partial class fmOpenSave : Form
    {
        public fmOpenSave()
        {
            InitializeComponent();

        }

        

        

        

        private void button1_Click_1(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                foreach (var nev in openFileDialog1.FileNames)
                {
                    listBox1.Items.Add(nev);
                }
                pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
            }
            else
                MessageBox.Show("Mégse gomb!!");
            
            
            

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Mentem \n" + saveFileDialog1.FileName);
            
            }



        }

        private void fmOpenSave_Load(object sender, EventArgs e)
        {
            
        }
    }
}
