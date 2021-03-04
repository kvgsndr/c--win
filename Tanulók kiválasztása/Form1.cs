using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Tanulók_kiválasztása
{
    public partial class Form1 : Form
    {
        struct Tanulo
        {
            public int prezentalt;
            public int halasztott;
            public string nev;

        }
        List<Tanulo> lista = new List<Tanulo>();
        int sorszam = 0;
        string[] file_list;
        int maxprez = 1;

        private int maxPrezent()
        { int max = lista[0].prezentalt;
            foreach (var item in lista)
                if (max < item.prezentalt) max = item.prezentalt;

            return max;
        }

        private void listaMent()
        {
            try
            {
                StreamWriter fki = new StreamWriter(file_list[comboBox1.SelectedIndex]);
                fki.WriteLine("prezentált;Név;halasztott");
                for (int i = 0; i < lista.Count; i++)
                {
                    fki.WriteLine($"{lista[i].prezentalt};{lista[i].nev};{lista[i].halasztott}");
                }
                fki.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show($"Lista ment:{e.Message}");

            }

        }

        string tanuloToString(Tanulo egyed)
        {   var hala= egyed.halasztott > 0 ? "Halasztott x "+egyed.halasztott.ToString() : "";
            return String.Format($"{egyed.prezentalt} - {egyed.nev} {hala}");
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            file_list = Directory.GetFiles(@"..\..\Data");
            for (int i = 0; i < file_list.Length; i++)
            {
                var utvonal_elemei = file_list[i].Split('\\');
                string elem = utvonal_elemei[utvonal_elemei.Length - 1];
                comboBox1.Items.Add(elem);
            }
            
        }

        private void btValaszt_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            do
            {
                sorszam = rnd.Next(lista.Count);
            } 
            while (lista[sorszam].prezentalt > maxprez-1 );

            string hala = lista[sorszam].halasztott >0 ? "Halasztott" : "";
            label2.Text = lista[sorszam].nev + " " + hala;
            listBox1.SelectedIndex = sorszam;
            listaMent();

        }

        private void btHalaszt_Click(object sender, EventArgs e)
        {
            Tanulo egyed = lista[sorszam];
            egyed.halasztott+=1;
            lista[sorszam] = egyed;
            listBox1.Items[sorszam] = tanuloToString(egyed);
            listaMent();
        }

        private void btPrezental_Click(object sender, EventArgs e)
        {
            Tanulo egyed = lista[sorszam];
            egyed.prezentalt += 1;
            egyed.halasztott = 0;
            lista[sorszam] = egyed;
            listBox1.Items[sorszam] = tanuloToString(egyed);
            listaMent();
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label2.Text = "";
            try
            {
                StreamReader fbe = new StreamReader(file_list[comboBox1.SelectedIndex]);

                lista.Clear();
                listBox1.Items.Clear();
                fbe.ReadLine();
                while (!fbe.EndOfStream)
                {

                    Tanulo egyed;
                    string sor = fbe.ReadLine();
                    var elemek = sor.Split(';');
                    
                    egyed.nev = elemek[1];
                    egyed.halasztott = int.Parse(elemek[2]);
                    egyed.prezentalt = int.Parse(elemek[0]);
                    lista.Add(egyed);
                    string s = elemek[0] + "--" + elemek[1];
                    if (elemek[2] == "1") s = s + "  Halasztott";
                    listBox1.Items.Add(s);
                }
                fbe.Close();
                listaMent();
                maxprez=maxPrezent();
            }
            catch (Exception ee)
            {
                MessageBox.Show($" Combo change: {ee.Message}");
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            sorszam = listBox1.SelectedIndex;
        }
    }
}
