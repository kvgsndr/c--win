using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace szamologep_comboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = 0, b = 0, c = 0;

            //a = Convert.ToDouble(textBox1.Text);
            //b = Convert.ToDouble(textBox2.Text);

            //a = double.Parse(textBox1.Text);
            //b = double.Parse(textBox2.Text);    

            if (!double.TryParse(textBox1.Text, out a)) 
                MessageBox.Show("Nem lehet számmá alakítani 1!!");
            if (!double.TryParse(textBox2.Text, out b)) 
                MessageBox.Show("Nem lehet számmá alakítani 2!!");

            if (comboBox1.SelectedIndex == 0)           
                c = a + b;
            else if (comboBox1.SelectedIndex == 1)
                c = a - b;
            else if (comboBox1.SelectedIndex == 2)
                c = a * b;
            else if (comboBox1.SelectedIndex == 3)
                if (b == 0)
                    MessageBox.Show("Nullával nem osztunk!!!");
                else 
                    c = a / b;

            label3.Text = "Eredmény = " + String.Format("{0:0.00}", c);

        }
    }
}
