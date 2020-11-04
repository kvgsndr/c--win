using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIZZA_RENDEL_LISTBOX_COMBO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s1,s2,s3;
            s1 = comboBox1.SelectedItem.ToString().Split(' ')[1];
            s2 = comboBox2.SelectedItem.ToString().Split(' ')[1];
            s3 = comboBox3.SelectedItem.ToString().Split(' ')[1];

            int a1, a2, a3;
            if (!int.TryParse(s1, out a1)) MessageBox.Show("Nem lehet átkonvertálni a méretet.");
            if (!int.TryParse(s2, out a2)) MessageBox.Show("Nem lehet átkonvertálni a tipust.");
            if (!int.TryParse(s3, out a3)) MessageBox.Show("Nem lehet átkonvertálni a öntetet.");


            //int ár = Convert.ToInt32(s1) + Convert.ToInt32(s2) + Convert.ToInt32(s3);
            int ár = a1 + a2 + a3;

            label4.Text = "ÁR= "+ár.ToString()+"ft \n"+comboBox1.SelectedItem.ToString() + " " 
                + comboBox2.SelectedItem.ToString() + " "
                + comboBox3.SelectedItem.ToString();


           
        
        
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;

        }
         
         

       

        

        private void button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int a, b, c;
            for (int i = 0; i < Convert.ToInt32(textBox1.Text); i++)
            {
                a = rnd.Next(comboBox1.Items.Count);
                b = rnd.Next(comboBox2.Items.Count);
                c = rnd.Next(comboBox3.Items.Count);
                string s1, s2, s3;
                s1 = comboBox1.Items[a].ToString().Split(' ')[1];
                s2 = comboBox2.Items[b].ToString().Split(' ')[1];
                s3 = comboBox3.Items[c].ToString().Split(' ')[1];

                int a1, a2, a3;
                if (!int.TryParse(s1, out a1)) MessageBox.Show("Nem lehet átkonvertálni a méretet.");
                if (!int.TryParse(s2, out a2)) MessageBox.Show("Nem lehet átkonvertálni a tipust.");
                if (!int.TryParse(s3, out a3)) MessageBox.Show("Nem lehet átkonvertálni a öntetet.");


                //int ár = Convert.ToInt32(s1) + Convert.ToInt32(s2) + Convert.ToInt32(s3);
                int ár = a1 + a2 + a3;

                listBox1.Items.Add("ÁR= " + ár.ToString() + " ft " + comboBox1.Items[a].ToString() + " "
                    + comboBox2.Items[b].ToString() + " "
                    + comboBox3.Items[c].ToString());
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string s1, s2, s3;
            s1 = comboBox1.SelectedItem.ToString().Split(' ')[1];
            s2 = comboBox2.SelectedItem.ToString().Split(' ')[1];
            s3 = comboBox3.SelectedItem.ToString().Split(' ')[1];

            int a1, a2, a3;
            if (!int.TryParse(s1, out a1)) MessageBox.Show("Nem lehet átkonvertálni a méretet.");
            if (!int.TryParse(s2, out a2)) MessageBox.Show("Nem lehet átkonvertálni a tipust.");
            if (!int.TryParse(s3, out a3)) MessageBox.Show("Nem lehet átkonvertálni a öntetet.");


            //int ár = Convert.ToInt32(s1) + Convert.ToInt32(s2) + Convert.ToInt32(s3);
            int ár = a1 + a2 + a3;

            listBox1.Items.Add( "ÁR= " + ár.ToString() + " ft " + comboBox1.SelectedItem.ToString() + " "
                + comboBox2.SelectedItem.ToString() + " "
                + comboBox3.SelectedItem.ToString());

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int osszeg = 0;
            foreach (var item in listBox1.Items)
            {
                osszeg+=Convert.ToInt32( item.ToString().Split(' ')[1]);
            }

            label6.Text = osszeg.ToString() + " ft";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            listBox1.Items.Remove(listBox1.SelectedItem);

        }
    }
}
