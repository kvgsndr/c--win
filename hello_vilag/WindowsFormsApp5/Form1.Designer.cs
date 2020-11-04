namespace WindowsFormsApp5
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
            this.hello_Lbl = new System.Windows.Forms.Label();
            this.ok_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hello_Lbl
            // 
            this.hello_Lbl.AutoSize = true;
            this.hello_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hello_Lbl.ForeColor = System.Drawing.Color.Red;
            this.hello_Lbl.Location = new System.Drawing.Point(257, 113);
            this.hello_Lbl.Name = "hello_Lbl";
            this.hello_Lbl.Size = new System.Drawing.Size(203, 39);
            this.hello_Lbl.TabIndex = 0;
            this.hello_Lbl.Text = "Helló Világ!";
            this.hello_Lbl.Visible = false;
            // 
            // ok_Btn
            // 
            this.ok_Btn.Location = new System.Drawing.Point(287, 281);
            this.ok_Btn.Name = "ok_Btn";
            this.ok_Btn.Size = new System.Drawing.Size(144, 57);
            this.ok_Btn.TabIndex = 1;
            this.ok_Btn.Text = "Ok";
            this.ok_Btn.UseVisualStyleBackColor = true;
            this.ok_Btn.Click += new System.EventHandler(this.button1_Click);
            this.ok_Btn.MouseEnter += new System.EventHandler(this.ok_Btn_MouseEnter);
            this.ok_Btn.MouseLeave += new System.EventHandler(this.ok_Btn_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ok_Btn);
            this.Controls.Add(this.hello_Lbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hello_Lbl;
        private System.Windows.Forms.Button ok_Btn;
    }
}

