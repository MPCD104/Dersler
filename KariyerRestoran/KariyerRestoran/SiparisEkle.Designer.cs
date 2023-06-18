namespace KariyerRestoran
{
    partial class SiparisEkle
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
            cmbProduct = new ComboBox();
            lblProduct = new Label();
            txtCount = new NumericUpDown();
            lblCount = new Label();
            btnSiparisEkle = new Button();
            lblTableNo = new Label();
            lblMasaNo = new Label();
            ((System.ComponentModel.ISupportInitialize)txtCount).BeginInit();
            SuspendLayout();
            // 
            // cmbProduct
            // 
            cmbProduct.FormattingEnabled = true;
            cmbProduct.Location = new Point(99, 60);
            cmbProduct.Name = "cmbProduct";
            cmbProduct.Size = new Size(121, 23);
            cmbProduct.TabIndex = 0;
            cmbProduct.SelectedIndexChanged += cmbProduct_SelectedIndexChanged;
            // 
            // lblProduct
            // 
            lblProduct.AutoSize = true;
            lblProduct.Location = new Point(12, 68);
            lblProduct.Name = "lblProduct";
            lblProduct.Size = new Size(54, 15);
            lblProduct.TabIndex = 1;
            lblProduct.Text = "Ürün Adı";
            // 
            // txtCount
            // 
            txtCount.Location = new Point(100, 89);
            txtCount.Name = "txtCount";
            txtCount.Size = new Size(120, 23);
            txtCount.TabIndex = 2;
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Location = new Point(12, 97);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(32, 15);
            lblCount.TabIndex = 3;
            lblCount.Text = "Adet";
            // 
            // btnSiparisEkle
            // 
            btnSiparisEkle.Location = new Point(12, 118);
            btnSiparisEkle.Name = "btnSiparisEkle";
            btnSiparisEkle.Size = new Size(208, 53);
            btnSiparisEkle.TabIndex = 4;
            btnSiparisEkle.Text = "Sipariş Ekle";
            btnSiparisEkle.UseVisualStyleBackColor = true;
            btnSiparisEkle.Click += btnSiparisEkle_Click;
            // 
            // lblTableNo
            // 
            lblTableNo.AutoSize = true;
            lblTableNo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblTableNo.ForeColor = Color.Red;
            lblTableNo.Location = new Point(161, 23);
            lblTableNo.Name = "lblTableNo";
            lblTableNo.Size = new Size(28, 32);
            lblTableNo.TabIndex = 16;
            lblTableNo.Text = "1";
            // 
            // lblMasaNo
            // 
            lblMasaNo.AutoSize = true;
            lblMasaNo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblMasaNo.Location = new Point(12, 23);
            lblMasaNo.Name = "lblMasaNo";
            lblMasaNo.Size = new Size(109, 32);
            lblMasaNo.TabIndex = 15;
            lblMasaNo.Text = "Masa No";
            // 
            // SiparisEkle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(245, 186);
            Controls.Add(lblTableNo);
            Controls.Add(lblMasaNo);
            Controls.Add(btnSiparisEkle);
            Controls.Add(lblCount);
            Controls.Add(txtCount);
            Controls.Add(lblProduct);
            Controls.Add(cmbProduct);
            Name = "SiparisEkle";
            Text = "SiparisEkle";
            Load += SiparisEkle_Load;
            ((System.ComponentModel.ISupportInitialize)txtCount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbProduct;
        private Label lblProduct;
        private NumericUpDown txtCount;
        private Label lblCount;
        private Button btnSiparisEkle;
        private Label lblTableNo;
        private Label lblMasaNo;
    }
}