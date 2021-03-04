namespace jatek_datumokkal
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
            this.dtTmPckrDatum = new System.Windows.Forms.DateTimePicker();
            this.dtTmPckrIdo = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.talalkozoLbl = new System.Windows.Forms.Label();
            this.aktualisLbl = new System.Windows.Forms.Label();
            this.ertekelesLbl = new System.Windows.Forms.Label();
            this.ertekelBtn = new System.Windows.Forms.Button();
            this.torolBtn = new System.Windows.Forms.Button();
            this.bezarBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "A találkozó ideje:";
            // 
            // dtTmPckrDatum
            // 
            this.dtTmPckrDatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTmPckrDatum.Location = new System.Drawing.Point(203, 61);
            this.dtTmPckrDatum.Name = "dtTmPckrDatum";
            this.dtTmPckrDatum.Size = new System.Drawing.Size(129, 22);
            this.dtTmPckrDatum.TabIndex = 1;
            // 
            // dtTmPckrIdo
            // 
            this.dtTmPckrIdo.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtTmPckrIdo.Location = new System.Drawing.Point(357, 61);
            this.dtTmPckrIdo.Name = "dtTmPckrIdo";
            this.dtTmPckrIdo.ShowUpDown = true;
            this.dtTmPckrIdo.Size = new System.Drawing.Size(127, 22);
            this.dtTmPckrIdo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Találkozó ideje:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Aktuális idő:";
            // 
            // talalkozoLbl
            // 
            this.talalkozoLbl.AutoSize = true;
            this.talalkozoLbl.Location = new System.Drawing.Point(188, 121);
            this.talalkozoLbl.Name = "talalkozoLbl";
            this.talalkozoLbl.Size = new System.Drawing.Size(46, 17);
            this.talalkozoLbl.TabIndex = 5;
            this.talalkozoLbl.Text = "label4";
            // 
            // aktualisLbl
            // 
            this.aktualisLbl.AutoSize = true;
            this.aktualisLbl.Location = new System.Drawing.Point(191, 166);
            this.aktualisLbl.Name = "aktualisLbl";
            this.aktualisLbl.Size = new System.Drawing.Size(46, 17);
            this.aktualisLbl.TabIndex = 6;
            this.aktualisLbl.Text = "label4";
            // 
            // ertekelesLbl
            // 
            this.ertekelesLbl.AutoSize = true;
            this.ertekelesLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ertekelesLbl.ForeColor = System.Drawing.Color.Red;
            this.ertekelesLbl.Location = new System.Drawing.Point(112, 231);
            this.ertekelesLbl.Name = "ertekelesLbl";
            this.ertekelesLbl.Size = new System.Drawing.Size(79, 29);
            this.ertekelesLbl.TabIndex = 7;
            this.ertekelesLbl.Text = "label4";
            this.ertekelesLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ertekelBtn
            // 
            this.ertekelBtn.Location = new System.Drawing.Point(115, 300);
            this.ertekelBtn.Name = "ertekelBtn";
            this.ertekelBtn.Size = new System.Drawing.Size(81, 30);
            this.ertekelBtn.TabIndex = 8;
            this.ertekelBtn.Text = "Értékel";
            this.ertekelBtn.UseVisualStyleBackColor = true;
            this.ertekelBtn.Click += new System.EventHandler(this.ertekelBtn_Click);
            // 
            // torolBtn
            // 
            this.torolBtn.Location = new System.Drawing.Point(318, 300);
            this.torolBtn.Name = "torolBtn";
            this.torolBtn.Size = new System.Drawing.Size(89, 30);
            this.torolBtn.TabIndex = 9;
            this.torolBtn.Text = "Töröl";
            this.torolBtn.UseVisualStyleBackColor = true;
            // 
            // bezarBtn
            // 
            this.bezarBtn.Location = new System.Drawing.Point(203, 369);
            this.bezarBtn.Name = "bezarBtn";
            this.bezarBtn.Size = new System.Drawing.Size(80, 32);
            this.bezarBtn.TabIndex = 10;
            this.bezarBtn.Text = "Bezár";
            this.bezarBtn.UseVisualStyleBackColor = true;
            this.bezarBtn.Click += new System.EventHandler(this.bezarBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 462);
            this.Controls.Add(this.bezarBtn);
            this.Controls.Add(this.torolBtn);
            this.Controls.Add(this.ertekelBtn);
            this.Controls.Add(this.ertekelesLbl);
            this.Controls.Add(this.aktualisLbl);
            this.Controls.Add(this.talalkozoLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtTmPckrIdo);
            this.Controls.Add(this.dtTmPckrDatum);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Találkozó";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtTmPckrDatum;
        private System.Windows.Forms.DateTimePicker dtTmPckrIdo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label talalkozoLbl;
        private System.Windows.Forms.Label aktualisLbl;
        private System.Windows.Forms.Label ertekelesLbl;
        private System.Windows.Forms.Button ertekelBtn;
        private System.Windows.Forms.Button torolBtn;
        private System.Windows.Forms.Button bezarBtn;
    }
}

