using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace véletle__listbox_egyesít
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                listBox1.Items.Add(rnd.Next(-200, 201));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                listBox2.Items.Add(rnd.Next(-50, -20));
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                listBox3.Items.Add(rnd.NextDouble()*(10.3+5.5)-5.5);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox4.Items.Add("Páros");
            for (int i = 0; i < listBox1.Items.Count ; i++)
            {
                if (int.Parse(listBox1.Items[i].ToString()) % 2 == 0)
                    listBox4.Items.Add(listBox1.Items[i]);
            }
            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                if (int.Parse(listBox2.Items[i].ToString()) % 2 == 0)
                    listBox4.Items.Add(listBox2.Items[i]);
            }

            listBox4.Items.Add("Páratlan");
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                if (int.Parse(listBox1.Items[i].ToString()) % 2 != 0)
                    listBox4.Items.Add(listBox1.Items[i]);
            }
            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                if (int.Parse(listBox2.Items[i].ToString()) % 2 != 0)
                    listBox4.Items.Add(listBox2.Items[i]);
            }
            listBox4.Items.Add("Tizedes");
            foreach (var item in listBox3.Items)
            {
                listBox4.Items.Add(item);
            }
        }
    }
}
