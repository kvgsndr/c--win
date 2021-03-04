namespace Testtomeg
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
            this.cmLbl = new System.Windows.Forms.Label();
            this.cmTxt = new System.Windows.Forms.TextBox();
            this.kgLbl = new System.Windows.Forms.Label();
            this.kgTxt = new System.Windows.Forms.TextBox();
            this.szamolBtn = new System.Windows.Forms.Button();
            this.kilepBtn = new System.Windows.Forms.Button();
            this.valaszTxt = new System.Windows.Forms.TextBox();
            this.hosszuTxt = new System.Windows.Forms.RichTextBox();
            this.ffiChk = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.kepPBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kepPBox)).BeginInit();
            this.SuspendLayout();
            // 
            // cmLbl
            // 
            this.cmLbl.AutoSize = true;
            this.cmLbl.Location = new System.Drawing.Point(26, 38);
            this.cmLbl.Name = "cmLbl";
            this.cmLbl.Size = new System.Drawing.Size(85, 13);
            this.cmLbl.TabIndex = 0;
            this.cmLbl.Text = "Magasság (cm): ";
            // 
            // cmTxt
            // 
            this.cmTxt.Location = new System.Drawing.Point(132, 30);
            this.cmTxt.Name = "cmTxt";
            this.cmTxt.Size = new System.Drawing.Size(100, 20);
            this.cmTxt.TabIndex = 1;
            // 
            // kgLbl
            // 
            this.kgLbl.AutoSize = true;
            this.kgLbl.Location = new System.Drawing.Point(26, 77);
            this.kgLbl.Name = "kgLbl";
            this.kgLbl.Size = new System.Drawing.Size(84, 13);
            this.kgLbl.TabIndex = 2;
            this.kgLbl.Text = "Testtömeg (kg): ";
            // 
            // kgTxt
            // 
            this.kgTxt.Location = new System.Drawing.Point(132, 70);
            this.kgTxt.Name = "kgTxt";
            this.kgTxt.Size = new System.Drawing.Size(100, 20);
            this.kgTxt.TabIndex = 3;
            // 
            // szamolBtn
            // 
            this.szamolBtn.Location = new System.Drawing.Point(304, 106);
            this.szamolBtn.Name = "szamolBtn";
            this.szamolBtn.Size = new System.Drawing.Size(75, 23);
            this.szamolBtn.TabIndex = 4;
            this.szamolBtn.Text = "Számol";
            this.szamolBtn.UseVisualStyleBackColor = true;
            this.szamolBtn.Click += new System.EventHandler(this.szamolBtn_Click);
            // 
            // kilepBtn
            // 
            this.kilepBtn.Location = new System.Drawing.Point(618, 406);
            this.kilepBtn.Name = "kilepBtn";
            this.kilepBtn.Size = new System.Drawing.Size(75, 23);
            this.kilepBtn.TabIndex = 5;
            this.kilepBtn.Text = "Kilépés";
            this.kilepBtn.UseVisualStyleBackColor = true;
            this.kilepBtn.Click += new System.EventHandler(this.kilepBtn_Click);
            // 
            // valaszTxt
            // 
            this.valaszTxt.Location = new System.Drawing.Point(29, 159);
            this.valaszTxt.Name = "valaszTxt";
            this.valaszTxt.ReadOnly = true;
            this.valaszTxt.Size = new System.Drawing.Size(203, 20);
            this.valaszTxt.TabIndex = 6;
            this.valaszTxt.Visible = false;
            // 
            // hosszuTxt
            // 
            this.hosszuTxt.Location = new System.Drawing.Point(29, 215);
            this.hosszuTxt.Name = "hosszuTxt";
            this.hosszuTxt.ReadOnly = true;
            this.hosszuTxt.Size = new System.Drawing.Size(350, 128);
            this.hosszuTxt.TabIndex = 7;
            this.hosszuTxt.Text = "";
            this.hosszuTxt.Visible = false;
            // 
            // ffiChk
            // 
            this.ffiChk.AutoSize = true;
            this.ffiChk.Checked = true;
            this.ffiChk.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ffiChk.Location = new System.Drawing.Point(132, 112);
            this.ffiChk.Name = "ffiChk";
            this.ffiChk.Size = new System.Drawing.Size(46, 17);
            this.ffiChk.TabIndex = 9;
            this.ffiChk.Text = "Férfi";
            this.ffiChk.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Testtomeg.Properties.Resources.images;
            this.pictureBox1.Location = new System.Drawing.Point(446, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(247, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // kepPBox
            // 
            this.kepPBox.Location = new System.Drawing.Point(446, 215);
            this.kepPBox.Name = "kepPBox";
            this.kepPBox.Size = new System.Drawing.Size(247, 185);
            this.kepPBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kepPBox.TabIndex = 11;
            this.kepPBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 441);
            this.Controls.Add(this.kepPBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ffiChk);
            this.Controls.Add(this.hosszuTxt);
            this.Controls.Add(this.valaszTxt);
            this.Controls.Add(this.kilepBtn);
            this.Controls.Add(this.szamolBtn);
            this.Controls.Add(this.kgTxt);
            this.Controls.Add(this.kgLbl);
            this.Controls.Add(this.cmTxt);
            this.Controls.Add(this.cmLbl);
            this.Name = "Form1";
            this.Text = "Testtömegindex";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kepPBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cmLbl;
        private System.Windows.Forms.TextBox cmTxt;
        private System.Windows.Forms.Label kgLbl;
        private System.Windows.Forms.TextBox kgTxt;
        private System.Windows.Forms.Button szamolBtn;
        private System.Windows.Forms.Button kilepBtn;
        private System.Windows.Forms.TextBox valaszTxt;
        private System.Windows.Forms.RichTextBox hosszuTxt;
        private System.Windows.Forms.CheckBox ffiChk;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox kepPBox;
    }
}

