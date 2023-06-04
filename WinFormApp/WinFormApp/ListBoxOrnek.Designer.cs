namespace WinFormApp
{
    partial class ListBoxOrnek
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
            this.lbIsimler = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtIsim = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbIsimler
            // 
            this.lbIsimler.FormattingEnabled = true;
            this.lbIsimler.ItemHeight = 25;
            this.lbIsimler.Location = new System.Drawing.Point(415, 57);
            this.lbIsimler.Name = "lbIsimler";
            this.lbIsimler.Size = new System.Drawing.Size(180, 129);
            this.lbIsimler.TabIndex = 0;
            this.lbIsimler.SelectedIndexChanged += new System.EventHandler(this.lbIsimler_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(141, 152);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 34);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtIsim
            // 
            this.txtIsim.Location = new System.Drawing.Point(130, 66);
            this.txtIsim.Name = "txtIsim";
            this.txtIsim.Size = new System.Drawing.Size(150, 31);
            this.txtIsim.TabIndex = 2;
            // 
            // ListBoxOrnek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtIsim);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbIsimler);
            this.Name = "ListBoxOrnek";
            this.Text = "ListBoxOrnek";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lbIsimler;
        private Button btnAdd;
        private TextBox txtIsim;
    }
}