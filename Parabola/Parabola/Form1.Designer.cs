namespace Parabola
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
            this.aTxt = new System.Windows.Forms.TextBox();
            this.cTxt = new System.Windows.Forms.TextBox();
            this.bTxt = new System.Windows.Forms.TextBox();
            this.gyokokBtn = new System.Windows.Forms.Button();
            this.kilepBtn = new System.Windows.Forms.Button();
            this.valaszLbl = new System.Windows.Forms.Label();
            this.valasz1Lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(93, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "x² +            x +           = 0";
            // 
            // aTxt
            // 
            this.aTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.aTxt.Location = new System.Drawing.Point(25, 61);
            this.aTxt.Name = "aTxt";
            this.aTxt.Size = new System.Drawing.Size(62, 38);
            this.aTxt.TabIndex = 1;
            // 
            // cTxt
            // 
            this.cTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cTxt.Location = new System.Drawing.Point(277, 61);
            this.cTxt.Name = "cTxt";
            this.cTxt.Size = new System.Drawing.Size(62, 38);
            this.cTxt.TabIndex = 2;
            // 
            // bTxt
            // 
            this.bTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bTxt.Location = new System.Drawing.Point(161, 61);
            this.bTxt.Name = "bTxt";
            this.bTxt.Size = new System.Drawing.Size(62, 38);
            this.bTxt.TabIndex = 3;
            // 
            // gyokokBtn
            // 
            this.gyokokBtn.Location = new System.Drawing.Point(128, 157);
            this.gyokokBtn.Name = "gyokokBtn";
            this.gyokokBtn.Size = new System.Drawing.Size(151, 23);
            this.gyokokBtn.TabIndex = 4;
            this.gyokokBtn.Text = "Gyökök meghatározása";
            this.gyokokBtn.UseVisualStyleBackColor = true;
            this.gyokokBtn.Click += new System.EventHandler(this.gyokokBtn_Click);
            // 
            // kilepBtn
            // 
            this.kilepBtn.Location = new System.Drawing.Point(356, 378);
            this.kilepBtn.Name = "kilepBtn";
            this.kilepBtn.Size = new System.Drawing.Size(75, 23);
            this.kilepBtn.TabIndex = 5;
            this.kilepBtn.Text = "Kilépés";
            this.kilepBtn.UseVisualStyleBackColor = true;
            this.kilepBtn.Click += new System.EventHandler(this.kilepBtn_Click);
            // 
            // valaszLbl
            // 
            this.valaszLbl.AutoSize = true;
            this.valaszLbl.Location = new System.Drawing.Point(39, 265);
            this.valaszLbl.Name = "valaszLbl";
            this.valaszLbl.Size = new System.Drawing.Size(38, 13);
            this.valaszLbl.TabIndex = 6;
            this.valaszLbl.Text = "Válasz";
            this.valaszLbl.Visible = false;
            // 
            // valasz1Lbl
            // 
            this.valasz1Lbl.AutoSize = true;
            this.valasz1Lbl.Location = new System.Drawing.Point(42, 302);
            this.valasz1Lbl.Name = "valasz1Lbl";
            this.valasz1Lbl.Size = new System.Drawing.Size(38, 13);
            this.valasz1Lbl.TabIndex = 7;
            this.valasz1Lbl.Text = "Válasz";
            this.valasz1Lbl.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 431);
            this.Controls.Add(this.valasz1Lbl);
            this.Controls.Add(this.valaszLbl);
            this.Controls.Add(this.kilepBtn);
            this.Controls.Add(this.gyokokBtn);
            this.Controls.Add(this.bTxt);
            this.Controls.Add(this.cTxt);
            this.Controls.Add(this.aTxt);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Másodfokú egyenlet megoldásai";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox aTxt;
        private System.Windows.Forms.TextBox cTxt;
        private System.Windows.Forms.TextBox bTxt;
        private System.Windows.Forms.Button gyokokBtn;
        private System.Windows.Forms.Button kilepBtn;
        private System.Windows.Forms.Label valaszLbl;
        private System.Windows.Forms.Label valasz1Lbl;
    }
}

