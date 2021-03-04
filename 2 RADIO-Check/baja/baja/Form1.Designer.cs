namespace baja
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.mutatBtn = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.kilepBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(21, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(380, 270);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(426, 92);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(69, 17);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Régi fotó";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // mutatBtn
            // 
            this.mutatBtn.Location = new System.Drawing.Point(426, 131);
            this.mutatBtn.Name = "mutatBtn";
            this.mutatBtn.Size = new System.Drawing.Size(75, 23);
            this.mutatBtn.TabIndex = 2;
            this.mutatBtn.Text = "Mutat";
            this.mutatBtn.UseVisualStyleBackColor = true;
            this.mutatBtn.Click += new System.EventHandler(this.mutatBtn_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Location = new System.Drawing.Point(21, 13);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(380, 63);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "Baja város Magyarország déli részén, a Duna bal partján. Bács-Kiskun megye másodi" +
    "k legnagyobb települése, a Bajai járás központja. Jelentős dunai kikötő és közle" +
    "kedési csomópont.";
            // 
            // kilepBtn
            // 
            this.kilepBtn.Location = new System.Drawing.Point(489, 339);
            this.kilepBtn.Name = "kilepBtn";
            this.kilepBtn.Size = new System.Drawing.Size(75, 23);
            this.kilepBtn.TabIndex = 4;
            this.kilepBtn.Text = "Kilépés";
            this.kilepBtn.UseVisualStyleBackColor = true;
            this.kilepBtn.Click += new System.EventHandler(this.kilepBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 374);
            this.Controls.Add(this.kilepBtn);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.mutatBtn);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Baja";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button mutatBtn;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button kilepBtn;
    }
}

