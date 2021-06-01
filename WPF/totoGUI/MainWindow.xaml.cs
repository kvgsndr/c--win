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

namespace totoGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void tbxEredmenyek_TextChanged(object sender, TextChangedEventArgs e)
        {
            int hossz = tbxEredmenyek.Text.Length;
            if (hossz != 14)
            {
                chbxKarakterekSzama.IsChecked = true;
            }
            else 
            {
                chbxKarakterekSzama.IsChecked = false;
            }
            chbxKarakterekSzama.Content = $"Nem megfelelő a karakterek száma ({hossz})";

            string text = tbxEredmenyek.Text;
            List<char> rosszak = new List<char>();
            for(int i= 0; i< text.Length;i++)
            {
                if (text[i] != '1' && text[i] != '2' && text[i] != 'X')
                    rosszak.Add(text[i]);
            }

            if (rosszak.Count != 0)
                chbxHelytelenKarakterek.IsChecked = true;
            else
                chbxHelytelenKarakterek.IsChecked = false;

            string szoveg = "Helytelen karakterek az eredményekben (";
            foreach (var item in rosszak)
            {
                szoveg += item + ";";
            }
            szoveg += ")";

            

            chbxHelytelenKarakterek.Content = szoveg;

            if (chbxHelytelenKarakterek.IsChecked == false && chbxKarakterekSzama.IsChecked == false)
                btMentes.IsEnabled = true;
            else
                btMentes.IsEnabled = false;

        }
    }
}
