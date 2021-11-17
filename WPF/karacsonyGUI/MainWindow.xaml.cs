using System;
using System.Collections.Generic;
using System.IO;
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

namespace karacsonyGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
   

    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
            for (int i = 1; i <= 40; i++)
            {
                cbxNapok.Items.Add(i);
            }

        }

        private void btHozzaad_Click(object sender, RoutedEventArgs e)
        {  
            
            
            int nap = int.Parse(cbxNapok.SelectedItem.ToString());
            int elk = int.Parse(txbElkeszitett.Text);
            int elad = int.Parse(txbEladott.Text);
            if(elk<0 || elad<0)
            {
                lbHiba.Content = "Negatív számot nem adhat meg!";

            }
            else if(elk<elad)
            {
                lbHiba.Content = "Túl sok eladott angyalka!";
            }
            else
            {
                string str = string.Format($"{nap}.nap\t+{elk}\t -{elad}\t=\t{elk - elad} ");
                lbxLista.Items.Add(str);
                txbEladott.Text = "0";
                txbElkeszitett.Text = "0";
                cbxNapok.SelectedIndex = -1;
                lbHiba.Content = "";
            }
            
        }
    }
}
