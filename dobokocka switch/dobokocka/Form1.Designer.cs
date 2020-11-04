namespace dobokocka
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
            this.dobasBtn = new System.Windows.Forms.Button();
            this.kilepBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dobasBtn
            // 
            this.dobasBtn.Location = new System.Drawing.Point(90, 245);
            this.dobasBtn.Margin = new System.Windows.Forms.Padding(2);
            this.dobasBtn.Name = "dobasBtn";
            this.dobasBtn.Size = new System.Drawing.Size(63, 28);
            this.dobasBtn.TabIndex = 0;
            this.dobasBtn.Text = "Dobj!";
            this.dobasBtn.UseVisualStyleBackColor = true;
            this.dobasBtn.Click += new System.EventHandler(this.dobasBtn_Click);
            // 
            // kilepBtn
            // 
            this.kilepBtn.Location = new System.Drawing.Point(207, 301);
            this.kilepBtn.Margin = new System.Windows.Forms.Padding(2);
            this.kilepBtn.Name = "kilepBtn";
            this.kilepBtn.Size = new System.Drawing.Size(62, 29);
            this.kilepBtn.TabIndex = 1;
            this.kilepBtn.Text = "Kilépés";
            this.kilepBtn.UseVisualStyleBackColor = true;
            this.kilepBtn.Click += new System.EventHandler(this.kilepBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(59, 63);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 145);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 354);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.kilepBtn);
            this.Controls.Add(this.dobasBtn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Dobókocka";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button dobasBtn;
        private System.Windows.Forms.Button kilepBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

