namespace WinFormApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSelam = new System.Windows.Forms.Button();
            this.txtIsim = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSelam
            // 
            this.btnSelam.Location = new System.Drawing.Point(50, 49);
            this.btnSelam.Name = "btnSelam";
            this.btnSelam.Size = new System.Drawing.Size(112, 34);
            this.btnSelam.TabIndex = 0;
            this.btnSelam.Text = "Selam";
            this.btnSelam.UseVisualStyleBackColor = true;
            this.btnSelam.Click += new System.EventHandler(this.btnSelam_Click);
            // 
            // txtIsim
            // 
            this.txtIsim.Location = new System.Drawing.Point(12, 12);
            this.txtIsim.Name = "txtIsim";
            this.txtIsim.Size = new System.Drawing.Size(150, 31);
            this.txtIsim.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtIsim);
            this.Controls.Add(this.btnSelam);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSelam;
        private TextBox txtIsim;
    }
}