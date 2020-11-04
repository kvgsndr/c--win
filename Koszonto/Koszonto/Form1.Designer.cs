namespace Koszonto
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
            this.nevTxt = new System.Windows.Forms.TextBox();
            this.kilepBtn = new System.Windows.Forms.Button();
            this.nevLbl = new System.Windows.Forms.Label();
            this.keszBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nevTxt
            // 
            this.nevTxt.Location = new System.Drawing.Point(132, 42);
            this.nevTxt.Name = "nevTxt";
            this.nevTxt.Size = new System.Drawing.Size(100, 20);
            this.nevTxt.TabIndex = 0;
            // 
            // kilepBtn
            // 
            this.kilepBtn.Location = new System.Drawing.Point(183, 216);
            this.kilepBtn.Name = "kilepBtn";
            this.kilepBtn.Size = new System.Drawing.Size(75, 23);
            this.kilepBtn.TabIndex = 1;
            this.kilepBtn.Text = "Kilépés";
            this.kilepBtn.UseVisualStyleBackColor = true;
            this.kilepBtn.Click += new System.EventHandler(this.kilepBtn_Click);
            // 
            // nevLbl
            // 
            this.nevLbl.AutoSize = true;
            this.nevLbl.Location = new System.Drawing.Point(30, 48);
            this.nevLbl.Name = "nevLbl";
            this.nevLbl.Size = new System.Drawing.Size(30, 13);
            this.nevLbl.TabIndex = 2;
            this.nevLbl.Text = "Név:";
            // 
            // keszBtn
            // 
            this.keszBtn.Location = new System.Drawing.Point(108, 91);
            this.keszBtn.Name = "keszBtn";
            this.keszBtn.Size = new System.Drawing.Size(75, 23);
            this.keszBtn.TabIndex = 3;
            this.keszBtn.Text = "Kész";
            this.keszBtn.UseVisualStyleBackColor = true;
            this.keszBtn.Click += new System.EventHandler(this.keszBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.keszBtn);
            this.Controls.Add(this.nevLbl);
            this.Controls.Add(this.kilepBtn);
            this.Controls.Add(this.nevTxt);
            this.Name = "Form1";
            this.Text = "Köszöntő";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nevTxt;
        private System.Windows.Forms.Button kilepBtn;
        private System.Windows.Forms.Label nevLbl;
        private System.Windows.Forms.Button keszBtn;
    }
}

