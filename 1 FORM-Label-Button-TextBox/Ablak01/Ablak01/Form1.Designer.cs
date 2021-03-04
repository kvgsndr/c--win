namespace Ablak01
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
            this.kilepesBtn = new System.Windows.Forms.Button();
            this.pirosBtn = new System.Windows.Forms.Button();
            this.zoldBtn = new System.Windows.Forms.Button();
            this.szinezBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kilepesBtn
            // 
            this.kilepesBtn.Location = new System.Drawing.Point(437, 395);
            this.kilepesBtn.Name = "kilepesBtn";
            this.kilepesBtn.Size = new System.Drawing.Size(75, 23);
            this.kilepesBtn.TabIndex = 0;
            this.kilepesBtn.Text = "Kilépés";
            this.kilepesBtn.UseVisualStyleBackColor = true;
            this.kilepesBtn.Click += new System.EventHandler(this.kilepesBtn_Click);
            // 
            // pirosBtn
            // 
            this.pirosBtn.Location = new System.Drawing.Point(118, 88);
            this.pirosBtn.Name = "pirosBtn";
            this.pirosBtn.Size = new System.Drawing.Size(75, 23);
            this.pirosBtn.TabIndex = 1;
            this.pirosBtn.Text = "Piros";
            this.pirosBtn.UseVisualStyleBackColor = true;
            this.pirosBtn.Click += new System.EventHandler(this.pirosBtn_Click);
            // 
            // zoldBtn
            // 
            this.zoldBtn.Location = new System.Drawing.Point(235, 88);
            this.zoldBtn.Name = "zoldBtn";
            this.zoldBtn.Size = new System.Drawing.Size(75, 23);
            this.zoldBtn.TabIndex = 2;
            this.zoldBtn.Text = "Zöld";
            this.zoldBtn.UseVisualStyleBackColor = true;
            this.zoldBtn.Click += new System.EventHandler(this.zoldBtn_Click);
            // 
            // szinezBtn
            // 
            this.szinezBtn.Location = new System.Drawing.Point(402, 88);
            this.szinezBtn.Name = "szinezBtn";
            this.szinezBtn.Size = new System.Drawing.Size(75, 23);
            this.szinezBtn.TabIndex = 3;
            this.szinezBtn.Text = "Háttérszín";
            this.szinezBtn.UseVisualStyleBackColor = true;
            this.szinezBtn.Click += new System.EventHandler(this.szinezBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 449);
            this.Controls.Add(this.szinezBtn);
            this.Controls.Add(this.zoldBtn);
            this.Controls.Add(this.pirosBtn);
            this.Controls.Add(this.kilepesBtn);
            this.Name = "Form1";
            this.Text = "Első C# probálkozás";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button kilepesBtn;
        private System.Windows.Forms.Button pirosBtn;
        private System.Windows.Forms.Button zoldBtn;
        private System.Windows.Forms.Button szinezBtn;
    }
}

