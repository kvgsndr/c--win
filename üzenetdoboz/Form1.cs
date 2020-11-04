using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace üzenetdoboz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ez egy üzenet a MessageBoxban");
            MessageBox.Show("Ez egy üzenet!", "Ez itt a címsor ");
            MessageBox.Show("Ez egy üzenet", " Gombok", MessageBoxButtons.YesNoCancel);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ez egy üzenet!", "Ez itt a címsor ");
        }

        private void button3_Click(object sender, EventArgs e)
        { DialogResult eredmeny = MessageBox.Show("Ez egy üzenet", " Gombok", MessageBoxButtons.YesNoCancel);
           
            if (eredmeny == DialogResult.Yes)
                MessageBox.Show("Igenre kattintott!");
            else if (eredmeny == DialogResult.No)
                MessageBox.Show("Nemre kattinrott!");
            else
                MessageBox.Show("Mégse re kattintatt!");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ez egy üzenet", "Cím", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ez egy üzenet", "Cím", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button3);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ez egy üzenet", "", MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button3, MessageBoxOptions.RightAlign);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Szöveg", "Címsor", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button3, MessageBoxOptions.RtlReading, true);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ki szeretnél lépni?", "Kilépés", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
