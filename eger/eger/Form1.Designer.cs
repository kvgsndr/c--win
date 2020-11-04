namespace eger
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
            this.elsoBtn = new System.Windows.Forms.Button();
            this.masodikBtn = new System.Windows.Forms.Button();
            this.harmadikBtn = new System.Windows.Forms.Button();
            this.kilepBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "helyLbl";
            // 
            // elsoBtn
            // 
            this.elsoBtn.Location = new System.Drawing.Point(66, 104);
            this.elsoBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.elsoBtn.Name = "elsoBtn";
            this.elsoBtn.Size = new System.Drawing.Size(103, 31);
            this.elsoBtn.TabIndex = 1;
            this.elsoBtn.Text = "Láthatatlan-látható";
            this.elsoBtn.UseVisualStyleBackColor = true;
            this.elsoBtn.Click += new System.EventHandler(this.elsoBtn_Click);
            // 
            // masodikBtn
            // 
            this.masodikBtn.Location = new System.Drawing.Point(240, 104);
            this.masodikBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.masodikBtn.Name = "masodikBtn";
            this.masodikBtn.Size = new System.Drawing.Size(103, 31);
            this.masodikBtn.TabIndex = 2;
            this.masodikBtn.Text = "Aktív-inaktív";
            this.masodikBtn.UseVisualStyleBackColor = true;
            this.masodikBtn.Click += new System.EventHandler(this.masodikBtn_Click);
            // 
            // harmadikBtn
            // 
            this.harmadikBtn.Location = new System.Drawing.Point(403, 104);
            this.harmadikBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.harmadikBtn.Name = "harmadikBtn";
            this.harmadikBtn.Size = new System.Drawing.Size(103, 31);
            this.harmadikBtn.TabIndex = 3;
            this.harmadikBtn.Text = "Kilépés";
            this.harmadikBtn.UseVisualStyleBackColor = true;
            this.harmadikBtn.Click += new System.EventHandler(this.harmadikBtn_Click);
            // 
            // kilepBtn
            // 
            this.kilepBtn.Location = new System.Drawing.Point(488, 331);
            this.kilepBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kilepBtn.Name = "kilepBtn";
            this.kilepBtn.Size = new System.Drawing.Size(103, 25);
            this.kilepBtn.TabIndex = 4;
            this.kilepBtn.Text = "Kilépés";
            this.kilepBtn.UseVisualStyleBackColor = true;
            this.kilepBtn.Click += new System.EventHandler(this.kilepBtn_Click);
            this.kilepBtn.MouseEnter += new System.EventHandler(this.kilepBtn_MouseEnter);
            this.kilepBtn.MouseLeave += new System.EventHandler(this.kilepBtn_MouseLeave);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(240, 211);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 37);
            this.button1.TabIndex = 5;
            this.button1.Text = "Kattints ide!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.kilepBtn);
            this.Controls.Add(this.harmadikBtn);
            this.Controls.Add(this.masodikBtn);
            this.Controls.Add(this.elsoBtn);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseEnter += new System.EventHandler(this.Form1_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.Form1_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button elsoBtn;
        private System.Windows.Forms.Button masodikBtn;
        private System.Windows.Forms.Button harmadikBtn;
        private System.Windows.Forms.Button kilepBtn;
        private System.Windows.Forms.Button button1;
    }
}

