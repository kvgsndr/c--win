namespace halmazallapot
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
            this.kepPbx = new System.Windows.Forms.PictureBox();
            this.okBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.halmazLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kepPbx)).BeginInit();
            this.SuspendLayout();
            // 
            // kepPbx
            // 
            this.kepPbx.Location = new System.Drawing.Point(468, 136);
            this.kepPbx.Name = "kepPbx";
            this.kepPbx.Size = new System.Drawing.Size(200, 170);
            this.kepPbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kepPbx.TabIndex = 0;
            this.kepPbx.TabStop = false;
            // 
            // okBtn
            // 
            this.okBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.okBtn.Location = new System.Drawing.Point(109, 136);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(105, 58);
            this.okBtn.TabIndex = 1;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(69, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Víz hőmérséklete:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(256, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 3;
            // 
            // halmazLbl
            // 
            this.halmazLbl.AutoSize = true;
            this.halmazLbl.Location = new System.Drawing.Point(465, 350);
            this.halmazLbl.Name = "halmazLbl";
            this.halmazLbl.Size = new System.Drawing.Size(46, 17);
            this.halmazLbl.TabIndex = 4;
            this.halmazLbl.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.halmazLbl);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.kepPbx);
            this.Name = "Form1";
            this.Text = "Halmazállapot";
            ((System.ComponentModel.ISupportInitialize)(this.kepPbx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox kepPbx;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label halmazLbl;
    }
}

