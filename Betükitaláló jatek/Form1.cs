using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Betükitaláló_jatek
{
    public partial class Form1 : Form
    {
        string szo;
        int tipp=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            szo = listBox1.Items[rnd.Next(listBox1.Items.Count)].ToString();
            //szo = "abcde";
            for (int i = 0; i < szo.Length; i++)
            {
                textBox1.Text += " _ ";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sorszam = int.Parse(textBox2.Text);
            char betu = char.Parse(textBox3.Text.ToLower());
            tipp++;
            label4.Text = "Tipp: " + tipp.ToString();


            if (betu == szo[sorszam])
            {
                int poz = 3 * sorszam;  //   ._.._.._.._.
                textBox1.Text= textBox1.Text.Remove(poz, 3);
                textBox1.Text=textBox1.Text.Insert(poz, " " + betu + " ");
            
            }
            else
                MessageBox.Show("A betű nem megfelelő a pozicióra!");
        }
    }
}
