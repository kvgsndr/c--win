using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using Microsoft.Win32;

namespace ADFGVXgui
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {   bool kodTablaRossz=false;
        List<string> kod = new List<string>();
        public MainWindow()
        {
            InitializeComponent();
        }


        private void btMegnyit_Click(object sender, RoutedEventArgs e)
        {
            kod.Clear();
            lbxHibak.Items.Clear();
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == true)
            {
                try
                {
                    StreamReader fbe = new StreamReader(ofd.FileName);
                    while (!fbe.EndOfStream)
                        kod.Add(fbe.ReadLine());

                    fbe.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Nem lehet megnyitni az állományt!");
                }
            }
            else
                return;


            //a kódtábla kiírása
            lbKodtabla.Content = "A betöltött kódtábla:\n\n";
            foreach (var sor in kod)
            {
                foreach (var karakter in sor)
                    lbKodtabla.Content += String.Format($"{karakter}\t");
                lbKodtabla.Content += "\n";
            }
            // méret ellenörzése
           

            if (kod.Count != 6 || !kodSorHossza())
            {
                lbxHibak.Items.Add("Hiba a mátrix méretében!");
                kodTablaRossz = true;
            }
            //angol abc és számok
            string angolABCszamok = "abcdefghijklmnopqrstuvwxyz1234567890";
            foreach (var sor in kod)
            {
                foreach (var karakter in sor)
                    if (!angolABCszamok.Contains(karakter))
                    {
                        lbxHibak.Items.Add($"Hibás karakter ({karakter}) van a mátrixban!");
                        kodTablaRossz = true;
                    }
            }

            // minden betű és szám csak 1-szer HF 11d 11a
            
            for(int i=0; i< angolABCszamok.Length;i++)
            {
               int db = 0;
                foreach (var sor in kod)
                {
                    foreach (var kar in sor)
                        if (angolABCszamok[i]==kar)
                        {
                            db++;
                           
                        }
                }
                if(db != 1)
                {
                    lbxHibak.Items.Add($"Hibás karakter ({angolABCszamok[i]}x{db}) van a mátrixban!");
                    kodTablaRossz = true;
                }

               
            }







            if (!kodTablaRossz) lbxHibak.Items.Add("A mátrix megfelelő!");
        }

        bool kodSorHossza()
        {
                foreach (var sor in kod)
                {
                    if (sor.Length != 6) return false;
                }
            return true;
        }
    }
}
