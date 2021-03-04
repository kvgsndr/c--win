using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listbox_véletlenszám
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 20; i++)
            {
                listBox1.Items.Add(rnd.Next(100));
            }
        }

        private void button3_Click(object sender, EventArgs e)
          //kijelölt osztói
        {
            int szam = Convert.ToInt32(listBox1.SelectedItem);
            for (int i = 2; i <= szam/2; i++)
            {
                if (szam%i==0)
                {
                    listBox2.Items.Add(i);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var item in listBox1.Items)
            {   int szam = Convert.ToInt32(item);
                bool prim = true;
                for (int i = 2; i <= szam/2 ; i++)
                {
                    if(szam%i==0)
                    {
                        prim = false;
                        break;
                    }
                }
                if (prim) listBox2.Items.Add(szam);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
        }
    }
}
