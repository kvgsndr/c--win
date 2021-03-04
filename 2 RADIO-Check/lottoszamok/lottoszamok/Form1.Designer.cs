namespace lottószámok
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
            this.otosrbtn = new System.Windows.Forms.RadioButton();
            this.hatosrbtn = new System.Windows.Forms.RadioButton();
            this.skandinavrbtn = new System.Windows.Forms.RadioButton();
            this.ok = new System.Windows.Forms.Button();
            this.kilepes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // otosrbtn
            // 
            this.otosrbtn.AutoSize = true;
            this.otosrbtn.Location = new System.Drawing.Point(61, 24);
            this.otosrbtn.Name = "otosrbtn";
            this.otosrbtn.Size = new System.Drawing.Size(47, 17);
            this.otosrbtn.TabIndex = 0;
            this.otosrbtn.TabStop = true;
            this.otosrbtn.Text = "Ötös";
            this.otosrbtn.UseVisualStyleBackColor = true;
            // 
            // hatosrbtn
            // 
            this.hatosrbtn.AutoSize = true;
            this.hatosrbtn.Location = new System.Drawing.Point(61, 73);
            this.hatosrbtn.Name = "hatosrbtn";
            this.hatosrbtn.Size = new System.Drawing.Size(53, 17);
            this.hatosrbtn.TabIndex = 1;
            this.hatosrbtn.TabStop = true;
            this.hatosrbtn.Text = "Hatos";
            this.hatosrbtn.UseVisualStyleBackColor = true;
            // 
            // skandinavrbtn
            // 
            this.skandinavrbtn.AutoSize = true;
            this.skandinavrbtn.Location = new System.Drawing.Point(61, 133);
            this.skandinavrbtn.Name = "skandinavrbtn";
            this.skandinavrbtn.Size = new System.Drawing.Size(76, 17);
            this.skandinavrbtn.TabIndex = 2;
            this.skandinavrbtn.TabStop = true;
            this.skandinavrbtn.Text = "Skandináv";
            this.skandinavrbtn.UseVisualStyleBackColor = true;
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(96, 215);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(75, 23);
            this.ok.TabIndex = 3;
            this.ok.Text = "Generálás !";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // kilepes
            // 
            this.kilepes.Location = new System.Drawing.Point(324, 215);
            this.kilepes.Name = "kilepes";
            this.kilepes.Size = new System.Drawing.Size(75, 23);
            this.kilepes.TabIndex = 4;
            this.kilepes.Text = "Kilépés !";
            this.kilepes.UseVisualStyleBackColor = true;
            this.kilepes.Click += new System.EventHandler(this.kilepes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(252, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(252, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(252, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(252, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 266);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kilepes);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.skandinavrbtn);
            this.Controls.Add(this.hatosrbtn);
            this.Controls.Add(this.otosrbtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton otosrbtn;
        private System.Windows.Forms.RadioButton hatosrbtn;
        private System.Windows.Forms.RadioButton skandinavrbtn;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.Button kilepes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

