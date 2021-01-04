namespace chat
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
            this.components = new System.ComponentModel.Container();
            this.sIP_cim = new System.Windows.Forms.TextBox();
            this.felhiv = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bont = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.uzenetduma = new System.Windows.Forms.Label();
            this.uzenet = new System.Windows.Forms.TextBox();
            this.dumalista = new System.Windows.Forms.ListBox();
            this.kuld = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // sIP_cim
            // 
            this.sIP_cim.Location = new System.Drawing.Point(99, 6);
            this.sIP_cim.Name = "sIP_cim";
            this.sIP_cim.Size = new System.Drawing.Size(100, 20);
            this.sIP_cim.TabIndex = 0;
            // 
            // felhiv
            // 
            this.felhiv.Location = new System.Drawing.Point(205, 6);
            this.felhiv.Name = "felhiv";
            this.felhiv.Size = new System.Drawing.Size(75, 23);
            this.felhiv.TabIndex = 1;
            this.felhiv.Text = "felhív";
            this.felhiv.UseVisualStyleBackColor = true;
            this.felhiv.Click += new System.EventHandler(this.felhiv_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Server IP címe:";
            // 
            // bont
            // 
            this.bont.Location = new System.Drawing.Point(699, 9);
            this.bont.Name = "bont";
            this.bont.Size = new System.Drawing.Size(75, 23);
            this.bont.TabIndex = 3;
            this.bont.Text = "bont";
            this.bont.UseVisualStyleBackColor = true;
            this.bont.Visible = false;
            this.bont.Click += new System.EventHandler(this.bont_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(286, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "STÁTUSZ:";
            // 
            // status
            // 
            this.status.Location = new System.Drawing.Point(352, 11);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(194, 18);
            this.status.TabIndex = 5;
            this.status.Text = "xxxx";
            // 
            // uzenetduma
            // 
            this.uzenetduma.AutoSize = true;
            this.uzenetduma.Location = new System.Drawing.Point(12, 51);
            this.uzenetduma.Name = "uzenetduma";
            this.uzenetduma.Size = new System.Drawing.Size(42, 13);
            this.uzenetduma.TabIndex = 6;
            this.uzenetduma.Text = "üzenet:";
            this.uzenetduma.Visible = false;
            // 
            // uzenet
            // 
            this.uzenet.Location = new System.Drawing.Point(60, 48);
            this.uzenet.Name = "uzenet";
            this.uzenet.Size = new System.Drawing.Size(631, 20);
            this.uzenet.TabIndex = 7;
            this.uzenet.Visible = false;
            this.uzenet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onenter);
            // 
            // dumalista
            // 
            this.dumalista.FormattingEnabled = true;
            this.dumalista.Location = new System.Drawing.Point(12, 74);
            this.dumalista.Name = "dumalista";
            this.dumalista.Size = new System.Drawing.Size(762, 368);
            this.dumalista.TabIndex = 8;
            this.dumalista.Visible = false;
            // 
            // kuld
            // 
            this.kuld.Location = new System.Drawing.Point(699, 46);
            this.kuld.Name = "kuld";
            this.kuld.Size = new System.Drawing.Size(75, 23);
            this.kuld.TabIndex = 9;
            this.kuld.Text = "küld";
            this.kuld.UseVisualStyleBackColor = true;
            this.kuld.Visible = false;
            this.kuld.Click += new System.EventHandler(this.kuld_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.idovan);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 461);
            this.Controls.Add(this.kuld);
            this.Controls.Add(this.dumalista);
            this.Controls.Add(this.uzenet);
            this.Controls.Add(this.uzenetduma);
            this.Controls.Add(this.status);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bont);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.felhiv);
            this.Controls.Add(this.sIP_cim);
            this.Name = "Form1";
            this.Text = "kliens";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sIP_cim;
        private System.Windows.Forms.Button felhiv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bont;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Label uzenetduma;
        private System.Windows.Forms.TextBox uzenet;
        private System.Windows.Forms.ListBox dumalista;
        private System.Windows.Forms.Button kuld;
        private System.Windows.Forms.Timer timer1;
    }
}

