using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TombCiklus
{
    public partial class Form1 : Form
    {
        int[] szamok = {456,98,654,4,321,56,987,519, 978,611,599,828,32,9,553,217,876,44,374,535 };
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //jelenítsd meg a tömbben tárold számokat 
            //a richTextBox1 nevű szövgdobozban egymást követő sorokban

            foreach (int szam in szamok) {
                richTextBox1.AppendText(szam.ToString() + "\r\n");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // bezárja az űrlapot

            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //töröld a richtextBox1 nevű szövegdoboz szövegét

            richTextBox1.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //töröld a richtextBox2 nevű szövegdoboz szövegét
            richTextBox2.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //cseréld ki a tömbben található számokat 1000-2000 közötti véletlen számokra

            Random veletlen = new Random();
            for (int i=0; i<szamok.Length; i++) {
                szamok[i] = veletlen.Next(1000,2001);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //egy üzenet ablakba írd ki a tömb 7. elemét

            MessageBox.Show("A tömb 7. eleme: "+szamok[6]);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //a textBox1 nevű elem szövegében található sorszámú eleme a tömbnek
            //ellenőrizd: ha a sorszám  nem esik 1-20 közé, üzenetablakban "dobj" hibát

            int i = int.Parse(textBox1.Text);
            if (i>=0 && i<= szamok.Length) {
                MessageBox.Show("A tömb " + textBox1.Text + ". eleme: " + szamok[i - 1]);
            } else {
                MessageBox.Show("Hibás sorszámot adtál meg!");
            }
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //jelenítsd meg a tömbben tárold számokat fordított sorrendben
            //a richTextBox2 nevű szövegdobozban egymást követő sorokban

            for (int i=szamok.Length-1; i>=0; i--) {
                richTextBox2.AppendText(szamok[i].ToString()+"\r\n");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //jelenítsd meg a tömbben tárold páros számokat 
            //a richTextBox2 nevű szövegdobozban egymást követő sorokban

            foreach (int szam in szamok) {
                if (szam % 2 ==0) {
                    richTextBox2.AppendText(szam.ToString() + "\r\n");
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //jelenítsd meg a tömbben tárold 5-tel osztható számokat 
            //a richTextBox2 nevű szövegdobozban egymást követő sorokban

            foreach (int szam in szamok)
            {
                if (szam % 5 == 0)
                {
                    richTextBox2.AppendText(szam.ToString() + "\r\n");
                }
            }

        }

        private void button11_Click(object sender, EventArgs e)
        {
            //jelenítsd meg a tömbben tárold számok közül az első elemnél nagyobbakat
            //a richTextBox2 nevű szövegdobozban egymást követő sorokban

            foreach (int szam in szamok) {
                if (szam > szamok[0]) {
                    richTextBox2.AppendText(szam.ToString() + "\r\n");
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //jelenítsd meg a tömbben tárold számok közül az utolsó elemnél kisebbeket
            //a richTextBox2 nevű szövegdobozban egymást követő sorokban

            foreach (int szam in szamok)
            {
                if (szam < szamok[szamok.Length-1])
                {
                    richTextBox2.AppendText(szam.ToString() + "\r\n");
                }
            }

        }

        private void button13_Click(object sender, EventArgs e)
        {
            //jelenítsd meg a tömbben tárold számok közül minden másodikat
            //a richTextBox2 nevű szövgdobozban egymást követő sorokban

            for (int i=1; i<szamok.Length; i+=2) { //induló elem a 2. ezért induló i=1!!!!
                richTextBox2.AppendText(szamok[i].ToString() + "\r\n");
            }
        }
    }
}
