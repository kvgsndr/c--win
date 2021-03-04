namespace ListBox
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btFeltolt = new System.Windows.Forms.Button();
            this.masolMind = new System.Windows.Forms.Button();
            this.rendezJobb = new System.Windows.Forms.Button();
            this.btTorol = new System.Windows.Forms.Button();
            this.kijeloltMasol = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 25);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 199);
            this.listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(252, 25);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 199);
            this.listBox2.TabIndex = 1;
            // 
            // btFeltolt
            // 
            this.btFeltolt.Location = new System.Drawing.Point(152, 25);
            this.btFeltolt.Name = "btFeltolt";
            this.btFeltolt.Size = new System.Drawing.Size(75, 23);
            this.btFeltolt.TabIndex = 2;
            this.btFeltolt.Text = "Feltölt";
            this.btFeltolt.UseVisualStyleBackColor = true;
            this.btFeltolt.Click += new System.EventHandler(this.btFeltolt_Click);
            // 
            // masolMind
            // 
            this.masolMind.Location = new System.Drawing.Point(147, 114);
            this.masolMind.Name = "masolMind";
            this.masolMind.Size = new System.Drawing.Size(85, 23);
            this.masolMind.TabIndex = 3;
            this.masolMind.Text = "MásolMind";
            this.masolMind.UseVisualStyleBackColor = true;
            this.masolMind.Click += new System.EventHandler(this.masolMind_Click);
            // 
            // rendezJobb
            // 
            this.rendezJobb.Location = new System.Drawing.Point(152, 143);
            this.rendezJobb.Name = "rendezJobb";
            this.rendezJobb.Size = new System.Drawing.Size(75, 23);
            this.rendezJobb.TabIndex = 4;
            this.rendezJobb.Text = "RendezJobb";
            this.rendezJobb.UseVisualStyleBackColor = true;
            this.rendezJobb.Click += new System.EventHandler(this.rendezJobb_Click);
            // 
            // btTorol
            // 
            this.btTorol.Location = new System.Drawing.Point(152, 172);
            this.btTorol.Name = "btTorol";
            this.btTorol.Size = new System.Drawing.Size(75, 23);
            this.btTorol.TabIndex = 5;
            this.btTorol.Text = "Töröl";
            this.btTorol.UseVisualStyleBackColor = true;
            this.btTorol.Click += new System.EventHandler(this.btTorol_Click);
            // 
            // kijeloltMasol
            // 
            this.kijeloltMasol.Location = new System.Drawing.Point(152, 201);
            this.kijeloltMasol.Name = "kijeloltMasol";
            this.kijeloltMasol.Size = new System.Drawing.Size(75, 23);
            this.kijeloltMasol.TabIndex = 6;
            this.kijeloltMasol.Text = "kijelölt Másol";
            this.kijeloltMasol.UseVisualStyleBackColor = true;
            this.kijeloltMasol.Click += new System.EventHandler(this.kijeloltMasol_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(152, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(75, 20);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "10";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.kijeloltMasol);
            this.Controls.Add(this.btTorol);
            this.Controls.Add(this.rendezJobb);
            this.Controls.Add(this.masolMind);
            this.Controls.Add(this.btFeltolt);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btFeltolt;
        private System.Windows.Forms.Button masolMind;
        private System.Windows.Forms.Button rendezJobb;
        private System.Windows.Forms.Button btTorol;
        private System.Windows.Forms.Button kijeloltMasol;
        private System.Windows.Forms.TextBox textBox1;
    }
}

