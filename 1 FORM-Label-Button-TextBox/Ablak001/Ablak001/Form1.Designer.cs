namespace Ablak001
{
    partial class ablakForm
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
            this.kilepBtn = new System.Windows.Forms.Button();
            this.aquaBtn = new System.Windows.Forms.Button();
            this.redBtn = new System.Windows.Forms.Button();
            this.szinezBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kilepBtn
            // 
            this.kilepBtn.Location = new System.Drawing.Point(578, 443);
            this.kilepBtn.Name = "kilepBtn";
            this.kilepBtn.Size = new System.Drawing.Size(75, 23);
            this.kilepBtn.TabIndex = 0;
            this.kilepBtn.Text = "Kilépés";
            this.kilepBtn.UseVisualStyleBackColor = true;
            this.kilepBtn.Click += new System.EventHandler(this.kilepBtn_Click);
            // 
            // aquaBtn
            // 
            this.aquaBtn.Location = new System.Drawing.Point(143, 136);
            this.aquaBtn.Name = "aquaBtn";
            this.aquaBtn.Size = new System.Drawing.Size(75, 23);
            this.aquaBtn.TabIndex = 1;
            this.aquaBtn.Text = "Aqua";
            this.aquaBtn.UseVisualStyleBackColor = true;
            this.aquaBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // redBtn
            // 
            this.redBtn.Location = new System.Drawing.Point(291, 136);
            this.redBtn.Name = "redBtn";
            this.redBtn.Size = new System.Drawing.Size(75, 23);
            this.redBtn.TabIndex = 2;
            this.redBtn.Text = "Red";
            this.redBtn.UseVisualStyleBackColor = true;
            this.redBtn.Click += new System.EventHandler(this.redBtn_Click);
            // 
            // szinezBtn
            // 
            this.szinezBtn.Location = new System.Drawing.Point(500, 135);
            this.szinezBtn.Name = "szinezBtn";
            this.szinezBtn.Size = new System.Drawing.Size(75, 23);
            this.szinezBtn.TabIndex = 3;
            this.szinezBtn.Text = "Szinez";
            this.szinezBtn.UseVisualStyleBackColor = true;
            this.szinezBtn.Click += new System.EventHandler(this.szinezBtn_Click);
            // 
            // ablakForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 490);
            this.Controls.Add(this.szinezBtn);
            this.Controls.Add(this.redBtn);
            this.Controls.Add(this.aquaBtn);
            this.Controls.Add(this.kilepBtn);
            this.Name = "ablakForm";
            this.Text = "Első C# ablakom";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button kilepBtn;
        private System.Windows.Forms.Button aquaBtn;
        private System.Windows.Forms.Button redBtn;
        private System.Windows.Forms.Button szinezBtn;
    }
}

