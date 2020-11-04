namespace WindowsFormsApp2
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
            this.gombBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gombBtn
            // 
            this.gombBtn.Location = new System.Drawing.Point(33, 21);
            this.gombBtn.Name = "gombBtn";
            this.gombBtn.Size = new System.Drawing.Size(30, 30);
            this.gombBtn.TabIndex = 0;
            this.gombBtn.Text = "G";
            this.gombBtn.UseVisualStyleBackColor = true;
            this.gombBtn.Click += new System.EventHandler(this.gombBtn_Click);
            this.gombBtn.MouseEnter += new System.EventHandler(this.gombBtn_MouseEnter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(482, 253);
            this.Controls.Add(this.gombBtn);
            this.Name = "Form1";
            this.Text = "Első ablak";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button gombBtn;
    }
}

