using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listbox_comboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                //Text = listBox1.Items[listBox1.SelectedIndex].ToString();
                Text = listBox1.SelectedItem.ToString();
            }
            else
                MessageBox.Show("Nincs kijelölve elem!");
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

            if (listBox1.SelectedIndex != -1)
            {
                listBox2.Items.Add("ACCD ");
                listBox2.Items.Insert(listBox2.SelectedIndex, listBox1.SelectedItem);
            }
            else
                MessageBox.Show("Nincs kijelölve elem!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //listBox2.Items.RemoveAt(listBox2.SelectedIndex);
            listBox2.Items.Remove(listBox2.SelectedItem);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox2.Items.Add(" ");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(comboBox1.Text);
        }
    }
}
