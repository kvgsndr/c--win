namespace vezerlok2
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
            this.udvBtn = new System.Windows.Forms.Button();
            this.kilepBtn = new System.Windows.Forms.Button();
            this.nevLbl = new System.Windows.Forms.Label();
            this.udvLbl = new System.Windows.Forms.Label();
            this.nevTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // udvBtn
            // 
            this.udvBtn.Location = new System.Drawing.Point(68, 136);
            this.udvBtn.Name = "udvBtn";
            this.udvBtn.Size = new System.Drawing.Size(130, 44);
            this.udvBtn.TabIndex = 0;
            this.udvBtn.Text = "Üdvözlet";
            this.udvBtn.UseVisualStyleBackColor = true;
            this.udvBtn.Click += new System.EventHandler(this.udvBtn_Click);
            // 
            // kilepBtn
            // 
            this.kilepBtn.Enabled = false;
            this.kilepBtn.Location = new System.Drawing.Point(668, 393);
            this.kilepBtn.Name = "kilepBtn";
            this.kilepBtn.Size = new System.Drawing.Size(120, 45);
            this.kilepBtn.TabIndex = 1;
            this.kilepBtn.Text = "Kilépés";
            this.kilepBtn.UseVisualStyleBackColor = true;
            this.kilepBtn.Click += new System.EventHandler(this.kilepBtn_Click);
            // 
            // nevLbl
            // 
            this.nevLbl.AutoSize = true;
            this.nevLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nevLbl.Location = new System.Drawing.Point(65, 66);
            this.nevLbl.Name = "nevLbl";
            this.nevLbl.Size = new System.Drawing.Size(81, 25);
            this.nevLbl.TabIndex = 2;
            this.nevLbl.Text = "Neved:";
            // 
            // udvLbl
            // 
            this.udvLbl.AutoSize = true;
            this.udvLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.udvLbl.Location = new System.Drawing.Point(65, 232);
            this.udvLbl.Name = "udvLbl";
            this.udvLbl.Size = new System.Drawing.Size(64, 25);
            this.udvLbl.TabIndex = 3;
            this.udvLbl.Text = "label2";
            this.udvLbl.Visible = false;
            // 
            // nevTxt
            // 
            this.nevTxt.Location = new System.Drawing.Point(171, 70);
            this.nevTxt.Name = "nevTxt";
            this.nevTxt.Size = new System.Drawing.Size(166, 22);
            this.nevTxt.TabIndex = 4;
            this.nevTxt.TextChanged += new System.EventHandler(this.nevTxt_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nevTxt);
            this.Controls.Add(this.udvLbl);
            this.Controls.Add(this.nevLbl);
            this.Controls.Add(this.kilepBtn);
            this.Controls.Add(this.udvBtn);
            this.Name = "Form1";
            this.Text = "Vezérlők működése";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button udvBtn;
        private System.Windows.Forms.Button kilepBtn;
        private System.Windows.Forms.Label nevLbl;
        private System.Windows.Forms.Label udvLbl;
        private System.Windows.Forms.TextBox nevTxt;
    }
}

