using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ymxb
{
    public partial class Form1 : Form
    {
        float tx, ty;
        public Form1()
        {
            InitializeComponent();
            tx = ClientRectangle.Width / 2;
            ty = ClientRectangle.Height / 2;
            Point pont = new Point((int)tx - 20, 5);
            yjel.Location = pont;
            pont.X = ClientRectangle.Width - 20;
            pont.Y = (int)ty + 10;
            xjel.Location = pont;
        }

        private void on_meretvalt(object sender, EventArgs e)
        {
            tx = ClientRectangle.Width / 2;
            ty = ClientRectangle.Height / 2;
            Point pont=new Point((int)tx - 20,5);
            yjel.Location = pont;
            pont.X = ClientRectangle.Width - 20;
            pont.Y = (int)ty + 10;
            xjel.Location = pont;
            Invalidate();
            Update();
        }

        Pen ttoll = new Pen(Color.Black, 3);
        Pen etoll = new Pen(Color.Blue, 3);
        Pen otoll = new Pen(Color.Gray, 1);
        private void on_rajzol(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawLine(ttoll, tx, 0, tx, ClientRectangle.Height);
            e.Graphics.DrawLine(ttoll, tx, 0, tx - 10, 10);
            e.Graphics.DrawLine(ttoll, tx, 0, tx + 10, 10);

            
            e.Graphics.DrawLine(ttoll, 0, ty, ClientRectangle.Width,ty);
            e.Graphics.DrawLine(ttoll, ClientRectangle.Width, ty,ClientRectangle.Width-10,ty-10);
            e.Graphics.DrawLine(ttoll, ClientRectangle.Width, ty, ClientRectangle.Width - 10, ty + 10);

            for (int x = 10; x < tx; x += 10)
            {
                e.Graphics.DrawLine(otoll, tx - x, 0, tx - x, ClientRectangle.Height);
                e.Graphics.DrawLine(otoll, tx + x, 0, tx + x, ClientRectangle.Height);
            }
            for (int y = 10; y < ty; y += 10)
            {
                e.Graphics.DrawLine(otoll, 0, ty-y, ClientRectangle.Width, ty-y);
                e.Graphics.DrawLine(otoll, 0, ty + y, ClientRectangle.Width, ty + y);
            }

            float x1, y1, x2, y2;
            x1 = 0-tx;
            x2 = tx;
            y1 = Convert.ToSingle(m.Value) * x1 + Convert.ToSingle(b.Value);
            y2 = Convert.ToSingle(m.Value) * x2 + Convert.ToSingle(b.Value);
            
            x1 = 0;
            x2 = ClientRectangle.Width;
            y1 = ty - y1;
            y2 = ty - y2;
            e.Graphics.DrawLine(etoll, x1, y1, x2, y2);

  /*          float sy,sx,sxe,sye;
            sxe = 0;
            sye = (float)Math.Sin(((float)(0-tx)) / 20) * 100;
            for (int x = 0 - (int)tx + 1; x < tx; x++)
            {
                sy = (float)Math.Sin(((float)x)/20)*100;

                sx = x + tx;
                sy = ty - sy;
                e.Graphics.DrawLine(etoll,sx, sy, sxe, sye);
                sxe = sx;
                sye = sy;
            }


            */


        }

        private void on_ujrair(object sender, EventArgs e)
        {
            Invalidate();
            Update();
        }
    }
}
