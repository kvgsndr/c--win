using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace szövegfeldolgozás
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             string s = textBox1.Text;
            s = s.ToUpper();
            textBox3.Text = s;
            for (int i = 0; i < s.Length; i++)
            {   
                if( !listBox1.Items.Contains(s[i])) listBox1.Items.Add(s[i]);
            }
            

                    
                       
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show( textBox1.Text.Contains(textBox2.Text).ToString());
            int sz = textBox1.Text.IndexOf(textBox2.Text);
            MessageBox.Show(sz.ToString());
            if (sz >= 0)
            {
                listBox1.Items.Add(textBox1.Text.Substring(sz, textBox2.Text.Length));
                textBox1.Text= textBox1.Text.Remove(sz, textBox2.Text.Length);
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text= textBox1.Text.Trim();
            var szavak = textBox1.Text.Split(' ');
            listBox1.Items.AddRange(szavak);        }
    }
}
