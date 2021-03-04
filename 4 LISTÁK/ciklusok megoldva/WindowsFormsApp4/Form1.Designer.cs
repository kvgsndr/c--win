namespace WindowsFormsApp4
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
            this.elsoBtn = new System.Windows.Forms.Button();
            this.listaLb = new System.Windows.Forms.ListBox();
            this.masodikBtn = new System.Windows.Forms.Button();
            this.harmadikBtn = new System.Windows.Forms.Button();
            this.negyedikBtn = new System.Windows.Forms.Button();
            this.otodikBtn = new System.Windows.Forms.Button();
            this.ABCBTN = new System.Windows.Forms.Button();
            this.torolBtn = new System.Windows.Forms.Button();
            this.kilepesBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // elsoBtn
            // 
            this.elsoBtn.Location = new System.Drawing.Point(258, 71);
            this.elsoBtn.Name = "elsoBtn";
            this.elsoBtn.Size = new System.Drawing.Size(192, 38);
            this.elsoBtn.TabIndex = 0;
            this.elsoBtn.Text = "Első 10 természetes szám";
            this.elsoBtn.UseVisualStyleBackColor = true;
            this.elsoBtn.Click += new System.EventHandler(this.elsoBtn_Click);
            // 
            // listaLb
            // 
            this.listaLb.FormattingEnabled = true;
            this.listaLb.Location = new System.Drawing.Point(66, 71);
            this.listaLb.Name = "listaLb";
            this.listaLb.Size = new System.Drawing.Size(120, 95);
            this.listaLb.TabIndex = 1;
            // 
            // masodikBtn
            // 
            this.masodikBtn.Location = new System.Drawing.Point(258, 129);
            this.masodikBtn.Name = "masodikBtn";
            this.masodikBtn.Size = new System.Drawing.Size(192, 37);
            this.masodikBtn.TabIndex = 2;
            this.masodikBtn.Text = "Első 15 páros szám";
            this.masodikBtn.UseVisualStyleBackColor = true;
            this.masodikBtn.Click += new System.EventHandler(this.masodikBtn_Click);
            // 
            // harmadikBtn
            // 
            this.harmadikBtn.Location = new System.Drawing.Point(258, 191);
            this.harmadikBtn.Name = "harmadikBtn";
            this.harmadikBtn.Size = new System.Drawing.Size(192, 36);
            this.harmadikBtn.TabIndex = 3;
            this.harmadikBtn.Text = "Első 12 négyzetszám";
            this.harmadikBtn.UseVisualStyleBackColor = true;
            this.harmadikBtn.Click += new System.EventHandler(this.harmadikBtn_Click);
            // 
            // negyedikBtn
            // 
            this.negyedikBtn.Location = new System.Drawing.Point(258, 252);
            this.negyedikBtn.Name = "negyedikBtn";
            this.negyedikBtn.Size = new System.Drawing.Size(192, 39);
            this.negyedikBtn.TabIndex = 4;
            this.negyedikBtn.Text = "2 első 10 hatvványa";
            this.negyedikBtn.UseVisualStyleBackColor = true;
            this.negyedikBtn.Click += new System.EventHandler(this.negyedikBtn_Click);
            // 
            // otodikBtn
            // 
            this.otodikBtn.Location = new System.Drawing.Point(258, 310);
            this.otodikBtn.Name = "otodikBtn";
            this.otodikBtn.Size = new System.Drawing.Size(192, 39);
            this.otodikBtn.TabIndex = 5;
            this.otodikBtn.Text = "2 első 10 hatvványa másként";
            this.otodikBtn.UseVisualStyleBackColor = true;
            this.otodikBtn.Click += new System.EventHandler(this.otodikBtn_Click);
            // 
            // ABCBTN
            // 
            this.ABCBTN.Location = new System.Drawing.Point(258, 370);
            this.ABCBTN.Name = "ABCBTN";
            this.ABCBTN.Size = new System.Drawing.Size(192, 39);
            this.ABCBTN.TabIndex = 6;
            this.ABCBTN.Text = "ABC nagybetűi";
            this.ABCBTN.UseVisualStyleBackColor = true;
            this.ABCBTN.Click += new System.EventHandler(this.ABCBTN_Click);
            // 
            // torolBtn
            // 
            this.torolBtn.Location = new System.Drawing.Point(559, 78);
            this.torolBtn.Name = "torolBtn";
            this.torolBtn.Size = new System.Drawing.Size(125, 25);
            this.torolBtn.TabIndex = 8;
            this.torolBtn.Text = "töröl";
            this.torolBtn.UseVisualStyleBackColor = true;
            this.torolBtn.Click += new System.EventHandler(this.torolBtn_Click);
            // 
            // kilepesBtn
            // 
            this.kilepesBtn.Location = new System.Drawing.Point(581, 432);
            this.kilepesBtn.Name = "kilepesBtn";
            this.kilepesBtn.Size = new System.Drawing.Size(103, 32);
            this.kilepesBtn.TabIndex = 9;
            this.kilepesBtn.Text = "Kilépés";
            this.kilepesBtn.UseVisualStyleBackColor = true;
            this.kilepesBtn.Click += new System.EventHandler(this.kilepesBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 498);
            this.Controls.Add(this.kilepesBtn);
            this.Controls.Add(this.torolBtn);
            this.Controls.Add(this.ABCBTN);
            this.Controls.Add(this.otodikBtn);
            this.Controls.Add(this.negyedikBtn);
            this.Controls.Add(this.harmadikBtn);
            this.Controls.Add(this.masodikBtn);
            this.Controls.Add(this.listaLb);
            this.Controls.Add(this.elsoBtn);
            this.Name = "Form1";
            this.Text = "Ciklusok";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button elsoBtn;
        private System.Windows.Forms.ListBox listaLb;
        private System.Windows.Forms.Button masodikBtn;
        private System.Windows.Forms.Button harmadikBtn;
        private System.Windows.Forms.Button negyedikBtn;
        private System.Windows.Forms.Button otodikBtn;
        private System.Windows.Forms.Button ABCBTN;
        private System.Windows.Forms.Button torolBtn;
        private System.Windows.Forms.Button kilepesBtn;
    }
}

