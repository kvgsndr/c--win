using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dinamikus_gomb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CreateDynamicButton();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void CreateDynamicButton()

        {

            // Create a Button object 

            Button dynamicButton = new Button();



            // Set Button properties

            dynamicButton.Height = 40;

            dynamicButton.Width = 300;

            dynamicButton.BackColor = Color.Red;

            dynamicButton.ForeColor = Color.Blue;

            dynamicButton.Location = new Point(20, 150);

            dynamicButton.Text = "I am Dynamic Button";

            dynamicButton.Name = "DynamicButton";

            dynamicButton.Font = new Font("Georgia", 16);



            // Add a Button Click Event handler

            dynamicButton.Click += new EventHandler(DynamicButton_Click);

            // Add Button to the Form. Placement of the Button
            // will be based on the Location and Size of button

            Controls.Add(dynamicButton);

        }

        /// Button click event handler

        private void DynamicButton_Click(object sender, EventArgs e)

        {

            MessageBox.Show("Dynamic button is clicked");

        }
    }
}
