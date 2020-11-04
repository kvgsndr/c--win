using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lista_combo_számok
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            for (int i = 0; i < 100; i++)
            {
                listBox1.Items.Add(rnd.Next(100)+1);
            }
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                if (int.Parse(listBox1.Items[i].ToString())%2 == 0)
                {
                    listBox2.Items.Add(listBox1.Items[i]);  
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.Items.Count; i++)        //foreach(var item in listBox1.Items)
            {
                if (int.Parse(listBox1.Items[i].ToString()) % 2 != 0)
                {
                    comboBox1.Items.Add(listBox1.Items[i]);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
            {  
                int z = int.Parse(listBox1.Items[i].ToString());
                if (z % 5 == 0   && z % 7 ==0)
                {
                    listBox3.Items.Add(listBox1.Items[i]);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (int.Parse(listBox1.Items[listBox1.SelectedIndex].ToString()) % 2 == 0)
                listBox2.Items.Add(listBox1.SelectedItem);
            else
                MessageBox.Show("A kijelölt elem nem páros szám");

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (int.Parse(listBox1.SelectedItem.ToString()) % 2 != 0)
                comboBox1.Items.Add(listBox1.SelectedItem);
            else
                MessageBox.Show("A kijelölt elem nem páratlan szám");
        }
    }
}
