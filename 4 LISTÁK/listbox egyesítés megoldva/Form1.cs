using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listbox_egyesítés
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int szam;
            bool jo =int.TryParse(textBox1.Text, out szam);
            if(jo)
                if (szam % 2 == 0)
                    listBox1.Items.Add(szam);
                else
                    listBox2.Items.Add(szam);
            textBox1.Focus();
            textBox1.SelectAll();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            foreach (var item in listBox1.Items)
            {
                if (!listBox3.Items.Contains(item))
                    listBox3.Items.Add(item);
            }
            foreach (var item in listBox2.Items)
            {
                if (!listBox3.Items.Contains(item))
                    listBox3.Items.Add(item);
            }
        }
    }
}
