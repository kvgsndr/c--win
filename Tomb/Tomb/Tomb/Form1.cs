using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tomb
{
    public partial class Form1 : Form
    {
        //ide a szerdai adat kiíró eljárás létrehozásakor kerül ez az utasítás
        //ez itt globális változó lesz!!!
        //ekkor a feltolt eljárásból törölni kell a tömb létrehozását. ha ott nem törlöd, akkor két azonos nevű tömböd lesz
        // a feltolt eljárás a sajátját fogja használni, minden más eljárás a globálist (azaz, ami itt van)
        //mivel ebben a feladatban azonos a két tömb és nem is módosítunk bele egyikbe sem, itt nem okozna problémát
        //de általában azért figyeljük, hogy ott hozzuk létre, ahol szükséges
        
        double[] kozepHomerseklet = new double[] { 0.7, 3.1, 5.5, 2.6, 1.4, 2.2, 1.2 };
        public Form1()
        {
            InitializeComponent();

        }

        private void feltoltBtn_Click(object sender, EventArgs e)
        {
            //szövegmező feltöltése megadott adatokkal tömbből
            //double[] kozepHomerseklet = new double[] { 0.7, 3.1, 5.5, 2.6, 1.4, 2.2, 1.2};
            //ez itt lokális változó volt!!!!

            //tömb méretének (elemek számának) kiírása
            MessageBox.Show("Az elemek száma: " + kozepHomerseklet.Length);

            /*
            foreach (double i in kozepHomerseklet) {
                //richTextBox1.AppendText(i.ToString());
                //csúnya, hogy az adatokat egymás mellé "ragasztja
                //minden adat után illesszünk be egy soremelést
                richTextBox1.AppendText(i.ToString()+ "\r\n");
            }
            */

            //ha többször kattintunk a feltölt gombra, egymás után fűzi több példányban 
            //ezért vegyük le a gombot az űrlapról
            feltoltBtn.Visible = false;

            //sajnos az adatfeltöltés során a 7 elemű tömbbhöz egy 8 soros szöveget hoztun létre 
            //(Figyeld a szövegdoboz utolsó, üres sorát!) Miért ?
            //Javítsuk! A soremelesére szükség van, de csak akkor, ha nem az utolsó sorban vagyunk
            // ezért nem csak a tömbelemekre van szükség, hanem az indexeikre is
            for (int i=0; i<kozepHomerseklet.Length;i++) {
                //az i itt blokkváltozó!!!!
                richTextBox1.AppendText(kozepHomerseklet[i].ToString());
                if (i < (kozepHomerseklet.Length-1)) {
                    richTextBox1.AppendText("\r\n");
                }
            }

        }

        private void kilepBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void szerdaBtn_Click(object sender, EventArgs e)
        {
            // Írjuk ki a képenyőre a tömbből a szerdai középhőmérsékletet
            // sajnos a parancs megadásakor azt tapasztaljuk, hogy a kozepHomerseklet tömböt nem ismeri ez az aljárás
            //Miért? Hatókör. Tegyük tehát a tömb létrehozó részt olyan helyre, ahol lérehozva bármely eljárásunk
            //"hozzáférhet"
            MessageBox.Show("A szerdai középhőmérséklet "+kozepHomerseklet[2]+ "°C");
        }

        private void barmelyNapBtn_Click(object sender, EventArgs e)
        {
            int i=0;
            string nap="";
            //ezek (i és nap itt most lokális változó
            if (radioButton1.Checked) { i = 0; nap = "hétfő"; }
            else { if (radioButton2.Checked) { i = 1; nap = "kedd"; }
                else {
                    if (radioButton3.Checked) { i = 2; nap = "szerda"; }
                    else {
                        if (radioButton4.Checked) { i = 3; nap = "csütörtök"; }
                        else {
                            if (radioButton5.Checked) { i = 4; nap = "péntek"; }
                            else {
                                if (radioButton6.Checked) { i = 5; nap = "szombat"; }
                                else { i = 6; nap = "vasárnap"; }
                            }
                        }
                    }
                }
            }

            MessageBox.Show("A "+nap+"i középhőmérséklet " + kozepHomerseklet[i] + "°C");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //Figyeld! A jelölőnégyzet értékének változása megfordítja a kép Visible tulajdonságát.
            //hogy jól működjön a Properties ablakban kezdőértéknek 
            //a kép visible és a jelölőnégyzet cheked tulajdonsága is azonosan false-o álljon!!!
            pictureBox1.Visible = !pictureBox1.Visible;
        }
    }
}
