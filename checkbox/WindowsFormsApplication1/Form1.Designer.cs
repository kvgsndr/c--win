namespace WindowsFormsApplication1
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
            this.label2 = new System.Windows.Forms.Label();
            this.torzsChbx = new System.Windows.Forms.CheckBox();
            this.okBtn = new System.Windows.Forms.Button();
            this.megseBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.arTbx = new System.Windows.Forms.TextBox();
            this.afaTbx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.afasarLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ár:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Áfa:";
            // 
            // torzsChbx
            // 
            this.torzsChbx.AutoSize = true;
            this.torzsChbx.Location = new System.Drawing.Point(40, 127);
            this.torzsChbx.Name = "torzsChbx";
            this.torzsChbx.Size = new System.Drawing.Size(184, 17);
            this.torzsChbx.TabIndex = 2;
            this.torzsChbx.Text = "Törzsvásárló (10% kedvedzmény)";
            this.torzsChbx.UseVisualStyleBackColor = true;
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(177, 226);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(53, 23);
            this.okBtn.TabIndex = 3;
            this.okBtn.Text = "Ok";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // megseBtn
            // 
            this.megseBtn.Location = new System.Drawing.Point(236, 226);
            this.megseBtn.Name = "megseBtn";
            this.megseBtn.Size = new System.Drawing.Size(53, 23);
            this.megseBtn.TabIndex = 4;
            this.megseBtn.Text = "Mégse";
            this.megseBtn.UseVisualStyleBackColor = true;
            this.megseBtn.Click += new System.EventHandler(this.megseBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "%";
            // 
            // arTbx
            // 
            this.arTbx.Location = new System.Drawing.Point(70, 54);
            this.arTbx.Name = "arTbx";
            this.arTbx.Size = new System.Drawing.Size(66, 20);
            this.arTbx.TabIndex = 6;
            // 
            // afaTbx
            // 
            this.afaTbx.Location = new System.Drawing.Point(70, 82);
            this.afaTbx.Name = "afaTbx";
            this.afaTbx.Size = new System.Drawing.Size(66, 20);
            this.afaTbx.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Áfás ár:";
            // 
            // afasarLbl
            // 
            this.afasarLbl.AutoSize = true;
            this.afasarLbl.Location = new System.Drawing.Point(37, 208);
            this.afasarLbl.Name = "afasarLbl";
            this.afasarLbl.Size = new System.Drawing.Size(0, 13);
            this.afasarLbl.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 261);
            this.Controls.Add(this.afasarLbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.afaTbx);
            this.Controls.Add(this.arTbx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.megseBtn);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.torzsChbx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox torzsChbx;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button megseBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox arTbx;
        private System.Windows.Forms.TextBox afaTbx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label afasarLbl;
    }
}

