namespace jegy
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.jegyTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nevTxt = new System.Windows.Forms.TextBox();
            this.eredmenyLbl = new System.Windows.Forms.Label();
            this.jegyPtx = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.jegyPtx)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(68, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vizsgajegy";
            // 
            // jegyTxt
            // 
            this.jegyTxt.Location = new System.Drawing.Point(154, 73);
            this.jegyTxt.Name = "jegyTxt";
            this.jegyTxt.Size = new System.Drawing.Size(100, 22);
            this.jegyTxt.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Név:";
            // 
            // nevTxt
            // 
            this.nevTxt.Location = new System.Drawing.Point(154, 28);
            this.nevTxt.Name = "nevTxt";
            this.nevTxt.Size = new System.Drawing.Size(100, 22);
            this.nevTxt.TabIndex = 4;
            // 
            // eredmenyLbl
            // 
            this.eredmenyLbl.AutoSize = true;
            this.eredmenyLbl.Location = new System.Drawing.Point(36, 198);
            this.eredmenyLbl.Name = "eredmenyLbl";
            this.eredmenyLbl.Size = new System.Drawing.Size(46, 17);
            this.eredmenyLbl.TabIndex = 5;
            this.eredmenyLbl.Text = "label3";
            this.eredmenyLbl.Visible = false;
            // 
            // jegyPtx
            // 
            this.jegyPtx.Location = new System.Drawing.Point(572, 43);
            this.jegyPtx.Name = "jegyPtx";
            this.jegyPtx.Size = new System.Drawing.Size(206, 192);
            this.jegyPtx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.jegyPtx.TabIndex = 6;
            this.jegyPtx.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 305);
            this.Controls.Add(this.jegyPtx);
            this.Controls.Add(this.eredmenyLbl);
            this.Controls.Add(this.nevTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.jegyTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Vizsga eredmények";
            ((System.ComponentModel.ISupportInitialize)(this.jegyPtx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox jegyTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nevTxt;
        private System.Windows.Forms.Label eredmenyLbl;
        private System.Windows.Forms.PictureBox jegyPtx;
    }
}

