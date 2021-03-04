namespace Ugras
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
            this.ugrikBtn = new System.Windows.Forms.Button();
            this.xLbl = new System.Windows.Forms.Label();
            this.yLbl = new System.Windows.Forms.Label();
            this.xTxt = new System.Windows.Forms.TextBox();
            this.yTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ugrikBtn
            // 
            this.ugrikBtn.Location = new System.Drawing.Point(344, 276);
            this.ugrikBtn.Name = "ugrikBtn";
            this.ugrikBtn.Size = new System.Drawing.Size(75, 23);
            this.ugrikBtn.TabIndex = 0;
            this.ugrikBtn.Text = "Ugró";
            this.ugrikBtn.UseVisualStyleBackColor = true;
            this.ugrikBtn.Click += new System.EventHandler(this.ugrikBtn_Click);
            // 
            // xLbl
            // 
            this.xLbl.AutoSize = true;
            this.xLbl.Location = new System.Drawing.Point(44, 57);
            this.xLbl.Name = "xLbl";
            this.xLbl.Size = new System.Drawing.Size(68, 13);
            this.xLbl.TabIndex = 1;
            this.xLbl.Text = "x koordináta:";
            // 
            // yLbl
            // 
            this.yLbl.AutoSize = true;
            this.yLbl.Location = new System.Drawing.Point(265, 57);
            this.yLbl.Name = "yLbl";
            this.yLbl.Size = new System.Drawing.Size(68, 13);
            this.yLbl.TabIndex = 2;
            this.yLbl.Text = "y koordináta:";
            // 
            // xTxt
            // 
            this.xTxt.Location = new System.Drawing.Point(119, 49);
            this.xTxt.Name = "xTxt";
            this.xTxt.Size = new System.Drawing.Size(100, 20);
            this.xTxt.TabIndex = 3;
            // 
            // yTxt
            // 
            this.yTxt.Location = new System.Drawing.Point(340, 48);
            this.yTxt.Name = "yTxt";
            this.yTxt.Size = new System.Drawing.Size(100, 20);
            this.yTxt.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.yTxt);
            this.Controls.Add(this.xTxt);
            this.Controls.Add(this.yLbl);
            this.Controls.Add(this.xLbl);
            this.Controls.Add(this.ugrikBtn);
            this.Name = "Form1";
            this.Text = "Ugrás";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ugrikBtn;
        private System.Windows.Forms.Label xLbl;
        private System.Windows.Forms.Label yLbl;
        private System.Windows.Forms.TextBox xTxt;
        private System.Windows.Forms.TextBox yTxt;
    }
}

