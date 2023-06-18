namespace KariyerRestoran
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
            components = new System.ComponentModel.Container();
            tcRestoran = new TabControl();
            tpMenu = new TabPage();
            dgvMenu = new DataGridView();
            ıdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productBindingSource = new BindingSource(components);
            txtProductId = new NumericUpDown();
            lblPrice = new Label();
            lblProductName = new Label();
            lblProductId = new Label();
            txtProductPrice = new TextBox();
            txtProductName = new TextBox();
            btnDeleteProduct = new Button();
            btnUpdateProduct = new Button();
            btnAddProduct = new Button();
            tpMasa = new TabPage();
            lbOrders = new ListBox();
            btnPay = new Button();
            btnAddtoCart = new Button();
            lblTotalPrice = new Label();
            lblTableNo = new Label();
            lblMasaNo = new Label();
            lblToplamFiyat = new Label();
            btnMasa12 = new Button();
            btnMasa11 = new Button();
            btnMasa10 = new Button();
            btnMasa9 = new Button();
            btnMasa8 = new Button();
            btnMasa7 = new Button();
            btnMasa6 = new Button();
            btnMasa5 = new Button();
            btnMasa4 = new Button();
            btnMasa3 = new Button();
            btnMasa2 = new Button();
            btnMasa1 = new Button();
            tcRestoran.SuspendLayout();
            tpMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMenu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtProductId).BeginInit();
            tpMasa.SuspendLayout();
            SuspendLayout();
            // 
            // tcRestoran
            // 
            tcRestoran.Controls.Add(tpMenu);
            tcRestoran.Controls.Add(tpMasa);
            tcRestoran.Location = new Point(0, 0);
            tcRestoran.Name = "tcRestoran";
            tcRestoran.SelectedIndex = 0;
            tcRestoran.Size = new Size(800, 448);
            tcRestoran.TabIndex = 0;
            // 
            // tpMenu
            // 
            tpMenu.Controls.Add(dgvMenu);
            tpMenu.Controls.Add(txtProductId);
            tpMenu.Controls.Add(lblPrice);
            tpMenu.Controls.Add(lblProductName);
            tpMenu.Controls.Add(lblProductId);
            tpMenu.Controls.Add(txtProductPrice);
            tpMenu.Controls.Add(txtProductName);
            tpMenu.Controls.Add(btnDeleteProduct);
            tpMenu.Controls.Add(btnUpdateProduct);
            tpMenu.Controls.Add(btnAddProduct);
            tpMenu.Location = new Point(4, 24);
            tpMenu.Name = "tpMenu";
            tpMenu.Size = new Size(792, 420);
            tpMenu.TabIndex = 0;
            tpMenu.Text = "Menü";
            tpMenu.UseVisualStyleBackColor = true;
            tpMenu.Click += tpMenu_Click;
            // 
            // dgvMenu
            // 
            dgvMenu.AllowUserToAddRows = false;
            dgvMenu.AllowUserToDeleteRows = false;
            dgvMenu.AllowUserToOrderColumns = true;
            dgvMenu.AutoGenerateColumns = false;
            dgvMenu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMenu.Columns.AddRange(new DataGridViewColumn[] { ıdDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn });
            dgvMenu.DataSource = productBindingSource;
            dgvMenu.Location = new Point(331, 15);
            dgvMenu.MultiSelect = false;
            dgvMenu.Name = "dgvMenu";
            dgvMenu.ReadOnly = true;
            dgvMenu.RowTemplate.Height = 25;
            dgvMenu.Size = new Size(453, 399);
            dgvMenu.TabIndex = 11;
            dgvMenu.SelectionChanged += dgvMenu_SelectionChanged;
            // 
            // ıdDataGridViewTextBoxColumn
            // 
            ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            ıdDataGridViewTextBoxColumn.HeaderText = "Ürün No";
            ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
            ıdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Ürün Adı";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn.HeaderText = "Fiyat";
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(Product);
            // 
            // txtProductId
            // 
            txtProductId.Location = new Point(137, 16);
            txtProductId.Name = "txtProductId";
            txtProductId.Size = new Size(188, 23);
            txtProductId.TabIndex = 10;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(8, 82);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(32, 15);
            lblPrice.TabIndex = 9;
            lblPrice.Text = "Fiyat";
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Location = new Point(8, 53);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(54, 15);
            lblProductName.TabIndex = 8;
            lblProductName.Text = "Ürün Adı";
            // 
            // lblProductId
            // 
            lblProductId.AutoSize = true;
            lblProductId.Location = new Point(8, 24);
            lblProductId.Name = "lblProductId";
            lblProductId.Size = new Size(52, 15);
            lblProductId.TabIndex = 7;
            lblProductId.Text = "Ürün No";
            // 
            // txtProductPrice
            // 
            txtProductPrice.Location = new Point(137, 74);
            txtProductPrice.Name = "txtProductPrice";
            txtProductPrice.Size = new Size(188, 23);
            txtProductPrice.TabIndex = 2;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(137, 45);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(188, 23);
            txtProductName.TabIndex = 1;
            // 
            // btnDeleteProduct
            // 
            btnDeleteProduct.Location = new Point(8, 171);
            btnDeleteProduct.Name = "btnDeleteProduct";
            btnDeleteProduct.Size = new Size(152, 61);
            btnDeleteProduct.TabIndex = 5;
            btnDeleteProduct.Text = "Sil";
            btnDeleteProduct.UseVisualStyleBackColor = true;
            btnDeleteProduct.Click += btnDeleteProduct_Click;
            // 
            // btnUpdateProduct
            // 
            btnUpdateProduct.Location = new Point(173, 103);
            btnUpdateProduct.Name = "btnUpdateProduct";
            btnUpdateProduct.Size = new Size(152, 62);
            btnUpdateProduct.TabIndex = 4;
            btnUpdateProduct.Text = "Güncelle";
            btnUpdateProduct.UseVisualStyleBackColor = true;
            btnUpdateProduct.Click += btnUpdateProduct_Click;
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(8, 103);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(152, 62);
            btnAddProduct.TabIndex = 3;
            btnAddProduct.Text = "Ekle";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // tpMasa
            // 
            tpMasa.Controls.Add(lbOrders);
            tpMasa.Controls.Add(btnPay);
            tpMasa.Controls.Add(btnAddtoCart);
            tpMasa.Controls.Add(lblTotalPrice);
            tpMasa.Controls.Add(lblTableNo);
            tpMasa.Controls.Add(lblMasaNo);
            tpMasa.Controls.Add(lblToplamFiyat);
            tpMasa.Controls.Add(btnMasa12);
            tpMasa.Controls.Add(btnMasa11);
            tpMasa.Controls.Add(btnMasa10);
            tpMasa.Controls.Add(btnMasa9);
            tpMasa.Controls.Add(btnMasa8);
            tpMasa.Controls.Add(btnMasa7);
            tpMasa.Controls.Add(btnMasa6);
            tpMasa.Controls.Add(btnMasa5);
            tpMasa.Controls.Add(btnMasa4);
            tpMasa.Controls.Add(btnMasa3);
            tpMasa.Controls.Add(btnMasa2);
            tpMasa.Controls.Add(btnMasa1);
            tpMasa.Location = new Point(4, 24);
            tpMasa.Name = "tpMasa";
            tpMasa.Size = new Size(792, 420);
            tpMasa.TabIndex = 1;
            tpMasa.Text = "Masalar";
            tpMasa.UseVisualStyleBackColor = true;
            // 
            // lbOrders
            // 
            lbOrders.FormattingEnabled = true;
            lbOrders.ItemHeight = 15;
            lbOrders.Location = new Point(540, 106);
            lbOrders.Name = "lbOrders";
            lbOrders.Size = new Size(244, 304);
            lbOrders.TabIndex = 18;
            // 
            // btnPay
            // 
            btnPay.BackColor = Color.Red;
            btnPay.Location = new Point(410, 209);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(124, 97);
            btnPay.TabIndex = 17;
            btnPay.Text = "Ödeme Al";
            btnPay.UseVisualStyleBackColor = false;
            // 
            // btnAddtoCart
            // 
            btnAddtoCart.BackColor = Color.FromArgb(0, 192, 0);
            btnAddtoCart.Location = new Point(410, 106);
            btnAddtoCart.Name = "btnAddtoCart";
            btnAddtoCart.Size = new Size(124, 97);
            btnAddtoCart.TabIndex = 16;
            btnAddtoCart.Text = "Sipariş Ekle";
            btnAddtoCart.UseVisualStyleBackColor = false;
            btnAddtoCart.Click += btnAddtoCart_Click;
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalPrice.ForeColor = Color.Red;
            lblTotalPrice.Location = new Point(559, 57);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(28, 32);
            lblTotalPrice.TabIndex = 15;
            lblTotalPrice.Text = "1";
            // 
            // lblTableNo
            // 
            lblTableNo.AutoSize = true;
            lblTableNo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblTableNo.ForeColor = Color.Red;
            lblTableNo.Location = new Point(559, 13);
            lblTableNo.Name = "lblTableNo";
            lblTableNo.Size = new Size(28, 32);
            lblTableNo.TabIndex = 14;
            lblTableNo.Text = "1";
            // 
            // lblMasaNo
            // 
            lblMasaNo.AutoSize = true;
            lblMasaNo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblMasaNo.Location = new Point(410, 13);
            lblMasaNo.Name = "lblMasaNo";
            lblMasaNo.Size = new Size(109, 32);
            lblMasaNo.TabIndex = 13;
            lblMasaNo.Text = "Masa No";
            // 
            // lblToplamFiyat
            // 
            lblToplamFiyat.AutoSize = true;
            lblToplamFiyat.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblToplamFiyat.Location = new Point(410, 57);
            lblToplamFiyat.Name = "lblToplamFiyat";
            lblToplamFiyat.Size = new Size(149, 32);
            lblToplamFiyat.TabIndex = 12;
            lblToplamFiyat.Text = "Toplam Fiyat";
            // 
            // btnMasa12
            // 
            btnMasa12.BackColor = Color.Green;
            btnMasa12.Location = new Point(8, 312);
            btnMasa12.Name = "btnMasa12";
            btnMasa12.Size = new Size(124, 97);
            btnMasa12.TabIndex = 11;
            btnMasa12.Text = "Masa 10";
            btnMasa12.UseVisualStyleBackColor = false;
            btnMasa12.Click += btnMasa_Click;
            // 
            // btnMasa11
            // 
            btnMasa11.BackColor = Color.Green;
            btnMasa11.Location = new Point(138, 312);
            btnMasa11.Name = "btnMasa11";
            btnMasa11.Size = new Size(124, 97);
            btnMasa11.TabIndex = 10;
            btnMasa11.Text = "Masa 11";
            btnMasa11.UseVisualStyleBackColor = false;
            btnMasa11.Click += btnMasa_Click;
            // 
            // btnMasa10
            // 
            btnMasa10.BackColor = Color.Green;
            btnMasa10.Location = new Point(268, 312);
            btnMasa10.Name = "btnMasa10";
            btnMasa10.Size = new Size(124, 97);
            btnMasa10.TabIndex = 9;
            btnMasa10.Text = "Masa 12";
            btnMasa10.UseVisualStyleBackColor = false;
            btnMasa10.Click += btnMasa_Click;
            // 
            // btnMasa9
            // 
            btnMasa9.BackColor = Color.Green;
            btnMasa9.Location = new Point(8, 209);
            btnMasa9.Name = "btnMasa9";
            btnMasa9.Size = new Size(124, 97);
            btnMasa9.TabIndex = 8;
            btnMasa9.Text = "Masa 7";
            btnMasa9.UseVisualStyleBackColor = false;
            btnMasa9.Click += btnMasa_Click;
            // 
            // btnMasa8
            // 
            btnMasa8.BackColor = Color.Green;
            btnMasa8.Location = new Point(138, 209);
            btnMasa8.Name = "btnMasa8";
            btnMasa8.Size = new Size(124, 97);
            btnMasa8.TabIndex = 7;
            btnMasa8.Text = "Masa 8";
            btnMasa8.UseVisualStyleBackColor = false;
            btnMasa8.Click += btnMasa_Click;
            // 
            // btnMasa7
            // 
            btnMasa7.BackColor = Color.Green;
            btnMasa7.Location = new Point(268, 209);
            btnMasa7.Name = "btnMasa7";
            btnMasa7.Size = new Size(124, 97);
            btnMasa7.TabIndex = 6;
            btnMasa7.Text = "Masa 9";
            btnMasa7.UseVisualStyleBackColor = false;
            btnMasa7.Click += btnMasa_Click;
            // 
            // btnMasa6
            // 
            btnMasa6.BackColor = Color.Green;
            btnMasa6.Location = new Point(8, 106);
            btnMasa6.Name = "btnMasa6";
            btnMasa6.Size = new Size(124, 97);
            btnMasa6.TabIndex = 5;
            btnMasa6.Text = "Masa 4";
            btnMasa6.UseVisualStyleBackColor = false;
            btnMasa6.Click += btnMasa_Click;
            // 
            // btnMasa5
            // 
            btnMasa5.BackColor = Color.Green;
            btnMasa5.Location = new Point(138, 106);
            btnMasa5.Name = "btnMasa5";
            btnMasa5.Size = new Size(124, 97);
            btnMasa5.TabIndex = 4;
            btnMasa5.Text = "Masa 5";
            btnMasa5.UseVisualStyleBackColor = false;
            btnMasa5.Click += btnMasa_Click;
            // 
            // btnMasa4
            // 
            btnMasa4.BackColor = Color.Green;
            btnMasa4.Location = new Point(268, 106);
            btnMasa4.Name = "btnMasa4";
            btnMasa4.Size = new Size(124, 97);
            btnMasa4.TabIndex = 3;
            btnMasa4.Text = "Masa 6";
            btnMasa4.UseVisualStyleBackColor = false;
            btnMasa4.Click += btnMasa_Click;
            // 
            // btnMasa3
            // 
            btnMasa3.BackColor = Color.Green;
            btnMasa3.Location = new Point(268, 3);
            btnMasa3.Name = "btnMasa3";
            btnMasa3.Size = new Size(124, 97);
            btnMasa3.TabIndex = 2;
            btnMasa3.Text = "Masa 3";
            btnMasa3.UseVisualStyleBackColor = false;
            btnMasa3.Click += btnMasa_Click;
            // 
            // btnMasa2
            // 
            btnMasa2.BackColor = Color.Green;
            btnMasa2.Location = new Point(138, 3);
            btnMasa2.Name = "btnMasa2";
            btnMasa2.Size = new Size(124, 97);
            btnMasa2.TabIndex = 1;
            btnMasa2.Text = "Masa 2";
            btnMasa2.UseVisualStyleBackColor = false;
            btnMasa2.Click += btnMasa_Click;
            // 
            // btnMasa1
            // 
            btnMasa1.BackColor = Color.Green;
            btnMasa1.Location = new Point(8, 3);
            btnMasa1.Name = "btnMasa1";
            btnMasa1.Size = new Size(124, 97);
            btnMasa1.TabIndex = 0;
            btnMasa1.Text = "Masa 1";
            btnMasa1.UseVisualStyleBackColor = false;
            btnMasa1.Click += btnMasa_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tcRestoran);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tcRestoran.ResumeLayout(false);
            tpMenu.ResumeLayout(false);
            tpMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMenu).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtProductId).EndInit();
            tpMasa.ResumeLayout(false);
            tpMasa.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tcRestoran;
        private TabPage tpMenu;
        private Label lblPrice;
        private Label lblProductName;
        private Label lblProductId;
        private TextBox txtProductPrice;
        private TextBox txtProductName;
        private Button btnDeleteProduct;
        private Button btnUpdateProduct;
        private Button btnAddProduct;
        private TabPage tpMasa;
        private Label lblTotalPrice;
        private Label lblTableNo;
        private Label lblMasaNo;
        private Label lblToplamFiyat;
        private Button btnMasa12;
        private Button btnMasa11;
        private Button btnMasa10;
        private Button btnMasa9;
        private Button btnMasa8;
        private Button btnMasa7;
        private Button btnMasa6;
        private Button btnMasa5;
        private Button btnMasa4;
        private Button btnMasa3;
        private Button btnMasa2;
        private Button btnMasa1;
        private Button btnPay;
        private Button btnAddtoCart;
        private ListBox lbOrders;
        private NumericUpDown txtProductId;
        private DataGridView dgvMenu;
        private BindingSource productBindingSource;
        private DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
    }
}