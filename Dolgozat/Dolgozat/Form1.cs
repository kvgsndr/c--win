using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dolgozat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kilepBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ertekelBtn_Click(object sender, EventArgs e)
        {
            int szazalek = int.Parse(szazalekTxt.Text);

            if(szazalek >= 0 && szazalek <= 100){
                if (szazalek < 51) { jegyLbl.Text = "elégtelen(1)"; 
                                    pictureBox1.Image = new Bitmap(@"H:\CSharp\Dolgozat\Dolgozat\egy.png"); }
                else{
                    if (szazalek < 61) { jegyLbl.Text = "elégséges(2)"; 
                                        pictureBox1.Image = new Bitmap(@"H:\CSharp\Dolgozat\Dolgozat\ketto.png"); } 
                    else {
                        if (szazalek < 81) { jegyLbl.Text = "közepes(3)"; 
                                            pictureBox1.Image = new Bitmap(@"H:\CSharp\Dolgozat\Dolgozat\harom.png"); } 
                        else {
                            if (szazalek < 91) { jegyLbl.Text = "jó(4)"; 
                                                pictureBox1.Image = new Bitmap(@"H:\CSharp\Dolgozat\Dolgozat\negy.png"); }
                            else { jegyLbl.Text = "jeles(5)"; 
                                   pictureBox1.Image = new Bitmap(@"H:\CSharp\Dolgozat\Dolgozat\ot.png"); }
                        }
                    }
                }
                jegyLbl.Visible = true;

            }else{
                MessageBox.Show("Hibás adatot adtál meg!!");

            }


        }

   }
}
