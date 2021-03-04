
namespace Tanulók_kiválasztása
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btValaszt = new System.Windows.Forms.Button();
            this.btHalaszt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btPrezental = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(68, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Csopoort";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(25, 80);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(188, 329);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btValaszt
            // 
            this.btValaszt.Location = new System.Drawing.Point(244, 163);
            this.btValaszt.Name = "btValaszt";
            this.btValaszt.Size = new System.Drawing.Size(75, 23);
            this.btValaszt.TabIndex = 3;
            this.btValaszt.Text = "Választ";
            this.btValaszt.UseVisualStyleBackColor = true;
            this.btValaszt.Click += new System.EventHandler(this.btValaszt_Click);
            // 
            // btHalaszt
            // 
            this.btHalaszt.Location = new System.Drawing.Point(244, 213);
            this.btHalaszt.Name = "btHalaszt";
            this.btHalaszt.Size = new System.Drawing.Size(75, 23);
            this.btHalaszt.TabIndex = 4;
            this.btHalaszt.Text = "Halaszt";
            this.btHalaszt.UseVisualStyleBackColor = true;
            this.btHalaszt.Click += new System.EventHandler(this.btHalaszt_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(253, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(397, 41);
            this.label2.TabIndex = 5;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btPrezental
            // 
            this.btPrezental.Location = new System.Drawing.Point(244, 265);
            this.btPrezental.Name = "btPrezental";
            this.btPrezental.Size = new System.Drawing.Size(75, 23);
            this.btPrezental.TabIndex = 6;
            this.btPrezental.Text = "Prezentál";
            this.btPrezental.UseVisualStyleBackColor = true;
            this.btPrezental.Click += new System.EventHandler(this.btPrezental_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 435);
            this.Controls.Add(this.btPrezental);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btHalaszt);
            this.Controls.Add(this.btValaszt);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Ki fog felelni?";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btValaszt;
        private System.Windows.Forms.Button btHalaszt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btPrezental;
    }
}

