namespace Véralkohol
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ellenorBtn = new System.Windows.Forms.Button();
            this.kilepBtn = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.kiirLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add meg a mért véralkohol szintet (ezrelék): ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(254, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // ellenorBtn
            // 
            this.ellenorBtn.Location = new System.Drawing.Point(181, 87);
            this.ellenorBtn.Name = "ellenorBtn";
            this.ellenorBtn.Size = new System.Drawing.Size(75, 23);
            this.ellenorBtn.TabIndex = 2;
            this.ellenorBtn.Text = "Ellenőrzés";
            this.ellenorBtn.UseVisualStyleBackColor = true;
            this.ellenorBtn.Click += new System.EventHandler(this.ellenorBtn_Click);
            // 
            // kilepBtn
            // 
            this.kilepBtn.Location = new System.Drawing.Point(384, 213);
            this.kilepBtn.Name = "kilepBtn";
            this.kilepBtn.Size = new System.Drawing.Size(75, 23);
            this.kilepBtn.TabIndex = 3;
            this.kilepBtn.Text = "Kilépés";
            this.kilepBtn.UseVisualStyleBackColor = true;
            this.kilepBtn.Click += new System.EventHandler(this.kilepBtn_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(61, 155);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 4;
            this.progressBar1.Visible = false;
            // 
            // kiirLbl
            // 
            this.kiirLbl.AutoSize = true;
            this.kiirLbl.Location = new System.Drawing.Point(182, 164);
            this.kiirLbl.Name = "kiirLbl";
            this.kiirLbl.Size = new System.Drawing.Size(37, 13);
            this.kiirLbl.TabIndex = 5;
            this.kiirLbl.Text = "válasz";
            this.kiirLbl.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 261);
            this.Controls.Add(this.kiirLbl);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.kilepBtn);
            this.Controls.Add(this.ellenorBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Véralkoholszint";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button ellenorBtn;
        private System.Windows.Forms.Button kilepBtn;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label kiirLbl;
    }
}

