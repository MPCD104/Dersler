namespace WinFormApp
{
    partial class IllerIlceler
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
            this.cmbIller = new System.Windows.Forms.ComboBox();
            this.cmbIlceler = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cmbIller
            // 
            this.cmbIller.FormattingEnabled = true;
            this.cmbIller.Location = new System.Drawing.Point(101, 52);
            this.cmbIller.Name = "cmbIller";
            this.cmbIller.Size = new System.Drawing.Size(182, 33);
            this.cmbIller.TabIndex = 0;
            this.cmbIller.SelectedIndexChanged += new System.EventHandler(this.cmbIller_SelectedIndexChanged);
            // 
            // cmbIlceler
            // 
            this.cmbIlceler.FormattingEnabled = true;
            this.cmbIlceler.Location = new System.Drawing.Point(101, 91);
            this.cmbIlceler.Name = "cmbIlceler";
            this.cmbIlceler.Size = new System.Drawing.Size(182, 33);
            this.cmbIlceler.TabIndex = 1;
            this.cmbIlceler.SelectedIndexChanged += new System.EventHandler(this.cmbIlceler_SelectedIndexChanged);
            // 
            // IllerIlceler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbIlceler);
            this.Controls.Add(this.cmbIller);
            this.Name = "IllerIlceler";
            this.Text = "IllerIlceler";
            this.Load += new System.EventHandler(this.IllerIlceler_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox cmbIller;
        private ComboBox cmbIlceler;
    }
}