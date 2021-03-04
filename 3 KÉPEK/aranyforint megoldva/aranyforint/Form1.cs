using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aranyforint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

          //egy lehetséges egyszerű megoldás    
               private void button1_Click(object sender, EventArgs e)
              {
                  Random rnd = new Random();
                  if (rnd.Next(2) == 0)
                  {
                      pictureBox1.Visible = true;
                      pictureBox2.Visible = false;
                  }
                  else
                  {
                      pictureBox1.Visible = false;
                      pictureBox2.Visible = true;
                  }
              }


        
        //        másikmegoldás
        //
        //private void button1_Click(object sender, EventArgs e)
        //{
        //    Random rnd = new Random();
        //    pictureBox1.Visible = true;
        //    if (rnd.Next(2) == 0)
        //    {
        //        pictureBox1.Visible = true;
        //        pictureBox1.Image = Resources.fej;
        //    }
        //    else
        //    {
        //        pictureBox1.Image = Resources.iras;
        //    }
        //}

    }
}
