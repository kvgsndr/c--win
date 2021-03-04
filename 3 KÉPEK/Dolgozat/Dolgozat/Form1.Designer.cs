namespace Dolgozat
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
            this.szazalekTxt = new System.Windows.Forms.TextBox();
            this.kilepBtn = new System.Windows.Forms.Button();
            this.ertekelBtn = new System.Windows.Forms.Button();
            this.jegyLbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add meg a teljesítményt %-ban: ";
            // 
            // szazalekTxt
            // 
            this.szazalekTxt.Location = new System.Drawing.Point(176, 27);
            this.szazalekTxt.Name = "szazalekTxt";
            this.szazalekTxt.Size = new System.Drawing.Size(100, 20);
            this.szazalekTxt.TabIndex = 2;
            // 
            // kilepBtn
            // 
            this.kilepBtn.Location = new System.Drawing.Point(186, 222);
            this.kilepBtn.Name = "kilepBtn";
            this.kilepBtn.Size = new System.Drawing.Size(75, 23);
            this.kilepBtn.TabIndex = 3;
            this.kilepBtn.Text = "Kilépés";
            this.kilepBtn.UseVisualStyleBackColor = true;
            this.kilepBtn.Click += new System.EventHandler(this.kilepBtn_Click);
            // 
            // ertekelBtn
            // 
            this.ertekelBtn.Location = new System.Drawing.Point(95, 75);
            this.ertekelBtn.Name = "ertekelBtn";
            this.ertekelBtn.Size = new System.Drawing.Size(75, 23);
            this.ertekelBtn.TabIndex = 4;
            this.ertekelBtn.Text = "Értékel";
            this.ertekelBtn.UseVisualStyleBackColor = true;
            this.ertekelBtn.Click += new System.EventHandler(this.ertekelBtn_Click);
            // 
            // jegyLbl
            // 
            this.jegyLbl.AutoSize = true;
            this.jegyLbl.Location = new System.Drawing.Point(12, 112);
            this.jegyLbl.Name = "jegyLbl";
            this.jegyLbl.Size = new System.Drawing.Size(26, 13);
            this.jegyLbl.TabIndex = 5;
            this.jegyLbl.Text = "jegy";
            this.jegyLbl.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(52, 142);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.jegyLbl);
            this.Controls.Add(this.ertekelBtn);
            this.Controls.Add(this.kilepBtn);
            this.Controls.Add(this.szazalekTxt);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Dolgozat értékelése";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox szazalekTxt;
        private System.Windows.Forms.Button kilepBtn;
        private System.Windows.Forms.Button ertekelBtn;
        private System.Windows.Forms.Label jegyLbl;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

