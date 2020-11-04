namespace Rádió_gomb
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
            this.kekBtn = new System.Windows.Forms.RadioButton();
            this.zoldBtn = new System.Windows.Forms.RadioButton();
            this.barnaBtn = new System.Windows.Forms.RadioButton();
            this.okBtn = new System.Windows.Forms.Button();
            this.MegseBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kekBtn
            // 
            this.kekBtn.AutoSize = true;
            this.kekBtn.Font = new System.Drawing.Font("Ravie", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kekBtn.Location = new System.Drawing.Point(24, 35);
            this.kekBtn.Name = "kekBtn";
            this.kekBtn.Size = new System.Drawing.Size(52, 21);
            this.kekBtn.TabIndex = 0;
            this.kekBtn.TabStop = true;
            this.kekBtn.Text = "kék";
            this.kekBtn.UseVisualStyleBackColor = true;
            // 
            // zoldBtn
            // 
            this.zoldBtn.AutoSize = true;
            this.zoldBtn.Font = new System.Drawing.Font("Ravie", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zoldBtn.Location = new System.Drawing.Point(24, 69);
            this.zoldBtn.Name = "zoldBtn";
            this.zoldBtn.Size = new System.Drawing.Size(59, 21);
            this.zoldBtn.TabIndex = 1;
            this.zoldBtn.TabStop = true;
            this.zoldBtn.Text = "zöld";
            this.zoldBtn.UseVisualStyleBackColor = true;
            // 
            // barnaBtn
            // 
            this.barnaBtn.AutoSize = true;
            this.barnaBtn.Font = new System.Drawing.Font("Ravie", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barnaBtn.Location = new System.Drawing.Point(24, 105);
            this.barnaBtn.Name = "barnaBtn";
            this.barnaBtn.Size = new System.Drawing.Size(69, 21);
            this.barnaBtn.TabIndex = 2;
            this.barnaBtn.TabStop = true;
            this.barnaBtn.Text = "barna";
            this.barnaBtn.UseVisualStyleBackColor = true;
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(101, 183);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 3;
            this.okBtn.Text = "Ok";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // MegseBtn
            // 
            this.MegseBtn.Location = new System.Drawing.Point(228, 183);
            this.MegseBtn.Name = "MegseBtn";
            this.MegseBtn.Size = new System.Drawing.Size(75, 23);
            this.MegseBtn.TabIndex = 4;
            this.MegseBtn.Text = "Mégse";
            this.MegseBtn.UseVisualStyleBackColor = true;
            this.MegseBtn.Click += new System.EventHandler(this.MegseBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 261);
            this.Controls.Add(this.MegseBtn);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.barnaBtn);
            this.Controls.Add(this.zoldBtn);
            this.Controls.Add(this.kekBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton kekBtn;
        private System.Windows.Forms.RadioButton zoldBtn;
        private System.Windows.Forms.RadioButton barnaBtn;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button MegseBtn;
    }
}

