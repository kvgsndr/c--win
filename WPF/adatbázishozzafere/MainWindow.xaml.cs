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
using MySql.Data.MySqlClient;

namespace adatbázishozzafere
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            using MySqlConnection mySqlConnection = new MySqlConnection("Server=localhost; Database=teszt; Uid=root; Pwd=");
            {
                try
                {
                    mySqlConnection.Open();
                     if (mySqlConnection.State == System.Data.ConnectionState.Open)
                    {
                        MySqlDataReader reader;
                        MySqlCommand cmd = new MySqlCommand("", mySqlConnection);
                       
                        long maxID = cmd.LastInsertedId;
                        for (long i =maxID+1 ; i < maxID + 5; i++)
                        {
                            cmd.CommandText=String.Format($"insert into ember (nev, szulev, cim) values('emberke{i}', 1922, 'gólya utca {i}.') ");
                            cmd.ExecuteNonQuery();
                        }
                        

                        cmd.CommandText = String.Format("select * from ember ;");
                        reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            lbxTabla.Items.Add(reader.GetString(0) + reader.GetString(1) + reader.GetString(2) + reader.GetString(3));
                        }
                        reader.Close();
                    }
                }
                catch (Exception kiv)
                {
                    MessageBox.Show(kiv.Message);

                }
            }//using
            

        }
    }
}
