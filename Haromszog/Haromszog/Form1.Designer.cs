namespace haromszog
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
            this.aTxt = new System.Windows.Forms.TextBox();
            this.bTxt = new System.Windows.Forms.TextBox();
            this.cTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.kiirLbl = new System.Windows.Forms.Label();
            this.kiir2Lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // aTxt
            // 
            this.aTxt.Location = new System.Drawing.Point(229, 25);
            this.aTxt.Name = "aTxt";
            this.aTxt.Size = new System.Drawing.Size(125, 20);
            this.aTxt.TabIndex = 0;
            // 
            // bTxt
            // 
            this.bTxt.Location = new System.Drawing.Point(229, 67);
            this.bTxt.Name = "bTxt";
            this.bTxt.Size = new System.Drawing.Size(124, 20);
            this.bTxt.TabIndex = 1;
            // 
            // cTxt
            // 
            this.cTxt.Location = new System.Drawing.Point(230, 111);
            this.cTxt.Name = "cTxt";
            this.cTxt.Size = new System.Drawing.Size(124, 20);
            this.cTxt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(171, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "a oldal:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(173, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "b oldal:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(173, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "c oldal:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(203, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 30);
            this.button1.TabIndex = 6;
            this.button1.Text = "Ellenőrzés";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // kiirLbl
            // 
            this.kiirLbl.AutoSize = true;
            this.kiirLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kiirLbl.Location = new System.Drawing.Point(104, 211);
            this.kiirLbl.Name = "kiirLbl";
            this.kiirLbl.Size = new System.Drawing.Size(45, 16);
            this.kiirLbl.TabIndex = 7;
            this.kiirLbl.Text = "label4";
            this.kiirLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.kiirLbl.Visible = false;
            // 
            // kiir2Lbl
            // 
            this.kiir2Lbl.AutoSize = true;
            this.kiir2Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kiir2Lbl.Location = new System.Drawing.Point(104, 249);
            this.kiir2Lbl.Name = "kiir2Lbl";
            this.kiir2Lbl.Size = new System.Drawing.Size(45, 16);
            this.kiir2Lbl.TabIndex = 8;
            this.kiir2Lbl.Text = "label4";
            this.kiir2Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.kiir2Lbl.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 366);
            this.Controls.Add(this.kiir2Lbl);
            this.Controls.Add(this.kiirLbl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cTxt);
            this.Controls.Add(this.bTxt);
            this.Controls.Add(this.aTxt);
            this.Name = "Form1";
            this.Text = "Háromszög-e?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox aTxt;
        private System.Windows.Forms.TextBox bTxt;
        private System.Windows.Forms.TextBox cTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label kiirLbl;
        private System.Windows.Forms.Label kiir2Lbl;
    }
}

