using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btFeltolt_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            listBox1.Items.Clear();
            int elemekSzama = Convert.ToInt32(textBox1.Text);
            for (int i = 0; i < elemekSzama ; i++)
            {
                listBox1.Items.Add(rnd.Next(100));
            }
        }

        private void masolMind_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                listBox2.Items.Add(listBox1.Items[i]);
            }
        }

        private void rendezJobb_Click(object sender, EventArgs e)
        {
            listBox2.Sorted = true;
        }

        private void btTorol_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
        }

        private void kijeloltMasol_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(listBox1.SelectedItem);
        }
    }
}
