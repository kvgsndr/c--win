namespace belepok
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
            this.korTxt = new System.Windows.Forms.TextBox();
            this.kiirLbl = new System.Windows.Forms.Label();
            this.kepPcBx = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fizetesBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.d3chbx = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.kepPcBx)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hány éves vagy?";
            // 
            // korTxt
            // 
            this.korTxt.Location = new System.Drawing.Point(188, 113);
            this.korTxt.Name = "korTxt";
            this.korTxt.Size = new System.Drawing.Size(100, 22);
            this.korTxt.TabIndex = 1;
            // 
            // kiirLbl
            // 
            this.kiirLbl.AutoSize = true;
            this.kiirLbl.Location = new System.Drawing.Point(214, 322);
            this.kiirLbl.Name = "kiirLbl";
            this.kiirLbl.Size = new System.Drawing.Size(46, 17);
            this.kiirLbl.TabIndex = 2;
            this.kiirLbl.Text = "label2";
            // 
            // kepPcBx
            // 
            this.kepPcBx.Location = new System.Drawing.Point(469, 113);
            this.kepPcBx.Name = "kepPcBx";
            this.kepPcBx.Size = new System.Drawing.Size(210, 226);
            this.kepPcBx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kepPcBx.TabIndex = 3;
            this.kepPcBx.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.Purple;
            this.label3.Location = new System.Drawing.Point(305, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 72);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mozi";
            // 
            // fizetesBtn
            // 
            this.fizetesBtn.Location = new System.Drawing.Point(49, 234);
            this.fizetesBtn.Name = "fizetesBtn";
            this.fizetesBtn.Size = new System.Drawing.Size(92, 42);
            this.fizetesBtn.TabIndex = 5;
            this.fizetesBtn.Text = "Fizetés";
            this.fizetesBtn.UseVisualStyleBackColor = true;
            this.fizetesBtn.Click += new System.EventHandler(this.fizetesBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "A fizetendő összeg:";
            // 
            // d3chbx
            // 
            this.d3chbx.AutoSize = true;
            this.d3chbx.Location = new System.Drawing.Point(49, 180);
            this.d3chbx.Name = "d3chbx";
            this.d3chbx.Size = new System.Drawing.Size(90, 21);
            this.d3chbx.TabIndex = 7;
            this.d3chbx.Text = "3D (10%)";
            this.d3chbx.UseVisualStyleBackColor = true;
      
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.d3chbx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fizetesBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.kepPcBx);
            this.Controls.Add(this.kiirLbl);
            this.Controls.Add(this.korTxt);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Belépőjegy árak";
            ((System.ComponentModel.ISupportInitialize)(this.kepPcBx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox korTxt;
        private System.Windows.Forms.Label kiirLbl;
        private System.Windows.Forms.PictureBox kepPcBx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button fizetesBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox d3chbx;
    }
}

