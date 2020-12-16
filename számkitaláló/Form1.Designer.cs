namespace számkitaláló
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
            this.lbTipp = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbUzenet = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btErtekel = new System.Windows.Forms.Button();
            this.btUjJatek = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTipp
            // 
            this.lbTipp.BackColor = System.Drawing.Color.MediumPurple;
            this.lbTipp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbTipp.Location = new System.Drawing.Point(29, 48);
            this.lbTipp.Name = "lbTipp";
            this.lbTipp.Size = new System.Drawing.Size(51, 32);
            this.lbTipp.TabIndex = 0;
            this.lbTipp.Text = "0";
            this.lbTipp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = ".tipp";
            // 
            // lbUzenet
            // 
            this.lbUzenet.AutoSize = true;
            this.lbUzenet.Location = new System.Drawing.Point(86, 126);
            this.lbUzenet.Name = "lbUzenet";
            this.lbUzenet.Size = new System.Drawing.Size(0, 13);
            this.lbUzenet.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(148, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(75, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // btErtekel
            // 
            this.btErtekel.Location = new System.Drawing.Point(29, 169);
            this.btErtekel.Name = "btErtekel";
            this.btErtekel.Size = new System.Drawing.Size(75, 23);
            this.btErtekel.TabIndex = 4;
            this.btErtekel.Text = "Értékel";
            this.btErtekel.UseVisualStyleBackColor = true;
            this.btErtekel.Click += new System.EventHandler(this.btErtekel_Click);
            // 
            // btUjJatek
            // 
            this.btUjJatek.Location = new System.Drawing.Point(148, 169);
            this.btUjJatek.Name = "btUjJatek";
            this.btUjJatek.Size = new System.Drawing.Size(75, 23);
            this.btUjJatek.TabIndex = 5;
            this.btUjJatek.Text = "Új játék";
            this.btUjJatek.UseVisualStyleBackColor = true;
            this.btUjJatek.Click += new System.EventHandler(this.btUjJatek_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 234);
            this.Controls.Add(this.btUjJatek);
            this.Controls.Add(this.btErtekel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbUzenet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbTipp);
            this.Name = "Form1";
            this.Text = "Számkitaláló játék";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTipp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbUzenet;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btErtekel;
        private System.Windows.Forms.Button btUjJatek;
    }
}

