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

using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;
using Microsoft.Win32;

namespace exel_olvasaás
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
            Excel.Application oXL;
            Excel._Workbook oWB;
            Excel._Worksheet oSheet;
            

            try
            {
                
                oXL = new Excel.Application();
                oXL.Visible = true;
                
                OpenFileDialog openFileDialog = new OpenFileDialog();
                if (openFileDialog.ShowDialog() == true)
                {

                    oWB = (Excel._Workbook)oXL.Workbooks.Open(openFileDialog.FileName);
                   // oSheet = (Excel._Worksheet)oWB.Sheets[0];
                    oSheet = (Excel._Worksheet)oWB.ActiveSheet;
                    
                    lb1.Content = oSheet.Cells[1, 1].Comment.Text();




                    //oWB.Close();
                    //oXL.Quit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba");
            }
        }

     
    }
}
