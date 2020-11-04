namespace Szinkeveres
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
            this.redScrollBar = new System.Windows.Forms.HScrollBar();
            this.greenScrollBar = new System.Windows.Forms.HScrollBar();
            this.blueScrollBar = new System.Windows.Forms.HScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.szinezBtn = new System.Windows.Forms.Button();
            this.kilepBtn = new System.Windows.Forms.Button();
            this.rgbTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // redScrollBar
            // 
            this.redScrollBar.LargeChange = 1;
            this.redScrollBar.Location = new System.Drawing.Point(52, 27);
            this.redScrollBar.Maximum = 255;
            this.redScrollBar.Name = "redScrollBar";
            this.redScrollBar.Size = new System.Drawing.Size(150, 17);
            this.redScrollBar.TabIndex = 0;
            // 
            // greenScrollBar
            // 
            this.greenScrollBar.LargeChange = 1;
            this.greenScrollBar.Location = new System.Drawing.Point(52, 65);
            this.greenScrollBar.Maximum = 255;
            this.greenScrollBar.Name = "greenScrollBar";
            this.greenScrollBar.Size = new System.Drawing.Size(150, 17);
            this.greenScrollBar.TabIndex = 1;
            // 
            // blueScrollBar
            // 
            this.blueScrollBar.LargeChange = 1;
            this.blueScrollBar.Location = new System.Drawing.Point(52, 108);
            this.blueScrollBar.Maximum = 255;
            this.blueScrollBar.Name = "blueScrollBar";
            this.blueScrollBar.Size = new System.Drawing.Size(150, 17);
            this.blueScrollBar.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(13, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "R:    0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(206, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "255";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(12, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "G:   0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(206, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "255";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(14, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "B:    0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(209, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "255";
            // 
            // szinezBtn
            // 
            this.szinezBtn.Location = new System.Drawing.Point(113, 141);
            this.szinezBtn.Name = "szinezBtn";
            this.szinezBtn.Size = new System.Drawing.Size(75, 23);
            this.szinezBtn.TabIndex = 9;
            this.szinezBtn.Text = "Színez";
            this.szinezBtn.UseVisualStyleBackColor = true;
            this.szinezBtn.Click += new System.EventHandler(this.szinezBtn_Click);
            // 
            // kilepBtn
            // 
            this.kilepBtn.Location = new System.Drawing.Point(197, 226);
            this.kilepBtn.Name = "kilepBtn";
            this.kilepBtn.Size = new System.Drawing.Size(75, 23);
            this.kilepBtn.TabIndex = 10;
            this.kilepBtn.Text = "Kilépés";
            this.kilepBtn.UseVisualStyleBackColor = true;
            this.kilepBtn.Click += new System.EventHandler(this.kilepBtn_Click);
            // 
            // rgbTxt
            // 
            this.rgbTxt.Enabled = false;
            this.rgbTxt.Location = new System.Drawing.Point(52, 182);
            this.rgbTxt.Name = "rgbTxt";
            this.rgbTxt.Size = new System.Drawing.Size(100, 20);
            this.rgbTxt.TabIndex = 11;
            this.rgbTxt.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.rgbTxt);
            this.Controls.Add(this.kilepBtn);
            this.Controls.Add(this.szinezBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.blueScrollBar);
            this.Controls.Add(this.greenScrollBar);
            this.Controls.Add(this.redScrollBar);
            this.Name = "Form1";
            this.Text = "Színkeverő";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.HScrollBar redScrollBar;
        private System.Windows.Forms.HScrollBar greenScrollBar;
        private System.Windows.Forms.HScrollBar blueScrollBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button szinezBtn;
        private System.Windows.Forms.Button kilepBtn;
        private System.Windows.Forms.TextBox rgbTxt;
    }
}

