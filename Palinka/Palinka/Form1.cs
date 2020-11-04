using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Palinka
{
    public partial class nyersLbl : Form
    {
        public nyersLbl()
        {
            InitializeComponent();
        }

        private void kilepBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void szamolBtn_Click(object sender, EventArgs e)
        {   //a felhasználó által megadott adatokat(szöveg) számmá alakítva egy-egy változóba teszi
            double nyersLiter = double.Parse(nyersTxt.Text);
            int alkoholSzazalek = int.Parse(alkoholTxt.Text);
            int keszAlkoholSzazalek = int.Parse(keszTxt.Text);

            //kiszámolja az össz alkoholmennyiséget  szükséges vizet és összpálinka mennyiségét
            double osszAlkohol = nyersLiter * alkoholSzazalek / 100;
            double osszPalinka = osszAlkohol / keszAlkoholSzazalek * 100;
            double vizBele = osszPalinka - nyersLiter;

            //a kiírásra használt textBoxokba szövegformátumba beleteszi a számított adatokat
            vizTxt.Text = vizBele.ToString("N1");
            osszTxt.Text = osszPalinka.ToString("N1");


        }
    }
}
