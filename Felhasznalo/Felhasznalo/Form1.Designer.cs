namespace Felhasznalo
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
            this.vnevLbl = new System.Windows.Forms.Label();
            this.knevLbl = new System.Windows.Forms.Label();
            this.vnevTxt = new System.Windows.Forms.TextBox();
            this.knevTxt = new System.Windows.Forms.TextBox();
            this.fnevBtn = new System.Windows.Forms.Button();
            this.kilepBtn = new System.Windows.Forms.Button();
            this.fnevLbl = new System.Windows.Forms.Label();
            this.fnevTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // vnevLbl
            // 
            this.vnevLbl.AutoSize = true;
            this.vnevLbl.Location = new System.Drawing.Point(25, 40);
            this.vnevLbl.Name = "vnevLbl";
            this.vnevLbl.Size = new System.Drawing.Size(70, 13);
            this.vnevLbl.TabIndex = 0;
            this.vnevLbl.Text = "Vezetéknév: ";
            // 
            // knevLbl
            // 
            this.knevLbl.AutoSize = true;
            this.knevLbl.Location = new System.Drawing.Point(28, 71);
            this.knevLbl.Name = "knevLbl";
            this.knevLbl.Size = new System.Drawing.Size(66, 13);
            this.knevLbl.TabIndex = 1;
            this.knevLbl.Text = "Keresztnév: ";
            // 
            // vnevTxt
            // 
            this.vnevTxt.Location = new System.Drawing.Point(139, 32);
            this.vnevTxt.Name = "vnevTxt";
            this.vnevTxt.Size = new System.Drawing.Size(100, 20);
            this.vnevTxt.TabIndex = 2;
            // 
            // knevTxt
            // 
            this.knevTxt.Location = new System.Drawing.Point(139, 63);
            this.knevTxt.Name = "knevTxt";
            this.knevTxt.Size = new System.Drawing.Size(100, 20);
            this.knevTxt.TabIndex = 3;
            // 
            // fnevBtn
            // 
            this.fnevBtn.Location = new System.Drawing.Point(60, 110);
            this.fnevBtn.Name = "fnevBtn";
            this.fnevBtn.Size = new System.Drawing.Size(160, 23);
            this.fnevBtn.TabIndex = 4;
            this.fnevBtn.Text = "Felhasználónév generálása";
            this.fnevBtn.UseVisualStyleBackColor = true;
            this.fnevBtn.Click += new System.EventHandler(this.fnevBtn_Click);
            // 
            // kilepBtn
            // 
            this.kilepBtn.Location = new System.Drawing.Point(184, 216);
            this.kilepBtn.Name = "kilepBtn";
            this.kilepBtn.Size = new System.Drawing.Size(75, 23);
            this.kilepBtn.TabIndex = 5;
            this.kilepBtn.Text = "Kilépés";
            this.kilepBtn.UseVisualStyleBackColor = true;
            this.kilepBtn.Click += new System.EventHandler(this.kilepBtn_Click);
            // 
            // fnevLbl
            // 
            this.fnevLbl.AutoSize = true;
            this.fnevLbl.Location = new System.Drawing.Point(28, 166);
            this.fnevLbl.Name = "fnevLbl";
            this.fnevLbl.Size = new System.Drawing.Size(87, 13);
            this.fnevLbl.TabIndex = 6;
            this.fnevLbl.Text = "Felhasználónév: ";
            this.fnevLbl.Visible = false;
            // 
            // fnevTxt
            // 
            this.fnevTxt.Enabled = false;
            this.fnevTxt.Location = new System.Drawing.Point(139, 158);
            this.fnevTxt.Name = "fnevTxt";
            this.fnevTxt.Size = new System.Drawing.Size(100, 20);
            this.fnevTxt.TabIndex = 7;
            this.fnevTxt.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.fnevTxt);
            this.Controls.Add(this.fnevLbl);
            this.Controls.Add(this.kilepBtn);
            this.Controls.Add(this.fnevBtn);
            this.Controls.Add(this.knevTxt);
            this.Controls.Add(this.vnevTxt);
            this.Controls.Add(this.knevLbl);
            this.Controls.Add(this.vnevLbl);
            this.Name = "Form1";
            this.Text = "Felhasználó";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label vnevLbl;
        private System.Windows.Forms.Label knevLbl;
        private System.Windows.Forms.TextBox vnevTxt;
        private System.Windows.Forms.TextBox knevTxt;
        private System.Windows.Forms.Button fnevBtn;
        private System.Windows.Forms.Button kilepBtn;
        private System.Windows.Forms.Label fnevLbl;
        private System.Windows.Forms.TextBox fnevTxt;
    }
}

