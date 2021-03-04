namespace Fogyasztas
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
            this.literLbl = new System.Windows.Forms.Label();
            this.kmLbl = new System.Windows.Forms.Label();
            this.fogyasztasLbl = new System.Windows.Forms.Label();
            this.lTxt = new System.Windows.Forms.TextBox();
            this.kmTxt = new System.Windows.Forms.TextBox();
            this.szamolBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // literLbl
            // 
            this.literLbl.AutoSize = true;
            this.literLbl.Location = new System.Drawing.Point(80, 76);
            this.literLbl.Name = "literLbl";
            this.literLbl.Size = new System.Drawing.Size(80, 13);
            this.literLbl.TabIndex = 0;
            this.literLbl.Text = "Üzemanyag (l): ";
            // 
            // kmLbl
            // 
            this.kmLbl.AutoSize = true;
            this.kmLbl.Location = new System.Drawing.Point(83, 122);
            this.kmLbl.Name = "kmLbl";
            this.kmLbl.Size = new System.Drawing.Size(90, 13);
            this.kmLbl.TabIndex = 1;
            this.kmLbl.Text = "Megtett táv (km): ";
            // 
            // fogyasztasLbl
            // 
            this.fogyasztasLbl.AutoSize = true;
            this.fogyasztasLbl.Location = new System.Drawing.Point(83, 259);
            this.fogyasztasLbl.Name = "fogyasztasLbl";
            this.fogyasztasLbl.Size = new System.Drawing.Size(35, 13);
            this.fogyasztasLbl.TabIndex = 2;
            this.fogyasztasLbl.Text = "label3";
            this.fogyasztasLbl.Visible = false;
            // 
            // lTxt
            // 
            this.lTxt.Location = new System.Drawing.Point(194, 68);
            this.lTxt.Name = "lTxt";
            this.lTxt.Size = new System.Drawing.Size(100, 20);
            this.lTxt.TabIndex = 3;
            // 
            // kmTxt
            // 
            this.kmTxt.Location = new System.Drawing.Point(194, 114);
            this.kmTxt.Name = "kmTxt";
            this.kmTxt.Size = new System.Drawing.Size(100, 20);
            this.kmTxt.TabIndex = 4;
            // 
            // szamolBtn
            // 
            this.szamolBtn.Location = new System.Drawing.Point(167, 189);
            this.szamolBtn.Name = "szamolBtn";
            this.szamolBtn.Size = new System.Drawing.Size(75, 23);
            this.szamolBtn.TabIndex = 5;
            this.szamolBtn.Text = "Számít";
            this.szamolBtn.UseVisualStyleBackColor = true;
            this.szamolBtn.Click += new System.EventHandler(this.szamolBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 456);
            this.Controls.Add(this.szamolBtn);
            this.Controls.Add(this.kmTxt);
            this.Controls.Add(this.lTxt);
            this.Controls.Add(this.fogyasztasLbl);
            this.Controls.Add(this.kmLbl);
            this.Controls.Add(this.literLbl);
            this.Name = "Form1";
            this.Text = "Fogyasztás";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label literLbl;
        private System.Windows.Forms.Label kmLbl;
        private System.Windows.Forms.Label fogyasztasLbl;
        private System.Windows.Forms.TextBox lTxt;
        private System.Windows.Forms.TextBox kmTxt;
        private System.Windows.Forms.Button szamolBtn;
    }
}

