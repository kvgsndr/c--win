namespace szinkeverő
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
            this.scbRed = new System.Windows.Forms.HScrollBar();
            this.scbBlue = new System.Windows.Forms.HScrollBar();
            this.scbGreen = new System.Windows.Forms.HScrollBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.scbSzéles = new System.Windows.Forms.HScrollBar();
            this.scbMagas = new System.Windows.Forms.VScrollBar();
            this.lbSzin = new System.Windows.Forms.Label();
            this.lbVörös = new System.Windows.Forms.Label();
            this.lbZöld = new System.Windows.Forms.Label();
            this.lbKék = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vörös";
            // 
            // scbRed
            // 
            this.scbRed.Location = new System.Drawing.Point(162, 233);
            this.scbRed.Maximum = 264;
            this.scbRed.Name = "scbRed";
            this.scbRed.Size = new System.Drawing.Size(174, 17);
            this.scbRed.TabIndex = 1;
            this.scbRed.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // scbBlue
            // 
            this.scbBlue.Location = new System.Drawing.Point(162, 288);
            this.scbBlue.Maximum = 264;
            this.scbBlue.Name = "scbBlue";
            this.scbBlue.Size = new System.Drawing.Size(174, 17);
            this.scbBlue.TabIndex = 2;
            this.scbBlue.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // scbGreen
            // 
            this.scbGreen.Location = new System.Drawing.Point(162, 260);
            this.scbGreen.Maximum = 264;
            this.scbGreen.Name = "scbGreen";
            this.scbGreen.Size = new System.Drawing.Size(174, 17);
            this.scbGreen.TabIndex = 3;
            this.scbGreen.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Zöld";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kék";
            // 
            // scbSzéles
            // 
            this.scbSzéles.Location = new System.Drawing.Point(35, 19);
            this.scbSzéles.Name = "scbSzéles";
            this.scbSzéles.Size = new System.Drawing.Size(390, 19);
            this.scbSzéles.TabIndex = 6;
            this.scbSzéles.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scbSzéles_Scroll);
            // 
            // scbMagas
            // 
            this.scbMagas.Location = new System.Drawing.Point(423, 60);
            this.scbMagas.Name = "scbMagas";
            this.scbMagas.Size = new System.Drawing.Size(17, 153);
            this.scbMagas.TabIndex = 7;
            this.scbMagas.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // lbSzin
            // 
            this.lbSzin.BackColor = System.Drawing.SystemColors.Highlight;
            this.lbSzin.Location = new System.Drawing.Point(50, 60);
            this.lbSzin.Name = "lbSzin";
            this.lbSzin.Size = new System.Drawing.Size(131, 85);
            this.lbSzin.TabIndex = 8;
            // 
            // lbVörös
            // 
            this.lbVörös.AutoSize = true;
            this.lbVörös.Location = new System.Drawing.Point(365, 233);
            this.lbVörös.Name = "lbVörös";
            this.lbVörös.Size = new System.Drawing.Size(35, 13);
            this.lbVörös.TabIndex = 9;
            this.lbVörös.Text = "label5";
            // 
            // lbZöld
            // 
            this.lbZöld.AutoSize = true;
            this.lbZöld.Location = new System.Drawing.Point(365, 264);
            this.lbZöld.Name = "lbZöld";
            this.lbZöld.Size = new System.Drawing.Size(35, 13);
            this.lbZöld.TabIndex = 10;
            this.lbZöld.Text = "label6";
            // 
            // lbKék
            // 
            this.lbKék.AutoSize = true;
            this.lbKék.Location = new System.Drawing.Point(365, 292);
            this.lbKék.Name = "lbKék";
            this.lbKék.Size = new System.Drawing.Size(35, 13);
            this.lbKék.TabIndex = 11;
            this.lbKék.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(187, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "label8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(106, 160);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "label9";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 327);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbKék);
            this.Controls.Add(this.lbZöld);
            this.Controls.Add(this.lbVörös);
            this.Controls.Add(this.lbSzin);
            this.Controls.Add(this.scbMagas);
            this.Controls.Add(this.scbSzéles);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.scbGreen);
            this.Controls.Add(this.scbBlue);
            this.Controls.Add(this.scbRed);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.HScrollBar scbRed;
        private System.Windows.Forms.HScrollBar scbBlue;
        private System.Windows.Forms.HScrollBar scbGreen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.HScrollBar scbSzéles;
        private System.Windows.Forms.VScrollBar scbMagas;
        private System.Windows.Forms.Label lbSzin;
        private System.Windows.Forms.Label lbVörös;
        private System.Windows.Forms.Label lbZöld;
        private System.Windows.Forms.Label lbKék;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

