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

namespace adatok
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

        private void btOk_Click(object sender, RoutedEventArgs e)
        {
            string str = tbVezetekNev.Text + " " + tbKereszNev.Text + "\n";
            str += "e-Mail: " + tbEMail.Text+ Environment.NewLine;
            str += "Tel: " + tbTel.Text;
            tbAdatok.Text = str;
        }

        private void tbVezetekNev_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void tbVezetekNev_LostFocus(object sender, RoutedEventArgs e)
        {
            

            string elso = tbVezetekNev.Text[0].ToString().ToUpper();
            tbVezetekNev.Text = elso + tbVezetekNev.Text.Substring(1);
        }

        private void tbKereszNev_LostFocus(object sender, RoutedEventArgs e)
        {
            string elso = tbKereszNev.Text[0].ToString().ToUpper();
            tbKereszNev.Text = elso + tbKereszNev.Text.Substring(1);
        }

        private void tbEMail_LostFocus(object sender, RoutedEventArgs e)
        {
            int poz1 = tbEMail.Text.IndexOf('@');
            int poz2 = tbEMail.Text.LastIndexOf('@');
            int pont1 = tbEMail.Text.IndexOf('.');
            int pont2 = tbEMail.Text.LastIndexOf('.');
            if (poz1 != poz2  || poz1<1 || poz2>tbEMail.Text.Length-3 || poz1>=pont2 || pont2== tbEMail.Text.Length-1)
            {  
                tbEMail.SelectAll();
                MessageBox.Show("Rossz e-mail!");
                
            }
                

        }

        private void tbTel_Changed(object sender, RoutedEventArgs e)
        {
            string szamok = "1234567890 ";
            foreach (var item in tbTel.Text)
            {
                if (!szamok.Contains(item))
                {
                    MessageBox.Show("A telefonszám csak számokat tartalmazhat", "Figyelmeztetés");
                    tbTel.SelectAll();
                    return;
                }
                    
            }
        }
    }
}
