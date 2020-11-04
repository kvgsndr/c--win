namespace SzerkeszthetoHaromszog
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
            this.aLbl = new System.Windows.Forms.Label();
            this.bLbl = new System.Windows.Forms.Label();
            this.cLbl = new System.Windows.Forms.Label();
            this.aTxt = new System.Windows.Forms.TextBox();
            this.bTxt = new System.Windows.Forms.TextBox();
            this.cTxt = new System.Windows.Forms.TextBox();
            this.ellenorBtn = new System.Windows.Forms.Button();
            this.kileoBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // aLbl
            // 
            this.aLbl.AutoSize = true;
            this.aLbl.Location = new System.Drawing.Point(43, 38);
            this.aLbl.Name = "aLbl";
            this.aLbl.Size = new System.Drawing.Size(80, 13);
            this.aLbl.TabIndex = 0;
            this.aLbl.Text = "a oldal hossza: ";
            // 
            // bLbl
            // 
            this.bLbl.AutoSize = true;
            this.bLbl.Location = new System.Drawing.Point(43, 72);
            this.bLbl.Name = "bLbl";
            this.bLbl.Size = new System.Drawing.Size(80, 13);
            this.bLbl.TabIndex = 1;
            this.bLbl.Text = "b oldal hossza: ";
            // 
            // cLbl
            // 
            this.cLbl.AutoSize = true;
            this.cLbl.Location = new System.Drawing.Point(43, 113);
            this.cLbl.Name = "cLbl";
            this.cLbl.Size = new System.Drawing.Size(80, 13);
            this.cLbl.TabIndex = 2;
            this.cLbl.Text = "c oldal hossza: ";
            // 
            // aTxt
            // 
            this.aTxt.Location = new System.Drawing.Point(143, 30);
            this.aTxt.Name = "aTxt";
            this.aTxt.Size = new System.Drawing.Size(100, 20);
            this.aTxt.TabIndex = 3;
            // 
            // bTxt
            // 
            this.bTxt.Location = new System.Drawing.Point(143, 64);
            this.bTxt.Name = "bTxt";
            this.bTxt.Size = new System.Drawing.Size(100, 20);
            this.bTxt.TabIndex = 4;
            // 
            // cTxt
            // 
            this.cTxt.Location = new System.Drawing.Point(143, 105);
            this.cTxt.Name = "cTxt";
            this.cTxt.Size = new System.Drawing.Size(100, 20);
            this.cTxt.TabIndex = 5;
            // 
            // ellenorBtn
            // 
            this.ellenorBtn.Location = new System.Drawing.Point(109, 154);
            this.ellenorBtn.Name = "ellenorBtn";
            this.ellenorBtn.Size = new System.Drawing.Size(75, 23);
            this.ellenorBtn.TabIndex = 6;
            this.ellenorBtn.Text = "Ellenőrzés";
            this.ellenorBtn.UseVisualStyleBackColor = true;
            this.ellenorBtn.Click += new System.EventHandler(this.ellenorBtn_Click);
            // 
            // kileoBtn
            // 
            this.kileoBtn.Location = new System.Drawing.Point(597, 226);
            this.kileoBtn.Name = "kileoBtn";
            this.kileoBtn.Size = new System.Drawing.Size(75, 23);
            this.kileoBtn.TabIndex = 7;
            this.kileoBtn.Text = "Kilépés";
            this.kileoBtn.UseVisualStyleBackColor = true;
            this.kileoBtn.Click += new System.EventHandler(this.kileoBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(371, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 261);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.kileoBtn);
            this.Controls.Add(this.ellenorBtn);
            this.Controls.Add(this.cTxt);
            this.Controls.Add(this.bTxt);
            this.Controls.Add(this.aTxt);
            this.Controls.Add(this.cLbl);
            this.Controls.Add(this.bLbl);
            this.Controls.Add(this.aLbl);
            this.Name = "Form1";
            this.Text = "Szerkeszthető-e háromszög";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label aLbl;
        private System.Windows.Forms.Label bLbl;
        private System.Windows.Forms.Label cLbl;
        private System.Windows.Forms.TextBox aTxt;
        private System.Windows.Forms.TextBox bTxt;
        private System.Windows.Forms.TextBox cTxt;
        private System.Windows.Forms.Button ellenorBtn;
        private System.Windows.Forms.Button kileoBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

