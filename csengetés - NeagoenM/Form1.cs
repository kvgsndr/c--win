using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csengetés
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BT_OK_Click(object sender, EventArgs e)
        {
            LBox_Time.Items.Clear();
            DateTime schoolday = new DateTime(2020, 11, 23, 8, 0, 0);
            for (int i = 0; i < 7; i++)
            {
                string start=schoolday.ToShortTimeString();
                //Checking if combobox is empty
                if (Combo_Length.SelectedIndex==-1)
                {
                    MessageBox.Show("Válassza ki a tanórák hosszát!");
                    break;
                }

                //30 minute classes
                if (Combo_Length.SelectedIndex==0)
                {
                    //First class 30 min
                    if (i==0)
                    {
                        if (RB_First_5_Min.Checked==true)
                        {
                            schoolday = schoolday.AddMinutes(30);
                            LBox_Time.Items.Add("1. " + start + " - " + schoolday.ToShortTimeString());
                            schoolday = schoolday.AddMinutes(5);
                        }
                        if (RB_First_10_Min.Checked == true)
                        {
                            schoolday = schoolday.AddMinutes(30);
                            LBox_Time.Items.Add("1. " + start + " - " + schoolday.ToShortTimeString());
                            schoolday = schoolday.AddMinutes(10);
                        }
                        if (RB_First_15_Min.Checked == true)
                        {
                            schoolday = schoolday.AddMinutes(30);
                            LBox_Time.Items.Add("1. " + start + " - " + schoolday.ToShortTimeString());
                            schoolday = schoolday.AddMinutes(15);
                        }
                    }
                    start = schoolday.ToShortTimeString();

                    //Second class 30 min
                    if (i == 1)
                    {
                        if (RB_Second_5_Min.Checked == true)
                        {
                            schoolday = schoolday.AddMinutes(30);
                            LBox_Time.Items.Add("2. " + start + " - " + schoolday.ToShortTimeString());
                            schoolday = schoolday.AddMinutes(5);
                        }
                        if (RB_Second_10_Min.Checked == true)
                        {
                            schoolday = schoolday.AddMinutes(30);
                            LBox_Time.Items.Add("2. " + start + " - " + schoolday.ToShortTimeString());
                            schoolday = schoolday.AddMinutes(10);
                        }
                        if (RB_Second_15_Min.Checked == true)
                        {
                            schoolday = schoolday.AddMinutes(30);
                            LBox_Time.Items.Add("2. " + start + " - " + schoolday.ToShortTimeString());
                            schoolday = schoolday.AddMinutes(15);
                        }
                    }
                    start = schoolday.ToShortTimeString();

                    //Third class 30 min
                    if (i == 2)
                    {
                        if (RB_Third_5_Min.Checked == true)
                        {
                            schoolday = schoolday.AddMinutes(30);
                            LBox_Time.Items.Add("3. " + start + " - " + schoolday.ToShortTimeString());
                            schoolday = schoolday.AddMinutes(5);
                        }
                        if (RB_Third_10_Min.Checked == true)
                        {
                            schoolday = schoolday.AddMinutes(30);
                            LBox_Time.Items.Add("3. " + start + " - " + schoolday.ToShortTimeString());
                            schoolday = schoolday.AddMinutes(10);
                        }
                        if (RB_Third_15_Min.Checked == true)
                        {
                            schoolday = schoolday.AddMinutes(30);
                            LBox_Time.Items.Add("3. " + start + " - " + schoolday.ToShortTimeString());
                            schoolday = schoolday.AddMinutes(15);
                        }
                    }
                    start = schoolday.ToShortTimeString();

                    //Fourth class 30 min
                    if (i == 3)
                    {
                        if (RB_Fourth_5_Min.Checked == true)
                        {
                            schoolday = schoolday.AddMinutes(30);
                            LBox_Time.Items.Add("4. " + start + " - " + schoolday.ToShortTimeString());
                            schoolday = schoolday.AddMinutes(5);
                        }
                        if (RB_Fourth_10_Min.Checked == true)
                        {
                            schoolday = schoolday.AddMinutes(30);
                            LBox_Time.Items.Add("4. " + start + " - " + schoolday.ToShortTimeString());
                            schoolday = schoolday.AddMinutes(10);
                        }
                        if (RB_Fourth_15_Min.Checked == true)
                        {
                            schoolday = schoolday.AddMinutes(30);
                            LBox_Time.Items.Add("4. " + start + " - " + schoolday.ToShortTimeString());
                            schoolday = schoolday.AddMinutes(15);
                        }
                    }
                    start = schoolday.ToShortTimeString();

                    //Fifth class 30 min
                    if (i == 4)
                    {
                        if (RB_Fifth_5_Min.Checked == true)
                        {
                            schoolday = schoolday.AddMinutes(30);
                            LBox_Time.Items.Add("5. " + start + " - " + schoolday.ToShortTimeString());
                            schoolday = schoolday.AddMinutes(5);
                        }
                        if (RB_Fifth_10_Min.Checked == true)
                        {
                            schoolday = schoolday.AddMinutes(30);
                            LBox_Time.Items.Add("5. " + start + " - " + schoolday.ToShortTimeString());
                            schoolday = schoolday.AddMinutes(10);
                        }
                        if (RB_Fifth_15_Min.Checked == true)
                        {
                            schoolday = schoolday.AddMinutes(30);
                            LBox_Time.Items.Add("5. " + start + " - " + schoolday.ToShortTimeString());
                            schoolday = schoolday.AddMinutes(15);
                        }
                    }
                    start = schoolday.ToShortTimeString();

                    //Sixth class 30 min
                    if (i == 5)
                    {
                        if (RB_Sixth_5_Min.Checked == true)
                        {
                            schoolday = schoolday.AddMinutes(30);
                            LBox_Time.Items.Add("6. " + start + " - " + schoolday.ToShortTimeString());
                            schoolday = schoolday.AddMinutes(5);
                        }
                        if (RB_Sixth_10_Min.Checked == true)
                        {
                            schoolday = schoolday.AddMinutes(30);
                            LBox_Time.Items.Add("6. " + start + " - " + schoolday.ToShortTimeString());
                            schoolday = schoolday.AddMinutes(10);
                        }
                        if (RB_Sixth_15_Min.Checked == true)
                        {
                            schoolday = schoolday.AddMinutes(30);
                            LBox_Time.Items.Add("6. " + start + " - " + schoolday.ToShortTimeString());
                            schoolday = schoolday.AddMinutes(15);
                        }
                    }
                    start = schoolday.ToShortTimeString();

                    //Seventh class 30 min
                    if (i == 6)
                    {
                        if (RB_Seventh_5_Min.Checked == true)
                        {
                            schoolday = schoolday.AddMinutes(30);
                            LBox_Time.Items.Add("7. " + start + " - " + schoolday.ToShortTimeString());
                            schoolday = schoolday.AddMinutes(5);
                        }
                        if (RB_Seventh_10_Min.Checked == true)
                        {
                            schoolday = schoolday.AddMinutes(30);
                            LBox_Time.Items.Add("7. " + start + " - " + schoolday.ToShortTimeString());
                            schoolday = schoolday.AddMinutes(10);
                        }
                        if (RB_Seventh_15_Min.Checked == true)
                        {
                            schoolday = schoolday.AddMinutes(30);
                            LBox_Time.Items.Add("7. " + start + " - " + schoolday.ToShortTimeString());
                            schoolday = schoolday.AddMinutes(15);
                        }
                    }
                }

                //35 minute classes
                if (Combo_Length.SelectedIndex == 1)
                {
                    //First class 35 min
                    if (i == 0)
                    {
                        if (RB_First_5_Min.Checked == true)
                        {
                            schoolday = schoolday.AddMinutes(35);
                            LBox_Time.Items.Add("1. " + start + " - " + schoolday.ToShortTimeString());
                            schoolday = schoolday.AddMinutes(5);
                        }
                        if (RB_First_10_Min.Checked == true)
                        {
                            schoolday = schoolday.AddMinutes(35);
                            LBox_Time.Items.Add("1. " + start + " - " + schoolday.ToShortTimeString());
                            schoolday = schoolday.AddMinutes(10);
                        }
                        if (RB_First_15_Min.Checked == true)
                        {
                            schoolday = schoolday.AddMinutes(35);
                            LBox_Time.Items.Add("1. " + start + " - " + schoolday.ToShortTimeString());
                            schoolday = schoolday.AddMinutes(15);
                        }
                    }
                    start = schoolday.ToShortTimeString();

                    //Second class 35 min
                    if (i == 1)
                    {
                        if (RB_Second_5_Min.Checked == true)
                        {
                            schoolday = schoolday.AddMinutes(35);
                            LBox_Time.Items.Add("2. " + start + " - " + schoolday.ToShortTimeString());
                            schoolday = schoolday.AddMinutes(5);
                        }
                        if (RB_Second_10_Min.Checked == true)
                        {
                            schoolday = schoolday.AddMinutes(35);
                            LBox_Time.Items.Add("2. " + start + " - " + schoolday.ToShortTimeString());
                            schoolday = schoolday.AddMinutes(10);
                        }
                        if (RB_Second_15_Min.Checked == true)
                        {
                            schoolday = schoolday.AddMinutes(35);
                            LBox_Time.Items.Add("2. " + start + " - " + schoolday.ToShortTimeString());
                            schoolday = schoolday.AddMinutes(15);
                        }
                    }
                    start = schoolday.ToShortTimeString();

                    //Third class 35 min
                    if (i == 2)
                    {
                        if (RB_Third_5_Min.Checked == true)
                        {
                            schoolday = schoolday.AddMinutes(35);
                            LBox_Time.Items.Add("3. " + start + " - " + schoolday.ToShortTimeString());
                            schoolday = schoolday.AddMinutes(5);
                        }
                        if (RB_Third_10_Min.Checked == true)
                        {
                            schoolday = schoolday.AddMinutes(35);
                            LBox_Time.Items.Add("3. " + start + " - " + schoolday.ToShortTimeString());
                            schoolday = schoolday.AddMinutes(10);
                        }
                        if (RB_Third_15_Min.Checked == true)
                        {
                            schoolday = schoolday.AddMinutes(35);
                            LBox_Time.Items.Add("3. " + start + " - " + schoolday.ToShortTimeString());
                            schoolday = schoolday.AddMinutes(15);
                        }
                    }
                    start = schoolday.ToShortTimeString();

                    //Fourth class 35 min
                    if (i == 3)
                    {
                        if (RB_Fourth_5_Min.Checked == true)
                        {
                            schoolday = schoolday.AddMinutes(35);
                            LBox_Time.Items.Add("4. " + start + " - " + schoolday.ToShortTimeString());
                            schoolday = schoolday.AddMinutes(5);
                        }
                        if (RB_Fourth_10_Min.Checked == true)
                        {
                            schoolday = schoolday.AddMinutes(35);
                            LBox_Time.Items.Add("4. " + start + " - " + schoolday.ToShortTimeString());
                            schoolday = schoolday.AddMinutes(10);
                        }
                        if (RB_Fourth_15_Min.Checked == true)
                        {
                            schoolday = schoolday.AddMinutes(35);
                            LBox_Time.Items.Add("4. " + start + " - " + schoolday.ToShortTimeString());
                            schoolday = schoolday.AddMinutes(15);
                        }
                    }
                    start = schoolday.ToShortTimeString();

                    //Fifth class 35 min
                    if (i == 4)
                    {
                        if (RB_Fifth_5_Min.Checked == true)
                        {
                            schoolday = schoolday.AddMinutes(35);
                            LBox_Time.Items.Add("5. " + start + " - " + schoolday.ToShortTimeString());
                            schoolday = schoolday.AddMinutes(5);
                        }
                        if (RB_Fifth_10_Min.Checked == true)
                        {
                            schoolday = schoolday.AddMinutes(35);
                            LBox_Time.Items.Add("5. " + start + " - " + schoolday.ToShortTimeString());
                            schoolday = schoolday.AddMinutes(10);
                        }
                        if (RB_Fifth_15_Min.Checked == true)
                        {
                            schoolday = schoolday.AddMinutes(35);
                            LBox_Time.Items.Add("5. " + start + " - " + schoolday.ToShortTimeString());
                            schoolday = schoolday.AddMinutes(15);
                        }
                    }
                    start = schoolday.ToShortTimeString();

                    //Sixth class 35 min
                    if (i == 5)
                    {
                        if (RB_Sixth_5_Min.Checked == true)
                        {
                            schoolday = schoolday.AddMinutes(35);
                            LBox_Time.Items.Add("6. " + start + " - " + schoolday.ToShortTimeString());
                            schoolday = schoolday.AddMinutes(5);
                        }
                        if (RB_Sixth_10_Min.Checked == true)
                        {
                            schoolday = schoolday.AddMinutes(35);
                            LBox_Time.Items.Add("6. " + start + " - " + schoolday.ToShortTimeString());
                            schoolday = schoolday.AddMinutes(10);
                        }
                        if (RB_Sixth_15_Min.Checked == true)
                        {
                            schoolday = schoolday.AddMinutes(35);
                            LBox_Time.Items.Add("6. " + start + " - " + schoolday.ToShortTimeString());
                            schoolday = schoolday.AddMinutes(15);
                        }
                    }
                    start = schoolday.ToShortTimeString();

                    //Seventh class 35 min
                    if (i == 6)
                    {
                        if (RB_Seventh_5_Min.Checked == true)
                        {
                            schoolday = schoolday.AddMinutes(35);
                            LBox_Time.Items.Add("7. " + start + " - " + schoolday.ToShortTimeString());
                            schoolday = schoolday.AddMinutes(5);
                        }
                        if (RB_Seventh_10_Min.Checked == true)
                        {
                            schoolday = schoolday.AddMinutes(35);
                            LBox_Time.Items.Add("7. " + start + " - " + schoolday.ToShortTimeString());
                            schoolday = schoolday.AddMinutes(10);
                        }
                        if (RB_Seventh_15_Min.Checked == true)
                        {
                            schoolday = schoolday.AddMinutes(35);
                            LBox_Time.Items.Add("7. " + start + " - " + schoolday.ToShortTimeString());
                            schoolday = schoolday.AddMinutes(15);
                        }
                    }
                }

                //45 minute classes
                if (Combo_Length.SelectedIndex == 2)
                {
                    //First class 45 min
                    if (i == 0)
                    {
                        if (RB_First_5_Min.Checked == true)
                        {
                            schoolday = schoolday.AddMinutes(45);
                            LBox_Time.Items.Add("1. " + start + " - " + schoolday.ToShortTimeString());
                            schoolday = schoolday.AddMinutes(5);
                        }
                        if (RB_First_10_Min.Checked == true)
                        {
                            schoolday = schoolday.AddMinutes(45);
                            LBox_Time.Items.Add("1. " + start + " - " + schoolday.ToShortTimeString());
                            schoolday = schoolday.AddMinutes(10);
                        }
                        if (RB_First_15_Min.Checked == true)
                        {
                            schoolday = schoolday.AddMinutes(45);
                            LBox_Time.Items.Add("1. " + start + " - " + schoolday.ToShortTimeString());
                            schoolday = schoolday.AddMinutes(15);
                        }
                    }
                    start = schoolday.ToShortTimeString();

                    //Second class 45 min
                    if (i == 1)
                    {
                        if (RB_Second_5_Min.Checked == true)
                        {
                            schoolday = schoolday.AddMinutes(45);
                            LBox_Time.Items.Add("2. " + start + " - " + schoolday.ToShortTimeString());
                            schoolday = schoolday.AddMinutes(5);
                        }
                        if (RB_Second_10_Min.Checked == true)
                        {
                            schoolday = schoolday.AddMinutes(45);
                            LBox_Time.Items.Add("2. " + start + " - " + schoolday.ToShortTimeString());
                            schoolday = schoolday.AddMinutes(10);
                        }
                        if (RB_Second_15_Min.Checked == true)
                        {
                            schoolday = schoolday.AddMinutes(45);
                            LBox_Time.Items.Add("2. " + start + " - " + schoolday.ToShortTimeString());
                            schoolday = schoolday.AddMinutes(15);
                        }
                    }
                    start = schoolday.ToShortTimeString();

                    //Third class 45 min
                    if (i == 2)
                    {
                        if (RB_Third_5_Min.Checked == true)
                        {
                            schoolday = schoolday.AddMinutes(45);
                            LBox_Time.Items.Add("3. " + start + " - " + schoolday.ToShortTimeString());
                            schoolday = schoolday.AddMinutes(5);
                        }
                        if (RB_Third_10_Min.Checked == true)
                        {
                            schoolday = schoolday.AddMinutes(45);
                            LBox_Time.Items.Add("3. " + start + " - " + schoolday.ToShortTimeString());
                            schoolday = schoolday.AddMinutes(10);
                        }
                        if (RB_Third_15_Min.Checked == true)
                        {
                            schoolday = schoolday.AddMinutes(45);
                            LBox_Time.Items.Add("3. " + start + " - " + schoolday.ToShortTimeString());
                            schoolday = schoolday.AddMinutes(15);
                        }
                    }
                    start = schoolday.ToShortTimeString();

                    //Fourth class 45 min
                    if (i == 3)
                    {
                        if (RB_Fourth_5_Min.Checked == true)
                        {
                            schoolday = schoolday.AddMinutes(45);
                            LBox_Time.Items.Add("4. " + start + " - " + schoolday.ToShortTimeString());
                            schoolday = schoolday.AddMinutes(5);
                        }
                        if (RB_Fourth_10_Min.Checked == true)
                        {
                            schoolday = schoolday.AddMinutes(45);
                            LBox_Time.Items.Add("4. " + start + " - " + schoolday.ToShortTimeString());
                            schoolday = schoolday.AddMinutes(10);
                        }
                        if (RB_Fourth_15_Min.Checked == true)
                        {
                            schoolday = schoolday.AddMinutes(45);
                            LBox_Time.Items.Add("4. " + start + " - " + schoolday.ToShortTimeString());
                            schoolday = schoolday.AddMinutes(15);
                        }
                    }
                    start = schoolday.ToShortTimeString();

                    //Fifth class 45 min
                    if (i == 4)
                    {
                        if (RB_Fifth_5_Min.Checked == true)
                        {
                            schoolday = schoolday.AddMinutes(45);
                            LBox_Time.Items.Add("5. " + start + " - " + schoolday.ToShortTimeString());
                            schoolday = schoolday.AddMinutes(5);
                        }
                        if (RB_Fifth_10_Min.Checked == true)
                        {
                            schoolday = schoolday.AddMinutes(45);
                            LBox_Time.Items.Add("5. " + start + " - " + schoolday.ToShortTimeString());
                            schoolday = schoolday.AddMinutes(10);
                        }
                        if (RB_Fifth_15_Min.Checked == true)
                        {
                            schoolday = schoolday.AddMinutes(45);
                            LBox_Time.Items.Add("5. " + start + " - " + schoolday.ToShortTimeString());
                            schoolday = schoolday.AddMinutes(15);
                        }
                    }
                    start = schoolday.ToShortTimeString();

                    //Sixth class 45 min
                    if (i == 5)
                    {
                        if (RB_Sixth_5_Min.Checked == true)
                        {
                            schoolday = schoolday.AddMinutes(45);
                            LBox_Time.Items.Add("6. " + start + " - " + schoolday.ToShortTimeString());
                            schoolday = schoolday.AddMinutes(5);
                        }
                        if (RB_Sixth_10_Min.Checked == true)
                        {
                            schoolday = schoolday.AddMinutes(45);
                            LBox_Time.Items.Add("6. " + start + " - " + schoolday.ToShortTimeString());
                            schoolday = schoolday.AddMinutes(10);
                        }
                        if (RB_Sixth_15_Min.Checked == true)
                        {
                            schoolday = schoolday.AddMinutes(45);
                            LBox_Time.Items.Add("6. " + start + " - " + schoolday.ToShortTimeString());
                            schoolday = schoolday.AddMinutes(15);
                        }
                    }
                    start = schoolday.ToShortTimeString();

                    //Seventh class 45 min
                    if (i == 6)
                    {
                        if (RB_Seventh_5_Min.Checked == true)
                        {
                            schoolday = schoolday.AddMinutes(45);
                            LBox_Time.Items.Add("7. " + start + " - " + schoolday.ToShortTimeString());
                            schoolday = schoolday.AddMinutes(5);
                        }
                        if (RB_Seventh_10_Min.Checked == true)
                        {
                            schoolday = schoolday.AddMinutes(45);
                            LBox_Time.Items.Add("7. " + start + " - " + schoolday.ToShortTimeString());
                            schoolday = schoolday.AddMinutes(10);
                        }
                        if (RB_Seventh_15_Min.Checked == true)
                        {
                            schoolday = schoolday.AddMinutes(45);
                            LBox_Time.Items.Add("7. " + start + " - " + schoolday.ToShortTimeString());
                            schoolday = schoolday.AddMinutes(15);
                        }
                    }
                }
            }
        }

        private void BT_Clear_Click(object sender, EventArgs e)
        {
            LBox_Time.Items.Clear();
        }
    }
}
