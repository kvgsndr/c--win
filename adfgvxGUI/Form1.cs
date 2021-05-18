using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace adfgvx
{
    public partial class Form1 : Form
    {
        List<string> kod = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        { kod.Clear();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader fbe = new StreamReader(openFileDialog1.FileName);
                while (!fbe.EndOfStream)
                    kod.Add(fbe.ReadLine());
            }
           
            lbKódtábla.Text = "A betöltött kódtábla:\n\n";
            foreach(var sor in kod)
            {
                foreach (var karakter in sor)
                    lbKódtábla.Text += String.Format($"{karakter,5}" );
                lbKódtábla.Text += "\n";
            }

        }

        
    }
}
