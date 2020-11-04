namespace szolanc
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
            this.ellenorzesBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.szovegTxb = new System.Windows.Forms.TextBox();
            this.eredmenyLbl = new System.Windows.Forms.Label();
            this.ellenorzes2Btn = new System.Windows.Forms.Button();
            this.eredmeny2Lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.szo1Txb = new System.Windows.Forms.TextBox();
            this.szo2Txb = new System.Windows.Forms.TextBox();
            this.szolanceBtn = new System.Windows.Forms.Button();
            this.szolancLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ellenorzesBtn
            // 
            this.ellenorzesBtn.Location = new System.Drawing.Point(61, 90);
            this.ellenorzesBtn.Name = "ellenorzesBtn";
            this.ellenorzesBtn.Size = new System.Drawing.Size(132, 23);
            this.ellenorzesBtn.TabIndex = 0;
            this.ellenorzesBtn.Text = "Ellenőrzés eleje";
            this.ellenorzesBtn.UseVisualStyleBackColor = true;
            this.ellenorzesBtn.Click += new System.EventHandler(this.ellenorzesBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mi a szöveg?";
            // 
            // szovegTxb
            // 
            this.szovegTxb.Location = new System.Drawing.Point(148, 43);
            this.szovegTxb.Name = "szovegTxb";
            this.szovegTxb.Size = new System.Drawing.Size(100, 20);
            this.szovegTxb.TabIndex = 2;
            // 
            // eredmenyLbl
            // 
            this.eredmenyLbl.AutoSize = true;
            this.eredmenyLbl.Location = new System.Drawing.Point(213, 100);
            this.eredmenyLbl.Name = "eredmenyLbl";
            this.eredmenyLbl.Size = new System.Drawing.Size(35, 13);
            this.eredmenyLbl.TabIndex = 3;
            this.eredmenyLbl.Text = "label2";
            // 
            // ellenorzes2Btn
            // 
            this.ellenorzes2Btn.Location = new System.Drawing.Point(63, 128);
            this.ellenorzes2Btn.Name = "ellenorzes2Btn";
            this.ellenorzes2Btn.Size = new System.Drawing.Size(130, 23);
            this.ellenorzes2Btn.TabIndex = 4;
            this.ellenorzes2Btn.Text = "Ellenőrzés vége";
            this.ellenorzes2Btn.UseVisualStyleBackColor = true;
            this.ellenorzes2Btn.Click += new System.EventHandler(this.ellenorzes2Btn_Click);
            // 
            // eredmeny2Lbl
            // 
            this.eredmeny2Lbl.AutoSize = true;
            this.eredmeny2Lbl.Location = new System.Drawing.Point(213, 133);
            this.eredmeny2Lbl.Name = "eredmeny2Lbl";
            this.eredmeny2Lbl.Size = new System.Drawing.Size(35, 13);
            this.eredmeny2Lbl.TabIndex = 5;
            this.eredmeny2Lbl.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "1. szó";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(236, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "2. szó";
            // 
            // szo1Txb
            // 
            this.szo1Txb.Location = new System.Drawing.Point(102, 200);
            this.szo1Txb.Name = "szo1Txb";
            this.szo1Txb.Size = new System.Drawing.Size(100, 20);
            this.szo1Txb.TabIndex = 8;
            // 
            // szo2Txb
            // 
            this.szo2Txb.Location = new System.Drawing.Point(287, 201);
            this.szo2Txb.Name = "szo2Txb";
            this.szo2Txb.Size = new System.Drawing.Size(100, 20);
            this.szo2Txb.TabIndex = 9;
            // 
            // szolanceBtn
            // 
            this.szolanceBtn.Location = new System.Drawing.Point(173, 238);
            this.szolanceBtn.Name = "szolanceBtn";
            this.szolanceBtn.Size = new System.Drawing.Size(75, 23);
            this.szolanceBtn.TabIndex = 10;
            this.szolanceBtn.Text = "Szólánc-e?";
            this.szolanceBtn.UseVisualStyleBackColor = true;
            this.szolanceBtn.Click += new System.EventHandler(this.szolanceBtn_Click);
            // 
            // szolancLbl
            // 
            this.szolancLbl.AutoSize = true;
            this.szolancLbl.Location = new System.Drawing.Point(166, 280);
            this.szolancLbl.Name = "szolancLbl";
            this.szolancLbl.Size = new System.Drawing.Size(35, 13);
            this.szolancLbl.TabIndex = 11;
            this.szolancLbl.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 332);
            this.Controls.Add(this.szolancLbl);
            this.Controls.Add(this.szolanceBtn);
            this.Controls.Add(this.szo2Txb);
            this.Controls.Add(this.szo1Txb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.eredmeny2Lbl);
            this.Controls.Add(this.ellenorzes2Btn);
            this.Controls.Add(this.eredmenyLbl);
            this.Controls.Add(this.szovegTxb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ellenorzesBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ellenorzesBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox szovegTxb;
        private System.Windows.Forms.Label eredmenyLbl;
        private System.Windows.Forms.Button ellenorzes2Btn;
        private System.Windows.Forms.Label eredmeny2Lbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox szo1Txb;
        private System.Windows.Forms.TextBox szo2Txb;
        private System.Windows.Forms.Button szolanceBtn;
        private System.Windows.Forms.Label szolancLbl;
    }
}

