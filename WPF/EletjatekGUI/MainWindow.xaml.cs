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

namespace EletjatekGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CheckBox[] elemek = new CheckBox[20];
        public MainWindow()
        {
            InitializeComponent();
            for (int i = 5; i <=20 ; i++)
            {
                cbxSor.Items.Add(i);
                cbxOszlop.Items.Add(i);
            }
            cbxSor.SelectedIndex = 15;
            cbxOszlop.SelectedIndex = 15;

        }

        private void letrehoz_Click(object sender, RoutedEventArgs e)
        {
            int sorok = Convert.ToInt32(cbxSor.SelectedItem.ToString());
            int oszlopok = Convert.ToInt32(cbxOszlop.SelectedItem.ToString());
            for (int i = 0; i < sorok; i++)
            {
                for (int j = 0; j < oszlopok; j++)
                {
                    elemek[i][j] = new CheckBox(); 
                    todo
                }
            }
        }
    }
}
