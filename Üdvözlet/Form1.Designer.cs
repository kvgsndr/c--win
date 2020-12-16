namespace Üdvözlet
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVeznev = new System.Windows.Forms.TextBox();
            this.txtKernev = new System.Windows.Forms.TextBox();
            this.txtUdvozlet = new System.Windows.Forms.TextBox();
            this.btnUdvozles = new System.Windows.Forms.Button();
            this.btnBezar = new System.Windows.Forms.Button();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vezetéknév: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Keresztnév:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefonszám:";
            // 
            // txtVeznev
            // 
            this.txtVeznev.Location = new System.Drawing.Point(143, 41);
            this.txtVeznev.Name = "txtVeznev";
            this.txtVeznev.Size = new System.Drawing.Size(100, 20);
            this.txtVeznev.TabIndex = 1;
            // 
            // txtKernev
            // 
            this.txtKernev.Location = new System.Drawing.Point(143, 88);
            this.txtKernev.Name = "txtKernev";
            this.txtKernev.Size = new System.Drawing.Size(100, 20);
            this.txtKernev.TabIndex = 2;
            // 
            // txtUdvozlet
            // 
            this.txtUdvozlet.Location = new System.Drawing.Point(100, 181);
            this.txtUdvozlet.Multiline = true;
            this.txtUdvozlet.Name = "txtUdvozlet";
            this.txtUdvozlet.ReadOnly = true;
            this.txtUdvozlet.Size = new System.Drawing.Size(183, 92);
            this.txtUdvozlet.TabIndex = 6;
            this.txtUdvozlet.TabStop = false;
            // 
            // btnUdvozles
            // 
            this.btnUdvozles.Location = new System.Drawing.Point(80, 304);
            this.btnUdvozles.Name = "btnUdvozles";
            this.btnUdvozles.Size = new System.Drawing.Size(75, 23);
            this.btnUdvozles.TabIndex = 7;
            this.btnUdvozles.Text = "Ü&dvözöl";
            this.btnUdvozles.UseVisualStyleBackColor = true;
            this.btnUdvozles.Click += new System.EventHandler(this.btnUdvozles_Click);
            // 
            // btnBezar
            // 
            this.btnBezar.Location = new System.Drawing.Point(234, 304);
            this.btnBezar.Name = "btnBezar";
            this.btnBezar.Size = new System.Drawing.Size(75, 23);
            this.btnBezar.TabIndex = 8;
            this.btnBezar.Text = "B&ezár";
            this.btnBezar.UseVisualStyleBackColor = true;
            this.btnBezar.Click += new System.EventHandler(this.btnBezar_Click);
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(143, 140);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(100, 20);
            this.txtTelefon.TabIndex = 3;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(265, 140);
            this.maskedTextBox1.Mask = "(99) 000-0009";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 354);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.btnBezar);
            this.Controls.Add(this.btnUdvozles);
            this.Controls.Add(this.txtUdvozlet);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtKernev);
            this.Controls.Add(this.txtVeznev);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Üdvözlet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVeznev;
        private System.Windows.Forms.TextBox txtKernev;
        private System.Windows.Forms.TextBox txtUdvozlet;
        private System.Windows.Forms.Button btnUdvozles;
        private System.Windows.Forms.Button btnBezar;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}

