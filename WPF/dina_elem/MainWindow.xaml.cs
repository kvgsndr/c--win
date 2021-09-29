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

namespace dina_elem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            din_elem_letrehoz();
        }

        public void din_elem_letrehoz()
        {
            Label lab1 = new Label();
            lab1.Content = "Ez egy dinamikusan létrehozott elem!";
            lab1.Name = "lblab1";

            
            gridpanel.Children.Add(lab1);
        }
    }
}
