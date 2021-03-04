namespace WindowsFormsApp3
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
            this.bf_Btn = new System.Windows.Forms.Button();
            this.jf_Btn = new System.Windows.Forms.Button();
            this.bl_Btn = new System.Windows.Forms.Button();
            this.jl_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bf_Btn
            // 
            this.bf_Btn.Location = new System.Drawing.Point(68, 71);
            this.bf_Btn.Name = "bf_Btn";
            this.bf_Btn.Size = new System.Drawing.Size(218, 75);
            this.bf_Btn.TabIndex = 0;
            this.bf_Btn.Text = "Balra föl";
            this.bf_Btn.UseVisualStyleBackColor = true;
            this.bf_Btn.Click += new System.EventHandler(this.bf_Btn_Click);
            // 
            // jf_Btn
            // 
            this.jf_Btn.Location = new System.Drawing.Point(487, 77);
            this.jf_Btn.Name = "jf_Btn";
            this.jf_Btn.Size = new System.Drawing.Size(217, 77);
            this.jf_Btn.TabIndex = 1;
            this.jf_Btn.Text = "Jobbra föl";
            this.jf_Btn.UseVisualStyleBackColor = true;
            this.jf_Btn.Click += new System.EventHandler(this.jfBtn_Click);
            // 
            // bl_Btn
            // 
            this.bl_Btn.Location = new System.Drawing.Point(72, 292);
            this.bl_Btn.Name = "bl_Btn";
            this.bl_Btn.Size = new System.Drawing.Size(214, 77);
            this.bl_Btn.TabIndex = 2;
            this.bl_Btn.Text = "Balra le";
            this.bl_Btn.UseVisualStyleBackColor = true;
            this.bl_Btn.Click += new System.EventHandler(this.bl_Btn_Click);
            // 
            // jl_Btn
            // 
            this.jl_Btn.Location = new System.Drawing.Point(487, 292);
            this.jl_Btn.Name = "jl_Btn";
            this.jl_Btn.Size = new System.Drawing.Size(214, 77);
            this.jl_Btn.TabIndex = 3;
            this.jl_Btn.Text = "Jobbra le";
            this.jl_Btn.UseVisualStyleBackColor = true;
            this.jl_Btn.Click += new System.EventHandler(this.jl_Btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.jl_Btn);
            this.Controls.Add(this.bl_Btn);
            this.Controls.Add(this.jf_Btn);
            this.Controls.Add(this.bf_Btn);
            this.Name = "Form1";
            this.Text = "Ablak mozgató";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bf_Btn;
        private System.Windows.Forms.Button jf_Btn;
        private System.Windows.Forms.Button bl_Btn;
        private System.Windows.Forms.Button jl_Btn;
    }
}

