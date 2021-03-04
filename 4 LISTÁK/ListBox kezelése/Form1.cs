using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBox_kezelése
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //hozzáad1
        {
            listBox1.Items.Add(textBox1.Text);
        }

        private void button12_Click(object sender, EventArgs e) //hozzáad2
        {
            listBox2.Items.Add(textBox2.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {   
            listBox1.Items.Insert(0, listBox1.SelectedItem);
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(listBox1.SelectedItem);
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int jelolt = listBox1.SelectedIndex;
            listBox1.Items.Insert(listBox1.SelectedIndex - 1, listBox1.SelectedItem);
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            listBox1.SelectedIndex = jelolt - 1;
        }

        private void listBox1_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button13.Enabled = false;



            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button13.Enabled = false;
            }
            else 
            {
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button13.Enabled = true;
            }
            if (listBox1.SelectedIndex == 0)
            {
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
            }
            if (listBox1.SelectedIndex == listBox1.Items.Count - 1)
            {
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = true;
            }
            if (listBox1.SelectedIndex >0 && listBox1.SelectedIndex< listBox1.Items.Count - 1)
            {
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int jelolt = listBox1.SelectedIndex;
            listBox1.Items.Insert(listBox1.SelectedIndex +2, listBox1.SelectedItem);
            listBox1.SelectedIndex = jelolt+2;
            listBox1.Items.RemoveAt(jelolt);
        }
    }
}
