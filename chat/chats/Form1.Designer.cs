namespace chats
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
            this.kuld = new System.Windows.Forms.Button();
            this.dumalista = new System.Windows.Forms.ListBox();
            this.uzenet = new System.Windows.Forms.TextBox();
            this.uzenetduma = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bont = new System.Windows.Forms.Button();
            this.hallgatba = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // kuld
            // 
            this.kuld.Location = new System.Drawing.Point(702, 48);
            this.kuld.Name = "kuld";
            this.kuld.Size = new System.Drawing.Size(75, 23);
            this.kuld.TabIndex = 19;
            this.kuld.Text = "küld";
            this.kuld.UseVisualStyleBackColor = true;
            this.kuld.Visible = false;
            this.kuld.Click += new System.EventHandler(this.kuld_Click);
            // 
            // dumalista
            // 
            this.dumalista.FormattingEnabled = true;
            this.dumalista.Location = new System.Drawing.Point(15, 76);
            this.dumalista.Name = "dumalista";
            this.dumalista.Size = new System.Drawing.Size(762, 368);
            this.dumalista.TabIndex = 18;
            this.dumalista.Visible = false;
            // 
            // uzenet
            // 
            this.uzenet.Location = new System.Drawing.Point(63, 50);
            this.uzenet.Name = "uzenet";
            this.uzenet.Size = new System.Drawing.Size(631, 20);
            this.uzenet.TabIndex = 17;
            this.uzenet.Visible = false;
            this.uzenet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dumaenter);
            // 
            // uzenetduma
            // 
            this.uzenetduma.AutoSize = true;
            this.uzenetduma.Location = new System.Drawing.Point(15, 53);
            this.uzenetduma.Name = "uzenetduma";
            this.uzenetduma.Size = new System.Drawing.Size(42, 13);
            this.uzenetduma.TabIndex = 16;
            this.uzenetduma.Text = "üzenet:";
            this.uzenetduma.Visible = false;
            // 
            // status
            // 
            this.status.Location = new System.Drawing.Point(355, 13);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(194, 18);
            this.status.TabIndex = 15;
            this.status.Text = "xxxx";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "STÁTUSZ:";
            // 
            // bont
            // 
            this.bont.Location = new System.Drawing.Point(702, 11);
            this.bont.Name = "bont";
            this.bont.Size = new System.Drawing.Size(75, 23);
            this.bont.TabIndex = 13;
            this.bont.Text = "bont";
            this.bont.UseVisualStyleBackColor = true;
            this.bont.Visible = false;
            this.bont.Click += new System.EventHandler(this.bont_Click);
            // 
            // hallgatba
            // 
            this.hallgatba.Location = new System.Drawing.Point(18, 12);
            this.hallgatba.Name = "hallgatba";
            this.hallgatba.Size = new System.Drawing.Size(75, 23);
            this.hallgatba.TabIndex = 20;
            this.hallgatba.Text = "hallgatóba";
            this.hallgatba.UseVisualStyleBackColor = true;
            this.hallgatba.Click += new System.EventHandler(this.hallgatba_Click);
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
            this.ClientSize = new System.Drawing.Size(794, 451);
            this.Controls.Add(this.hallgatba);
            this.Controls.Add(this.kuld);
            this.Controls.Add(this.dumalista);
            this.Controls.Add(this.uzenet);
            this.Controls.Add(this.uzenetduma);
            this.Controls.Add(this.status);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bont);
            this.Name = "Form1";
            this.Text = "server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button kuld;
        private System.Windows.Forms.ListBox dumalista;
        private System.Windows.Forms.TextBox uzenet;
        private System.Windows.Forms.Label uzenetduma;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bont;
        private System.Windows.Forms.Button hallgatba;
        private System.Windows.Forms.Timer timer1;
    }
}

