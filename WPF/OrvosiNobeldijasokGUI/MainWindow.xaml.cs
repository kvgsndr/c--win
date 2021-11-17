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

namespace OrvosiNobeldijasokGUI
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(txbEv.Text=="" || txbNev.Text=="" || txbOrszag.Text=="" || txbSzH.Text=="")
            {
                MessageBox.Show("Töltsön ki minden mezőt!", "HIBA");
            }
            else if( int.Parse(txbEv.Text)<=1989)
            {
                MessageBox.Show("Hiba! Az évszám nem megfelelő!", "Mentés");
            }
            else
            {
                try
                {
                    StreamWriter fki = new StreamWriter("uj_dijazott.txt");
                    fki.WriteLine("Év;Név;SzületésHalálozás;Országkód");
                    fki.WriteLine($"{txbEv.Text};{txbNev.Text};{txbSzH.Text};{txbOrszag.Text}");
                    txbEv.Clear();txbNev.Clear();txbOrszag.Clear();txbSzH.Clear();
                }
                catch(Exception )
                {
                    MessageBox.Show("Hiba az állomány írásánál!");
                }
                
            }
        }
    }
}
