using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Véralkohol
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

        private void ellenorBtn_Click(object sender, EventArgs e)
        {
            double alkohol = double.Parse(textBox1.Text);

            if (alkohol >= 0 && alkohol <= 4)
            {
                progressBar1.Value = (int)(25 * alkohol);
                /*
                if (alkohol == 0){kiirLbl.Text = "Józan vagy!!!";}
                if (alkohol > 0 && alkohol < 0.5) { kiirLbl.Text = "Még ittas sem vagy!!!"; }
                if (alkohol >= 0.5 && alkohol < 1.5) { kiirLbl.Text = "Ittas vagy..."; }
                if (alkohol >= 1.5 && alkohol < 2.5) { kiirLbl.Text = "Részeg vagy..."; }
                if (alkohol >= 2.5 && alkohol < 4) { kiirLbl.Text = "Alkohol mérgezésed van..."; }
                if (alkohol == 4){ kiirLbl.Text = "Alkoholmérgezésben már meg is haltál..."; }
                 */
                
                if (alkohol == 0) { kiirLbl.Text = "Józan vagy!!!"; }
                else
                {
                    if (alkohol < 0.5) { kiirLbl.Text = "Még ittas sem vagy!!!"; }
                    else
                    {
                        if (alkohol < 1.5) { kiirLbl.Text = "Ittas vagy..."; }
                        else
                        {
                            if (alkohol < 2.5) { kiirLbl.Text = "Részeg vagy..."; }
                            else
                            {
                                if (alkohol < 4) { kiirLbl.Text = "Alkohol mérgezésed van..."; }
                                else { kiirLbl.Text = "Alkoholmérgezésben már meg is haltál..."; }
                            }
                        }
                    }
                }
     
                progressBar1.Visible = true;
                kiirLbl.Visible = true;
            }
            else
            {
                MessageBox.Show("Rossz értéket adtál meg!!!");
            }
            
       }
    }
}
