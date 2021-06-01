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

namespace sudokuGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int meret = 4;
        public MainWindow()
        {
            InitializeComponent();
            tbMeret.Text = meret.ToString();
        }

        private void plusz_Click(object sender, RoutedEventArgs e)
        {
            if (meret < 9)
            { 
                meret++;
                tbMeret.Text = meret.ToString();
            } 
        }

        private void minusz_Click(object sender, RoutedEventArgs e)
        {
            if (meret >4)
            {
                meret--;
                tbMeret.Text = meret.ToString();
            }
        }

        private void tbKezdo_TextChanged(object sender, TextChangedEventArgs e)
        {
            lbHossz.Content = "Hossz: " + tbKezdo.Text.Length.ToString();
        }

        private void btEllenorzes_Click(object sender, RoutedEventArgs e)
        { int m = meret * meret;
            if (m == tbKezdo.Text.Length)
                MessageBox.Show("A feladvány megfelelő hosszúságú!");
            else if (m > tbKezdo.Text.Length)
                MessageBox.Show($"A feladvány rövid: kell még {m - tbKezdo.Text.Length} számjegy!");
            else if (m < tbKezdo.Text.Length)
                MessageBox.Show($"A feladvány hosszú: törlendő {tbKezdo.Text.Length - m} számjegy!");

        }
    }
}
