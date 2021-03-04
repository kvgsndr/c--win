using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > 0)
            {
                //Text = listBox1.SelectedItem.ToString();
                Text = listBox1.Items[listBox1.SelectedIndex].ToString();
            }
            else
                MessageBox.Show("Jelöld meg az elemet!");
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(listBox1.SelectedItem);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(listBox1.Items[listBox1.SelectedIndex]);
            //listBox1.Items.Remove(listBox1.SelectedItem);
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(comboBox1.Text);
        }
    }
}
