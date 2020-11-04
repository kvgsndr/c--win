using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mozgó_gomb
{
    public partial class Form1 : Form
    {   Random rnd =new Random();
        int dx = 10;
        int dy = 5;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dy = rnd.Next(5, 12);
        }

        private void timer1_Tick(object sender, EventArgs e)
        { 
            
            button1.Left += dx;
            button1.Top += dy;
            if ((button1.Left + button1.Width) >= Width-25 || button1.Left<=0)
                dx = -1 * dx;
            if ((button1.Top + button1.Height) >= Height-25 || button1.Top <= 0)
                dy = -1 * dy;

            if((button1.Left> button2.Left && button1.Left< (button2.Left+button2.Width)  ) && (button1.Top+button1.Height)>= button2.Top)
                dy = -dy;  

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            button2.Location = new Point(e.X, button2.Top);
        }
    }
}
