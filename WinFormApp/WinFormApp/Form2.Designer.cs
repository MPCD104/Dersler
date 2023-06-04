namespace WinFormApp
{
    partial class Form2
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
            this.textSayi1 = new System.Windows.Forms.TextBox();
            this.textSayi2 = new System.Windows.Forms.TextBox();
            this.btnTopla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textSayi1
            // 
            this.textSayi1.Location = new System.Drawing.Point(12, 12);
            this.textSayi1.Name = "textSayi1";
            this.textSayi1.Size = new System.Drawing.Size(150, 31);
            this.textSayi1.TabIndex = 0;
            // 
            // textSayi2
            // 
            this.textSayi2.Location = new System.Drawing.Point(12, 49);
            this.textSayi2.Name = "textSayi2";
            this.textSayi2.Size = new System.Drawing.Size(150, 31);
            this.textSayi2.TabIndex = 1;
            // 
            // btnTopla
            // 
            this.btnTopla.Location = new System.Drawing.Point(50, 86);
            this.btnTopla.Name = "btnTopla";
            this.btnTopla.Size = new System.Drawing.Size(112, 34);
            this.btnTopla.TabIndex = 2;
            this.btnTopla.TabStop = false;
            this.btnTopla.Text = "Topla";
            this.btnTopla.UseVisualStyleBackColor = true;
            this.btnTopla.Click += new System.EventHandler(this.btnTopla_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTopla);
            this.Controls.Add(this.textSayi2);
            this.Controls.Add(this.textSayi1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textSayi1;
        private TextBox textSayi2;
        private Button btnTopla;
    }
}