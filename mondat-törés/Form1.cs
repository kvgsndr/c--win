using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mondat_törés
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1) 
                MessageBox.Show("Nincs kiválasztott elválasztó!!!!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else{


                var szavak = textBox1.Text.Split(comboBox1.SelectedItem.ToString()[0]);
                listBox1.Items.Clear();
                listBox2.Items.Clear();
                foreach (var szó in szavak)
                {
                    
                    listBox1.Items.Add(szó);
                    listBox2.Items.Add(szó.Length);
                }

            }

        }
    }
}
