namespace csuszka
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
            this.SBnegyzeth = new System.Windows.Forms.HScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.lblnegyzet = new System.Windows.Forms.Label();
            this.rgbpiros = new System.Windows.Forms.Label();
            this.rgbzold = new System.Windows.Forms.Label();
            this.rgbkek = new System.Windows.Forms.Label();
            this.sbkek = new System.Windows.Forms.HScrollBar();
            this.sbpiros = new System.Windows.Forms.HScrollBar();
            this.sbzold = new System.Windows.Forms.HScrollBar();
            this.SuspendLayout();
            // 
            // SBnegyzeth
            // 
            this.SBnegyzeth.Location = new System.Drawing.Point(87, 47);
            this.SBnegyzeth.Maximum = 159;
            this.SBnegyzeth.Minimum = 10;
            this.SBnegyzeth.Name = "SBnegyzeth";
            this.SBnegyzeth.Size = new System.Drawing.Size(512, 29);
            this.SBnegyzeth.TabIndex = 0;
            this.SBnegyzeth.Value = 10;
            this.SBnegyzeth.ValueChanged += new System.EventHandler(this.SBnegyzeth_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(278, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "négyzet oldala";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(404, 21);
            this.lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(24, 17);
            this.lbl.TabIndex = 3;
            this.lbl.Text = "10";
            // 
            // lblnegyzet
            // 
            this.lblnegyzet.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblnegyzet.Location = new System.Drawing.Point(104, 149);
            this.lblnegyzet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnegyzet.MaximumSize = new System.Drawing.Size(400, 369);
            this.lblnegyzet.MinimumSize = new System.Drawing.Size(13, 12);
            this.lblnegyzet.Name = "lblnegyzet";
            this.lblnegyzet.Size = new System.Drawing.Size(13, 12);
            this.lblnegyzet.TabIndex = 4;
            // 
            // rgbpiros
            // 
            this.rgbpiros.AutoSize = true;
            this.rgbpiros.Location = new System.Drawing.Point(83, 406);
            this.rgbpiros.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rgbpiros.Name = "rgbpiros";
            this.rgbpiros.Size = new System.Drawing.Size(40, 17);
            this.rgbpiros.TabIndex = 5;
            this.rgbpiros.Text = "Piros";
            // 
            // rgbzold
            // 
            this.rgbzold.AutoSize = true;
            this.rgbzold.Location = new System.Drawing.Point(80, 449);
            this.rgbzold.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rgbzold.Name = "rgbzold";
            this.rgbzold.Size = new System.Drawing.Size(36, 17);
            this.rgbzold.TabIndex = 6;
            this.rgbzold.Text = "Zöld";
            // 
            // rgbkek
            // 
            this.rgbkek.AutoSize = true;
            this.rgbkek.Location = new System.Drawing.Point(83, 489);
            this.rgbkek.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rgbkek.Name = "rgbkek";
            this.rgbkek.Size = new System.Drawing.Size(32, 17);
            this.rgbkek.TabIndex = 7;
            this.rgbkek.Text = "Kék";
            // 
            // sbkek
            // 
            this.sbkek.Location = new System.Drawing.Point(179, 484);
            this.sbkek.Maximum = 255;
            this.sbkek.Name = "sbkek";
            this.sbkek.Size = new System.Drawing.Size(420, 17);
            this.sbkek.TabIndex = 8;
            this.sbkek.Scroll += new System.Windows.Forms.ScrollEventHandler(this.sbkek_Scroll);
            // 
            // sbpiros
            // 
            this.sbpiros.Location = new System.Drawing.Point(179, 401);
            this.sbpiros.Maximum = 255;
            this.sbpiros.Name = "sbpiros";
            this.sbpiros.Size = new System.Drawing.Size(420, 17);
            this.sbpiros.TabIndex = 9;
            this.sbpiros.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar2_Scroll_1);
            // 
            // sbzold
            // 
            this.sbzold.Location = new System.Drawing.Point(179, 444);
            this.sbzold.Maximum = 255;
            this.sbzold.Name = "sbzold";
            this.sbzold.Size = new System.Drawing.Size(420, 17);
            this.sbzold.TabIndex = 10;
            this.sbzold.Scroll += new System.Windows.Forms.ScrollEventHandler(this.sbzold_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 582);
            this.Controls.Add(this.sbzold);
            this.Controls.Add(this.sbpiros);
            this.Controls.Add(this.sbkek);
            this.Controls.Add(this.rgbkek);
            this.Controls.Add(this.rgbzold);
            this.Controls.Add(this.rgbpiros);
            this.Controls.Add(this.lblnegyzet);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SBnegyzeth);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Csúszka Négyzet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.HScrollBar SBnegyzeth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblnegyzet;
        private System.Windows.Forms.Label rgbpiros;
        private System.Windows.Forms.Label rgbzold;
        private System.Windows.Forms.Label rgbkek;
        private System.Windows.Forms.HScrollBar sbkek;
        private System.Windows.Forms.HScrollBar sbpiros;
        private System.Windows.Forms.HScrollBar sbzold;
    }
}

