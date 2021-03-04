namespace ÉvHóNapÓraPerc
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
            this.chbEv = new System.Windows.Forms.CheckBox();
            this.chbHo = new System.Windows.Forms.CheckBox();
            this.chbNap = new System.Windows.Forms.CheckBox();
            this.chbOra = new System.Windows.Forms.CheckBox();
            this.chbPerc = new System.Windows.Forms.CheckBox();
            this.chbMperc = new System.Windows.Forms.CheckBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btOK = new System.Windows.Forms.Button();
            this.btTorol = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chbEv
            // 
            this.chbEv.AutoSize = true;
            this.chbEv.Location = new System.Drawing.Point(43, 51);
            this.chbEv.Name = "chbEv";
            this.chbEv.Size = new System.Drawing.Size(39, 17);
            this.chbEv.TabIndex = 0;
            this.chbEv.Text = "Év";
            this.chbEv.UseVisualStyleBackColor = true;
            // 
            // chbHo
            // 
            this.chbHo.AutoSize = true;
            this.chbHo.Location = new System.Drawing.Point(43, 91);
            this.chbHo.Name = "chbHo";
            this.chbHo.Size = new System.Drawing.Size(58, 17);
            this.chbHo.TabIndex = 1;
            this.chbHo.Text = "Hónap";
            this.chbHo.UseVisualStyleBackColor = true;
            // 
            // chbNap
            // 
            this.chbNap.AutoSize = true;
            this.chbNap.Location = new System.Drawing.Point(43, 134);
            this.chbNap.Name = "chbNap";
            this.chbNap.Size = new System.Drawing.Size(46, 17);
            this.chbNap.TabIndex = 2;
            this.chbNap.Text = "Nap";
            this.chbNap.UseVisualStyleBackColor = true;
            // 
            // chbOra
            // 
            this.chbOra.AutoSize = true;
            this.chbOra.Location = new System.Drawing.Point(43, 178);
            this.chbOra.Name = "chbOra";
            this.chbOra.Size = new System.Drawing.Size(43, 17);
            this.chbOra.TabIndex = 3;
            this.chbOra.Text = "Óra";
            this.chbOra.UseVisualStyleBackColor = true;
            // 
            // chbPerc
            // 
            this.chbPerc.AutoSize = true;
            this.chbPerc.Location = new System.Drawing.Point(43, 219);
            this.chbPerc.Name = "chbPerc";
            this.chbPerc.Size = new System.Drawing.Size(48, 17);
            this.chbPerc.TabIndex = 4;
            this.chbPerc.Text = "Perc";
            this.chbPerc.UseVisualStyleBackColor = true;
            // 
            // chbMperc
            // 
            this.chbMperc.AutoSize = true;
            this.chbMperc.Location = new System.Drawing.Point(43, 262);
            this.chbMperc.Name = "chbMperc";
            this.chbMperc.Size = new System.Drawing.Size(55, 17);
            this.chbMperc.TabIndex = 5;
            this.chbMperc.Text = "mperc";
            this.chbMperc.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(160, 54);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(200, 225);
            this.listBox1.TabIndex = 6;
            // 
            // btOK
            // 
            this.btOK.Location = new System.Drawing.Point(43, 301);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(75, 23);
            this.btOK.TabIndex = 7;
            this.btOK.Text = "Ok";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // btTorol
            // 
            this.btTorol.Location = new System.Drawing.Point(213, 301);
            this.btTorol.Name = "btTorol";
            this.btTorol.Size = new System.Drawing.Size(75, 23);
            this.btTorol.TabIndex = 8;
            this.btTorol.Text = "Töröl";
            this.btTorol.UseVisualStyleBackColor = true;
            this.btTorol.Click += new System.EventHandler(this.btTorol_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Most: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 357);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btTorol);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.chbMperc);
            this.Controls.Add(this.chbPerc);
            this.Controls.Add(this.chbOra);
            this.Controls.Add(this.chbNap);
            this.Controls.Add(this.chbHo);
            this.Controls.Add(this.chbEv);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chbEv;
        private System.Windows.Forms.CheckBox chbHo;
        private System.Windows.Forms.CheckBox chbNap;
        private System.Windows.Forms.CheckBox chbOra;
        private System.Windows.Forms.CheckBox chbPerc;
        private System.Windows.Forms.CheckBox chbMperc;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.Button btTorol;
        private System.Windows.Forms.Label label1;
    }
}

