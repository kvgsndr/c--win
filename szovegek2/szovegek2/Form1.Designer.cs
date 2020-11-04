namespace szovegek2
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
            this.kbetuLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nevTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.karTxt = new System.Windows.Forms.TextBox();
            this.karLbl = new System.Windows.Forms.Label();
            this.ellenorizBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.kodolBtn = new System.Windows.Forms.Button();
            this.generalBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.vnevTxt = new System.Windows.Forms.TextBox();
            this.knevTxt = new System.Windows.Forms.TextBox();
            this.fnevLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // kbetuLbl
            // 
            this.kbetuLbl.AutoSize = true;
            this.kbetuLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kbetuLbl.Location = new System.Drawing.Point(74, 103);
            this.kbetuLbl.Name = "kbetuLbl";
            this.kbetuLbl.Size = new System.Drawing.Size(53, 20);
            this.kbetuLbl.TabIndex = 0;
            this.kbetuLbl.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(74, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Név:";
            // 
            // nevTxt
            // 
            this.nevTxt.Location = new System.Drawing.Point(143, 50);
            this.nevTxt.Name = "nevTxt";
            this.nevTxt.Size = new System.Drawing.Size(227, 22);
            this.nevTxt.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(31, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Add meg a karakter kódját!";
            // 
            // karTxt
            // 
            this.karTxt.Location = new System.Drawing.Point(353, 234);
            this.karTxt.Name = "karTxt";
            this.karTxt.Size = new System.Drawing.Size(100, 22);
            this.karTxt.TabIndex = 6;
            // 
            // karLbl
            // 
            this.karLbl.AutoSize = true;
            this.karLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.karLbl.Location = new System.Drawing.Point(277, 338);
            this.karLbl.Name = "karLbl";
            this.karLbl.Size = new System.Drawing.Size(64, 25);
            this.karLbl.TabIndex = 7;
            this.karLbl.Text = "label4";
            this.karLbl.Visible = false;
            // 
            // ellenorizBtn
            // 
            this.ellenorizBtn.BackColor = System.Drawing.Color.Blue;
            this.ellenorizBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ellenorizBtn.ForeColor = System.Drawing.Color.White;
            this.ellenorizBtn.Location = new System.Drawing.Point(78, 151);
            this.ellenorizBtn.Name = "ellenorizBtn";
            this.ellenorizBtn.Size = new System.Drawing.Size(152, 46);
            this.ellenorizBtn.TabIndex = 8;
            this.ellenorizBtn.Text = "Ellenőriz!";
            this.ellenorizBtn.UseVisualStyleBackColor = false;
            this.ellenorizBtn.Click += new System.EventHandler(this.ellenorizBtn_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(160, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "A karakter:";
            // 
            // kodolBtn
            // 
            this.kodolBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.kodolBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kodolBtn.ForeColor = System.Drawing.Color.White;
            this.kodolBtn.Location = new System.Drawing.Point(342, 276);
            this.kodolBtn.Name = "kodolBtn";
            this.kodolBtn.Size = new System.Drawing.Size(111, 45);
            this.kodolBtn.TabIndex = 10;
            this.kodolBtn.Text = "Kódolj!";
            this.kodolBtn.UseVisualStyleBackColor = false;
            this.kodolBtn.Click += new System.EventHandler(this.kodolBtn_Click);
            // 
            // generalBtn
            // 
            this.generalBtn.Location = new System.Drawing.Point(711, 184);
            this.generalBtn.Name = "generalBtn";
            this.generalBtn.Size = new System.Drawing.Size(216, 34);
            this.generalBtn.TabIndex = 11;
            this.generalBtn.Text = "Felhasználó név generálás";
            this.generalBtn.UseVisualStyleBackColor = true;
            this.generalBtn.Click += new System.EventHandler(this.generalBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(691, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Vezetéknév:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(691, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Keresztnév:";
            // 
            // vnevTxt
            // 
            this.vnevTxt.Location = new System.Drawing.Point(816, 69);
            this.vnevTxt.Name = "vnevTxt";
            this.vnevTxt.Size = new System.Drawing.Size(100, 22);
            this.vnevTxt.TabIndex = 14;
            // 
            // knevTxt
            // 
            this.knevTxt.Location = new System.Drawing.Point(816, 120);
            this.knevTxt.Name = "knevTxt";
            this.knevTxt.Size = new System.Drawing.Size(100, 22);
            this.knevTxt.TabIndex = 15;
            // 
            // fnevLbl
            // 
            this.fnevLbl.AutoSize = true;
            this.fnevLbl.Location = new System.Drawing.Point(787, 260);
            this.fnevLbl.Name = "fnevLbl";
            this.fnevLbl.Size = new System.Drawing.Size(46, 17);
            this.fnevLbl.TabIndex = 16;
            this.fnevLbl.Text = "label6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 404);
            this.Controls.Add(this.fnevLbl);
            this.Controls.Add(this.knevTxt);
            this.Controls.Add(this.vnevTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.generalBtn);
            this.Controls.Add(this.kodolBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ellenorizBtn);
            this.Controls.Add(this.karLbl);
            this.Controls.Add(this.karTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nevTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.kbetuLbl);
            this.Name = "Form1";
            this.Text = "Karakterek";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label kbetuLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nevTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox karTxt;
        private System.Windows.Forms.Label karLbl;
        private System.Windows.Forms.Button ellenorizBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button kodolBtn;
        private System.Windows.Forms.Button generalBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox vnevTxt;
        private System.Windows.Forms.TextBox knevTxt;
        private System.Windows.Forms.Label fnevLbl;
    }
}

