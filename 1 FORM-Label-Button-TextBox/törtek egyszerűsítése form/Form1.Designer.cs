namespace törtek_egyszerűsítése_form
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
            this.btOk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSzámláló = new System.Windows.Forms.TextBox();
            this.tbNevező = new System.Windows.Forms.TextBox();
            this.lbSzámláló = new System.Windows.Forms.Label();
            this.lbNevező = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(117, 124);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(75, 23);
            this.btOk.TabIndex = 0;
            this.btOk.Text = "egyszerüsít";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "------------------------";
            // 
            // tbSzámláló
            // 
            this.tbSzámláló.Location = new System.Drawing.Point(49, 27);
            this.tbSzámláló.Name = "tbSzámláló";
            this.tbSzámláló.Size = new System.Drawing.Size(72, 20);
            this.tbSzámláló.TabIndex = 2;
            // 
            // tbNevező
            // 
            this.tbNevező.Location = new System.Drawing.Point(49, 66);
            this.tbNevező.Name = "tbNevező";
            this.tbNevező.Size = new System.Drawing.Size(72, 20);
            this.tbNevező.TabIndex = 3;
            // 
            // lbSzámláló
            // 
            this.lbSzámláló.AutoSize = true;
            this.lbSzámláló.Location = new System.Drawing.Point(192, 27);
            this.lbSzámláló.Name = "lbSzámláló";
            this.lbSzámláló.Size = new System.Drawing.Size(0, 13);
            this.lbSzámláló.TabIndex = 4;
            // 
            // lbNevező
            // 
            this.lbNevező.AutoSize = true;
            this.lbNevező.Location = new System.Drawing.Point(192, 73);
            this.lbNevező.Name = "lbNevező";
            this.lbNevező.Size = new System.Drawing.Size(0, 13);
            this.lbNevező.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(192, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "-------------";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 180);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbNevező);
            this.Controls.Add(this.lbSzámláló);
            this.Controls.Add(this.tbNevező);
            this.Controls.Add(this.tbSzámláló);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btOk);
            this.Name = "Form1";
            this.Text = "Tört egyszerüsítése";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSzámláló;
        private System.Windows.Forms.TextBox tbNevező;
        private System.Windows.Forms.Label lbSzámláló;
        private System.Windows.Forms.Label lbNevező;
        private System.Windows.Forms.Label label4;
    }
}

