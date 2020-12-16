namespace Pizzarendelés_2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbKicsi = new System.Windows.Forms.RadioButton();
            this.rbKozepes = new System.Windows.Forms.RadioButton();
            this.rbNagy = new System.Windows.Forms.RadioButton();
            this.rbUres = new System.Windows.Forms.RadioButton();
            this.rbTengeri = new System.Windows.Forms.RadioButton();
            this.rbHavaii = new System.Windows.Forms.RadioButton();
            this.chbParadicsom = new System.Windows.Forms.CheckBox();
            this.chbMustar = new System.Windows.Forms.CheckBox();
            this.chbMajonez = new System.Windows.Forms.CheckBox();
            this.btMegrendeles = new System.Windows.Forms.Button();
            this.lbOsszeg = new System.Windows.Forms.Label();
            this.chbCsipos = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbNagy);
            this.groupBox1.Controls.Add(this.rbKozepes);
            this.groupBox1.Controls.Add(this.rbKicsi);
            this.groupBox1.Location = new System.Drawing.Point(37, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(148, 134);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Méret";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbUres);
            this.groupBox2.Controls.Add(this.rbTengeri);
            this.groupBox2.Controls.Add(this.rbHavaii);
            this.groupBox2.Location = new System.Drawing.Point(311, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(148, 134);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipus";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chbCsipos);
            this.groupBox3.Controls.Add(this.chbMajonez);
            this.groupBox3.Controls.Add(this.chbMustar);
            this.groupBox3.Controls.Add(this.chbParadicsom);
            this.groupBox3.Location = new System.Drawing.Point(37, 213);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(148, 168);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Öntet";
            // 
            // rbKicsi
            // 
            this.rbKicsi.AutoSize = true;
            this.rbKicsi.Location = new System.Drawing.Point(26, 33);
            this.rbKicsi.Name = "rbKicsi";
            this.rbKicsi.Size = new System.Drawing.Size(77, 17);
            this.rbKicsi.TabIndex = 0;
            this.rbKicsi.TabStop = true;
            this.rbKicsi.Text = "Kicsi 100 ft";
            this.rbKicsi.UseVisualStyleBackColor = true;
            // 
            // rbKozepes
            // 
            this.rbKozepes.AutoSize = true;
            this.rbKozepes.Location = new System.Drawing.Point(26, 67);
            this.rbKozepes.Name = "rbKozepes";
            this.rbKozepes.Size = new System.Drawing.Size(96, 17);
            this.rbKozepes.TabIndex = 1;
            this.rbKozepes.TabStop = true;
            this.rbKozepes.Text = "Közepes 110 ft";
            this.rbKozepes.UseVisualStyleBackColor = true;
            // 
            // rbNagy
            // 
            this.rbNagy.AutoSize = true;
            this.rbNagy.Location = new System.Drawing.Point(26, 102);
            this.rbNagy.Name = "rbNagy";
            this.rbNagy.Size = new System.Drawing.Size(80, 17);
            this.rbNagy.TabIndex = 2;
            this.rbNagy.TabStop = true;
            this.rbNagy.Text = "Nagy 120 ft";
            this.rbNagy.UseVisualStyleBackColor = true;
            // 
            // rbUres
            // 
            this.rbUres.AutoSize = true;
            this.rbUres.Location = new System.Drawing.Point(29, 103);
            this.rbUres.Name = "rbUres";
            this.rbUres.Size = new System.Drawing.Size(83, 17);
            this.rbUres.TabIndex = 5;
            this.rbUres.TabStop = true;
            this.rbUres.Text = "Üres 1000 ft";
            this.rbUres.UseVisualStyleBackColor = true;
            // 
            // rbTengeri
            // 
            this.rbTengeri.AutoSize = true;
            this.rbTengeri.Location = new System.Drawing.Point(29, 68);
            this.rbTengeri.Name = "rbTengeri";
            this.rbTengeri.Size = new System.Drawing.Size(97, 17);
            this.rbTengeri.TabIndex = 4;
            this.rbTengeri.TabStop = true;
            this.rbTengeri.Text = "Tengeri 1600 ft";
            this.rbTengeri.UseVisualStyleBackColor = true;
            // 
            // rbHavaii
            // 
            this.rbHavaii.AutoSize = true;
            this.rbHavaii.Location = new System.Drawing.Point(29, 34);
            this.rbHavaii.Name = "rbHavaii";
            this.rbHavaii.Size = new System.Drawing.Size(91, 17);
            this.rbHavaii.TabIndex = 3;
            this.rbHavaii.TabStop = true;
            this.rbHavaii.Text = "Havaii 1500 ft";
            this.rbHavaii.UseVisualStyleBackColor = true;
            // 
            // chbParadicsom
            // 
            this.chbParadicsom.AutoSize = true;
            this.chbParadicsom.Location = new System.Drawing.Point(26, 36);
            this.chbParadicsom.Name = "chbParadicsom";
            this.chbParadicsom.Size = new System.Drawing.Size(111, 17);
            this.chbParadicsom.TabIndex = 0;
            this.chbParadicsom.Text = "Paradicsom 100 ft";
            this.chbParadicsom.UseVisualStyleBackColor = true;
            // 
            // chbMustar
            // 
            this.chbMustar.AutoSize = true;
            this.chbMustar.Location = new System.Drawing.Point(26, 76);
            this.chbMustar.Name = "chbMustar";
            this.chbMustar.Size = new System.Drawing.Size(82, 17);
            this.chbMustar.TabIndex = 1;
            this.chbMustar.Text = "Mustár 95 ft";
            this.chbMustar.UseVisualStyleBackColor = true;
            // 
            // chbMajonez
            // 
            this.chbMajonez.AutoSize = true;
            this.chbMajonez.Location = new System.Drawing.Point(26, 111);
            this.chbMajonez.Name = "chbMajonez";
            this.chbMajonez.Size = new System.Drawing.Size(90, 17);
            this.chbMajonez.TabIndex = 2;
            this.chbMajonez.Text = "Majonéz 90 ft";
            this.chbMajonez.UseVisualStyleBackColor = true;
            // 
            // btMegrendeles
            // 
            this.btMegrendeles.Location = new System.Drawing.Point(311, 318);
            this.btMegrendeles.Name = "btMegrendeles";
            this.btMegrendeles.Size = new System.Drawing.Size(75, 23);
            this.btMegrendeles.TabIndex = 2;
            this.btMegrendeles.Text = "Megrendelés";
            this.btMegrendeles.UseVisualStyleBackColor = true;
            this.btMegrendeles.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbOsszeg
            // 
            this.lbOsszeg.AutoSize = true;
            this.lbOsszeg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbOsszeg.Location = new System.Drawing.Point(241, 213);
            this.lbOsszeg.Name = "lbOsszeg";
            this.lbOsszeg.Size = new System.Drawing.Size(91, 25);
            this.lbOsszeg.TabIndex = 3;
            this.lbOsszeg.Text = "Összeg: ";
            // 
            // chbCsipos
            // 
            this.chbCsipos.AutoSize = true;
            this.chbCsipos.Location = new System.Drawing.Point(26, 145);
            this.chbCsipos.Name = "chbCsipos";
            this.chbCsipos.Size = new System.Drawing.Size(83, 17);
            this.chbCsipos.TabIndex = 3;
            this.chbCsipos.Text = "Csípős 50 ft";
            this.chbCsipos.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 393);
            this.Controls.Add(this.lbOsszeg);
            this.Controls.Add(this.btMegrendeles);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Pizzarendelés";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbNagy;
        private System.Windows.Forms.RadioButton rbKozepes;
        private System.Windows.Forms.RadioButton rbKicsi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbUres;
        private System.Windows.Forms.RadioButton rbTengeri;
        private System.Windows.Forms.RadioButton rbHavaii;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chbCsipos;
        private System.Windows.Forms.CheckBox chbMajonez;
        private System.Windows.Forms.CheckBox chbMustar;
        private System.Windows.Forms.CheckBox chbParadicsom;
        private System.Windows.Forms.Button btMegrendeles;
        private System.Windows.Forms.Label lbOsszeg;
    }
}

