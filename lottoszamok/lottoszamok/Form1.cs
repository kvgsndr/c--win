using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lottószámok
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ok_Click(object sender, EventArgs e)
        {
            if(otosrbtn.Checked)
            {
                Random veleltlen = new Random();
                int otos1 = veleltlen.Next(1, 91);
                
                int otos2 = veleltlen.Next(1, 91);
                if (otos1 == otos2)
                { otos2 = veleltlen.Next(1, 91); }

                int otos3 = veleltlen.Next(1, 91);
                if (otos1 == otos3)
                { otos3 = veleltlen.Next(1, 91); }
                else if(otos2 == otos3)
                { otos3 = veleltlen.Next(1, 91); }

                int otos4 = veleltlen.Next(1, 91);
                if (otos1 == otos4)
                { otos4 = veleltlen.Next(1, 91); }
                else if (otos2 == otos4)
                { otos4 = veleltlen.Next(1, 91); }
                else if (otos3 == otos4)
                { otos4 = veleltlen.Next(1, 91); }

                int otos5 = veleltlen.Next(1, 91);
                if (otos1 == otos5)
                { otos5 = veleltlen.Next(1, 91); }
                else if (otos2 == otos5)
                { otos5 = veleltlen.Next(1, 91); }
                else if (otos3 == otos5)
                { otos5 = veleltlen.Next(1, 91); }
                else if (otos4 == otos5)
                { otos5 = veleltlen.Next(1, 91); }

                label1.Text = otos1 + "," + otos2 + "," + otos3 + "," + otos4 + "," + otos5;



            }
            else if (hatosrbtn.Checked)
            {
                Random veleltlen = new Random();
                int hatos1 = veleltlen.Next(1, 46);
                int hatos2 = veleltlen.Next(1, 46);
                int hatos3 = veleltlen.Next(1, 46);
                int hatos4 = veleltlen.Next(1, 46);
                int hatos5 = veleltlen.Next(1, 46);
                int hatos6 = veleltlen.Next(1, 46);
                label2.Text = hatos1 + "," + hatos2 + "," + hatos3 + "," + hatos4 + "," + hatos5 + "," + hatos6;
            }
            else
            {
                Random veleltlen = new Random();
                int skand1 = veleltlen.Next(1, 36);
                int skand2 = veleltlen.Next(1, 36);
                int skand3 = veleltlen.Next(1, 36);
                int skand4 = veleltlen.Next(1, 36);
                int skand5 = veleltlen.Next(1, 36);
                int skand6 = veleltlen.Next(1, 36);
                int skand7 = veleltlen.Next(1, 36);
                int skand8 = veleltlen.Next(1, 36);
                int skand9 = veleltlen.Next(1, 36);
                int skand10 = veleltlen.Next(1, 36);
                int skand11 = veleltlen.Next(1, 36);
                int skand12 = veleltlen.Next(1, 36);
                int skand13 = veleltlen.Next(1, 36);
                int skand14 = veleltlen.Next(1, 36);
                label3.Text = skand1 + "," + skand2 + "," + skand3 + "," + skand4 + "," + skand5 + "," + skand6 + "," + skand7;
                label4.Text = skand8 + "," +skand9 + ","+skand10 + "," +skand11 + ","+skand12 + "," +skand13 + ","+skand14;
            }
        }

        private void kilepes_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
