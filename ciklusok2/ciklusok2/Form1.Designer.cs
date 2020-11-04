namespace ciklusok2
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
            this.label2 = new System.Windows.Forms.Label();
            this.kezdoTxb = new System.Windows.Forms.TextBox();
            this.vegsoTxb = new System.Windows.Forms.TextBox();
            this.osszegBtn = new System.Windows.Forms.Button();
            this.osszegLbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.parososszegLbl = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.paratlanosszegLbl = new System.Windows.Forms.Label();
            this.osztokRTxb = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.szamTxb = new System.Windows.Forms.TextBox();
            this.osztokBtn = new System.Windows.Forms.Button();
            this.torolBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kezdőérték:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Végső érték:";
            // 
            // kezdoTxb
            // 
            this.kezdoTxb.Location = new System.Drawing.Point(159, 38);
            this.kezdoTxb.Margin = new System.Windows.Forms.Padding(4);
            this.kezdoTxb.Name = "kezdoTxb";
            this.kezdoTxb.Size = new System.Drawing.Size(132, 22);
            this.kezdoTxb.TabIndex = 2;
            // 
            // vegsoTxb
            // 
            this.vegsoTxb.Location = new System.Drawing.Point(159, 80);
            this.vegsoTxb.Margin = new System.Windows.Forms.Padding(4);
            this.vegsoTxb.Name = "vegsoTxb";
            this.vegsoTxb.Size = new System.Drawing.Size(132, 22);
            this.vegsoTxb.TabIndex = 3;
            // 
            // osszegBtn
            // 
            this.osszegBtn.Location = new System.Drawing.Point(389, 38);
            this.osszegBtn.Margin = new System.Windows.Forms.Padding(4);
            this.osszegBtn.Name = "osszegBtn";
            this.osszegBtn.Size = new System.Drawing.Size(140, 64);
            this.osszegBtn.TabIndex = 4;
            this.osszegBtn.Text = "Összeg";
            this.osszegBtn.UseVisualStyleBackColor = true;
            this.osszegBtn.Click += new System.EventHandler(this.osszegBtn_Click);
            // 
            // osszegLbl
            // 
            this.osszegLbl.AutoSize = true;
            this.osszegLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.osszegLbl.Location = new System.Drawing.Point(600, 55);
            this.osszegLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.osszegLbl.Name = "osszegLbl";
            this.osszegLbl.Size = new System.Drawing.Size(64, 25);
            this.osszegLbl.TabIndex = 5;
            this.osszegLbl.Text = "label3";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(389, 146);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 49);
            this.button1.TabIndex = 6;
            this.button1.Text = "Páros összeg";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // parososszegLbl
            // 
            this.parososszegLbl.AutoSize = true;
            this.parososszegLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.parososszegLbl.Location = new System.Drawing.Point(600, 155);
            this.parososszegLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.parososszegLbl.Name = "parososszegLbl";
            this.parososszegLbl.Size = new System.Drawing.Size(64, 25);
            this.parososszegLbl.TabIndex = 7;
            this.parososszegLbl.Text = "label3";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(389, 224);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 58);
            this.button2.TabIndex = 8;
            this.button2.Text = "Páratlan összeg:";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // paratlanosszegLbl
            // 
            this.paratlanosszegLbl.AutoSize = true;
            this.paratlanosszegLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.paratlanosszegLbl.Location = new System.Drawing.Point(600, 238);
            this.paratlanosszegLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.paratlanosszegLbl.Name = "paratlanosszegLbl";
            this.paratlanosszegLbl.Size = new System.Drawing.Size(64, 25);
            this.paratlanosszegLbl.TabIndex = 9;
            this.paratlanosszegLbl.Text = "label3";
            // 
            // osztokRTxb
            // 
            this.osztokRTxb.Location = new System.Drawing.Point(40, 155);
            this.osztokRTxb.Name = "osztokRTxb";
            this.osztokRTxb.Size = new System.Drawing.Size(63, 155);
            this.osztokRTxb.TabIndex = 10;
            this.osztokRTxb.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "osztók";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(129, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "szám:";
            // 
            // szamTxb
            // 
            this.szamTxb.Location = new System.Drawing.Point(132, 182);
            this.szamTxb.Name = "szamTxb";
            this.szamTxb.Size = new System.Drawing.Size(100, 22);
            this.szamTxb.TabIndex = 13;
            // 
            // osztokBtn
            // 
            this.osztokBtn.Location = new System.Drawing.Point(132, 210);
            this.osztokBtn.Name = "osztokBtn";
            this.osztokBtn.Size = new System.Drawing.Size(75, 23);
            this.osztokBtn.TabIndex = 14;
            this.osztokBtn.Text = "Osztók?";
            this.osztokBtn.UseVisualStyleBackColor = true;
            this.osztokBtn.Click += new System.EventHandler(this.osztokBtn_Click);
            // 
            // torolBtn
            // 
            this.torolBtn.Location = new System.Drawing.Point(251, 286);
            this.torolBtn.Name = "torolBtn";
            this.torolBtn.Size = new System.Drawing.Size(75, 23);
            this.torolBtn.TabIndex = 15;
            this.torolBtn.Text = "Törlés";
            this.torolBtn.UseVisualStyleBackColor = true;
            this.torolBtn.Click += new System.EventHandler(this.torolBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 331);
            this.Controls.Add(this.torolBtn);
            this.Controls.Add(this.osztokBtn);
            this.Controls.Add(this.szamTxb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.osztokRTxb);
            this.Controls.Add(this.paratlanosszegLbl);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.parososszegLbl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.osszegLbl);
            this.Controls.Add(this.osszegBtn);
            this.Controls.Add(this.vegsoTxb);
            this.Controls.Add(this.kezdoTxb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox kezdoTxb;
        private System.Windows.Forms.TextBox vegsoTxb;
        private System.Windows.Forms.Button osszegBtn;
        private System.Windows.Forms.Label osszegLbl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label parososszegLbl;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label paratlanosszegLbl;
        private System.Windows.Forms.RichTextBox osztokRTxb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox szamTxb;
        private System.Windows.Forms.Button osztokBtn;
        private System.Windows.Forms.Button torolBtn;
    }
}

