namespace Teglalap
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
            this.kilepBtn = new System.Windows.Forms.Button();
            this.aLbl = new System.Windows.Forms.Label();
            this.bLbl = new System.Windows.Forms.Label();
            this.terLbl = new System.Windows.Forms.Label();
            this.kerLbl = new System.Windows.Forms.Label();
            this.aTxt = new System.Windows.Forms.TextBox();
            this.bTxt = new System.Windows.Forms.TextBox();
            this.szamolBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kilepBtn
            // 
            this.kilepBtn.Location = new System.Drawing.Point(196, 213);
            this.kilepBtn.Name = "kilepBtn";
            this.kilepBtn.Size = new System.Drawing.Size(75, 23);
            this.kilepBtn.TabIndex = 0;
            this.kilepBtn.Text = "Kilépés";
            this.kilepBtn.UseVisualStyleBackColor = true;
            this.kilepBtn.Click += new System.EventHandler(this.kilepBtn_Click);
            // 
            // aLbl
            // 
            this.aLbl.AutoSize = true;
            this.aLbl.Location = new System.Drawing.Point(26, 48);
            this.aLbl.Name = "aLbl";
            this.aLbl.Size = new System.Drawing.Size(71, 13);
            this.aLbl.TabIndex = 1;
            this.aLbl.Text = "a oldal hossz:";
            // 
            // bLbl
            // 
            this.bLbl.AutoSize = true;
            this.bLbl.Location = new System.Drawing.Point(29, 82);
            this.bLbl.Name = "bLbl";
            this.bLbl.Size = new System.Drawing.Size(77, 13);
            this.bLbl.TabIndex = 2;
            this.bLbl.Text = "b oldal hossza:";
            // 
            // terLbl
            // 
            this.terLbl.AutoSize = true;
            this.terLbl.Location = new System.Drawing.Point(29, 156);
            this.terLbl.Name = "terLbl";
            this.terLbl.Size = new System.Drawing.Size(43, 13);
            this.terLbl.TabIndex = 3;
            this.terLbl.Text = "Terület:";
            this.terLbl.Visible = false;
            // 
            // kerLbl
            // 
            this.kerLbl.AutoSize = true;
            this.kerLbl.Location = new System.Drawing.Point(32, 191);
            this.kerLbl.Name = "kerLbl";
            this.kerLbl.Size = new System.Drawing.Size(43, 13);
            this.kerLbl.TabIndex = 4;
            this.kerLbl.Text = "Kerület:";
            this.kerLbl.Visible = false;
            // 
            // aTxt
            // 
            this.aTxt.Location = new System.Drawing.Point(137, 48);
            this.aTxt.Name = "aTxt";
            this.aTxt.Size = new System.Drawing.Size(100, 20);
            this.aTxt.TabIndex = 5;
            // 
            // bTxt
            // 
            this.bTxt.Location = new System.Drawing.Point(137, 82);
            this.bTxt.Name = "bTxt";
            this.bTxt.Size = new System.Drawing.Size(100, 20);
            this.bTxt.TabIndex = 6;
            // 
            // szamolBtn
            // 
            this.szamolBtn.Location = new System.Drawing.Point(104, 120);
            this.szamolBtn.Name = "szamolBtn";
            this.szamolBtn.Size = new System.Drawing.Size(75, 23);
            this.szamolBtn.TabIndex = 7;
            this.szamolBtn.Text = "Számolj!";
            this.szamolBtn.UseVisualStyleBackColor = true;
            this.szamolBtn.Click += new System.EventHandler(this.szamolBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.szamolBtn);
            this.Controls.Add(this.bTxt);
            this.Controls.Add(this.aTxt);
            this.Controls.Add(this.kerLbl);
            this.Controls.Add(this.terLbl);
            this.Controls.Add(this.bLbl);
            this.Controls.Add(this.aLbl);
            this.Controls.Add(this.kilepBtn);
            this.Name = "Form1";
            this.Text = "Téglalap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button kilepBtn;
        private System.Windows.Forms.Label aLbl;
        private System.Windows.Forms.Label bLbl;
        private System.Windows.Forms.Label terLbl;
        private System.Windows.Forms.Label kerLbl;
        private System.Windows.Forms.TextBox aTxt;
        private System.Windows.Forms.TextBox bTxt;
        private System.Windows.Forms.Button szamolBtn;
    }
}

