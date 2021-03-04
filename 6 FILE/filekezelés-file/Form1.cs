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

namespace filekezelés_file
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {/*
            bool létezik= File.Exists("adatok.txt");
            if (létezik) 
               File.Delete("adatok.txt");

            létezik = File.Exists("adatok.txt");
            if(!létezik) 
               File.Create("adatok.txt");
             
            File.AppendAllLines("adatok.txt", richTextBox1.Lines);
            File.WriteAllText("adatok.txt", "szöveg");
            string s=File.ReadAllText("adatok.txt");
            File.Copy("adatok.txt", "adatok copy.txt", true);
            File.Move("adatok.txt", "adatok copy.txt");
           */ 


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader fbe = new StreamReader(openFileDialog1.FileName);
                string s;
                
                while((s= fbe.ReadLine()) !=null)
                    richTextBox1.Text += s+"\n";
                richTextBox1.Text += "\n\n";
                fbe.Close();


                fbe = new StreamReader(openFileDialog1.FileName);
                while(!fbe.EndOfStream)
                {
                    s = fbe.ReadLine();
                    richTextBox1.Text += s + "\n";
                }
                richTextBox1.Text += "\n\n";

                fbe.Close();

                fbe = new StreamReader(openFileDialog1.FileName);
                richTextBox1.Text += fbe.ReadToEnd();

                fbe.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult rez = saveFileDialog1.ShowDialog();
            if (rez == DialogResult.OK)
            {
                StreamWriter fki = new StreamWriter(saveFileDialog1.FileName);
               
                fki.WriteLine(richTextBox1.Text);

                
                for (int i = 0; i < richTextBox1.Lines.Length; i++)
                {
                    fki.Write(richTextBox1.Lines[i]);
                }

                fki.WriteLine("VÉGE! {0} sor kiírva.", richTextBox1.Lines.Length+1);
                
                


              fki.Close();

                
               
            }
        }
    }
}
