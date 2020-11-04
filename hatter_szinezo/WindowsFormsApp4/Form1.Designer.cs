namespace WindowsFormsApp4
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
            this.piros_Btn = new System.Windows.Forms.Button();
            this.zold_Btn = new System.Windows.Forms.Button();
            this.kek_Btn = new System.Windows.Forms.Button();
            this.kilep_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // piros_Btn
            // 
            this.piros_Btn.Location = new System.Drawing.Point(52, 57);
            this.piros_Btn.Name = "piros_Btn";
            this.piros_Btn.Size = new System.Drawing.Size(163, 68);
            this.piros_Btn.TabIndex = 0;
            this.piros_Btn.Text = "Piros";
            this.piros_Btn.UseVisualStyleBackColor = true;
            this.piros_Btn.Click += new System.EventHandler(this.piros_Btn_Click);
            // 
            // zold_Btn
            // 
            this.zold_Btn.Location = new System.Drawing.Point(328, 57);
            this.zold_Btn.Name = "zold_Btn";
            this.zold_Btn.Size = new System.Drawing.Size(163, 68);
            this.zold_Btn.TabIndex = 1;
            this.zold_Btn.Text = "Zöld";
            this.zold_Btn.UseVisualStyleBackColor = true;
            this.zold_Btn.Click += new System.EventHandler(this.zold_Btn_Click);
            // 
            // kek_Btn
            // 
            this.kek_Btn.Location = new System.Drawing.Point(582, 57);
            this.kek_Btn.Name = "kek_Btn";
            this.kek_Btn.Size = new System.Drawing.Size(163, 68);
            this.kek_Btn.TabIndex = 2;
            this.kek_Btn.Text = "Kék";
            this.kek_Btn.UseVisualStyleBackColor = true;
            this.kek_Btn.Click += new System.EventHandler(this.kek_Btn_Click);
            // 
            // kilep_Btn
            // 
            this.kilep_Btn.Location = new System.Drawing.Point(328, 301);
            this.kilep_Btn.Name = "kilep_Btn";
            this.kilep_Btn.Size = new System.Drawing.Size(163, 82);
            this.kilep_Btn.TabIndex = 3;
            this.kilep_Btn.Text = "Kilép";
            this.kilep_Btn.UseVisualStyleBackColor = true;
            this.kilep_Btn.Click += new System.EventHandler(this.kilep_Btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kilep_Btn);
            this.Controls.Add(this.kek_Btn);
            this.Controls.Add(this.zold_Btn);
            this.Controls.Add(this.piros_Btn);
            this.Name = "Form1";
            this.Text = "Színező";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button piros_Btn;
        private System.Windows.Forms.Button zold_Btn;
        private System.Windows.Forms.Button kek_Btn;
        private System.Windows.Forms.Button kilep_Btn;
    }
}

