namespace Akcio
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
            this.arLbl = new System.Windows.Forms.Label();
            this.engedLbl = new System.Windows.Forms.Label();
            this.arTxt = new System.Windows.Forms.TextBox();
            this.engedTxt = new System.Windows.Forms.TextBox();
            this.szamolBtn = new System.Windows.Forms.Button();
            this.kilepBtn = new System.Windows.Forms.Button();
            this.valaszLbl = new System.Windows.Forms.Label();
            this.ujarLbl = new System.Windows.Forms.Label();
            this.ujarTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // arLbl
            // 
            this.arLbl.AutoSize = true;
            this.arLbl.Location = new System.Drawing.Point(24, 30);
            this.arLbl.Name = "arLbl";
            this.arLbl.Size = new System.Drawing.Size(85, 13);
            this.arLbl.TabIndex = 0;
            this.arLbl.Text = "Termék ára (Ft): ";
            // 
            // engedLbl
            // 
            this.engedLbl.AutoSize = true;
            this.engedLbl.Location = new System.Drawing.Point(27, 70);
            this.engedLbl.Name = "engedLbl";
            this.engedLbl.Size = new System.Drawing.Size(128, 13);
            this.engedLbl.TabIndex = 1;
            this.engedLbl.Text = "Árengedmény százaléka: ";
            // 
            // arTxt
            // 
            this.arTxt.Location = new System.Drawing.Point(172, 23);
            this.arTxt.Name = "arTxt";
            this.arTxt.Size = new System.Drawing.Size(100, 20);
            this.arTxt.TabIndex = 2;
            // 
            // engedTxt
            // 
            this.engedTxt.Location = new System.Drawing.Point(172, 62);
            this.engedTxt.Name = "engedTxt";
            this.engedTxt.Size = new System.Drawing.Size(100, 20);
            this.engedTxt.TabIndex = 3;
            // 
            // szamolBtn
            // 
            this.szamolBtn.Location = new System.Drawing.Point(91, 104);
            this.szamolBtn.Name = "szamolBtn";
            this.szamolBtn.Size = new System.Drawing.Size(75, 23);
            this.szamolBtn.TabIndex = 4;
            this.szamolBtn.Text = "Akciós ár (ft):";
            this.szamolBtn.UseVisualStyleBackColor = true;
            this.szamolBtn.Click += new System.EventHandler(this.szamolBtn_Click);
            // 
            // kilepBtn
            // 
            this.kilepBtn.Location = new System.Drawing.Point(187, 215);
            this.kilepBtn.Name = "kilepBtn";
            this.kilepBtn.Size = new System.Drawing.Size(75, 23);
            this.kilepBtn.TabIndex = 5;
            this.kilepBtn.Text = "Kilépés";
            this.kilepBtn.UseVisualStyleBackColor = true;
            this.kilepBtn.Click += new System.EventHandler(this.kilepBtn_Click);
            // 
            // valaszLbl
            // 
            this.valaszLbl.AutoSize = true;
            this.valaszLbl.Location = new System.Drawing.Point(33, 192);
            this.valaszLbl.Name = "valaszLbl";
            this.valaszLbl.Size = new System.Drawing.Size(29, 13);
            this.valaszLbl.TabIndex = 6;
            this.valaszLbl.Text = "Új ár";
            this.valaszLbl.Visible = false;
            // 
            // ujarLbl
            // 
            this.ujarLbl.AutoSize = true;
            this.ujarLbl.Location = new System.Drawing.Point(33, 153);
            this.ujarLbl.Name = "ujarLbl";
            this.ujarLbl.Size = new System.Drawing.Size(57, 13);
            this.ujarLbl.TabIndex = 7;
            this.ujarLbl.Text = "Akciós ár: ";
            // 
            // ujarTxt
            // 
            this.ujarTxt.Enabled = false;
            this.ujarTxt.Location = new System.Drawing.Point(172, 145);
            this.ujarTxt.Name = "ujarTxt";
            this.ujarTxt.Size = new System.Drawing.Size(100, 20);
            this.ujarTxt.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.ujarTxt);
            this.Controls.Add(this.ujarLbl);
            this.Controls.Add(this.valaszLbl);
            this.Controls.Add(this.kilepBtn);
            this.Controls.Add(this.szamolBtn);
            this.Controls.Add(this.engedTxt);
            this.Controls.Add(this.arTxt);
            this.Controls.Add(this.engedLbl);
            this.Controls.Add(this.arLbl);
            this.Name = "Form1";
            this.Text = "Árengedmény számítása";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label arLbl;
        private System.Windows.Forms.Label engedLbl;
        private System.Windows.Forms.TextBox arTxt;
        private System.Windows.Forms.TextBox engedTxt;
        private System.Windows.Forms.Button szamolBtn;
        private System.Windows.Forms.Button kilepBtn;
        private System.Windows.Forms.Label valaszLbl;
        private System.Windows.Forms.Label ujarLbl;
        private System.Windows.Forms.TextBox ujarTxt;
    }
}

