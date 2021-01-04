namespace ymxb
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
            this.m = new System.Windows.Forms.NumericUpDown();
            this.b = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.yjel = new System.Windows.Forms.Label();
            this.xjel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.m)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b)).BeginInit();
            this.SuspendLayout();
            // 
            // m
            // 
            this.m.DecimalPlaces = 2;
            this.m.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.m.Location = new System.Drawing.Point(3, 12);
            this.m.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.m.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.m.Name = "m";
            this.m.Size = new System.Drawing.Size(53, 20);
            this.m.TabIndex = 0;
            this.m.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.m.ValueChanged += new System.EventHandler(this.on_ujrair);
            // 
            // b
            // 
            this.b.Location = new System.Drawing.Point(62, 12);
            this.b.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(53, 20);
            this.b.TabIndex = 1;
            this.b.ValueChanged += new System.EventHandler(this.on_ujrair);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "m                 b";
            // 
            // yjel
            // 
            this.yjel.AutoSize = true;
            this.yjel.Location = new System.Drawing.Point(313, 98);
            this.yjel.Name = "yjel";
            this.yjel.Size = new System.Drawing.Size(12, 13);
            this.yjel.TabIndex = 3;
            this.yjel.Text = "y";
            // 
            // xjel
            // 
            this.xjel.AutoSize = true;
            this.xjel.Location = new System.Drawing.Point(298, 185);
            this.xjel.Name = "xjel";
            this.xjel.Size = new System.Drawing.Size(12, 13);
            this.xjel.TabIndex = 4;
            this.xjel.Text = "x";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 383);
            this.Controls.Add(this.xjel);
            this.Controls.Add(this.yjel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.b);
            this.Controls.Add(this.m);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.on_rajzol);
            this.SizeChanged += new System.EventHandler(this.on_meretvalt);
            ((System.ComponentModel.ISupportInitialize)(this.m)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown m;
        private System.Windows.Forms.NumericUpDown b;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label yjel;
        private System.Windows.Forms.Label xjel;
    }
}

