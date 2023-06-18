namespace KariyerRestoran
{
    public partial class Form1 : Form
    {
        ProductManager productManager;
        List<Table> tables = new List<Table>();
        public Form1()
        {
            InitializeComponent();
            productManager = new ProductManager();
            for (int i = 1; i < 13; i++)
            {
                Table table = new Table();
                table.Name = "Masa " + i;
                table.Id = "btnMasa" + i;
                tables.Add(table);
            }
        }
        private void FillProductsDataGridView()
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = productManager.GetAllProducts();
            dgvMenu.DataSource = bindingSource;
        }
        private Product GetProductFromForm()
        {
            Product product = new Product();
            product.Id = Convert.ToInt32(txtProductId.Value);

            product.Name = txtProductName.Text;
            product.Price = Convert.ToDecimal(txtProductPrice.Text);
            return product;
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            Product product = GetProductFromForm();
            productManager.AddProduct(product);
            FillProductsDataGridView();
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {

            productManager.DeleteProduct(GetProductFromForm());
            FillProductsDataGridView();
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            productManager.UpdateProduct(GetProductFromForm());
            FillProductsDataGridView();
        }

        private void tpMenu_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillProductsDataGridView();
        }

        private void dgvMenu_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMenu.SelectedRows.Count > 0)
            {
                Product product = (Product)dgvMenu.SelectedRows[0].DataBoundItem;
                txtProductId.Value = product.Id;
                txtProductName.Text = product.Name;
                txtProductPrice.Text = product.Price.ToString();
            }

        }

        private void btnMasa_Click(object sender, EventArgs e)
        {

            Button btn = (Button)sender;
            Table? activeTable = tables.FirstOrDefault(x => x.Id == btn.Name);
            if (activeTable == null)
            {
                MessageBox.Show("Masa bulunamadý");
                return;
            }
            #region Önceden seçilmiþ masanýn rengini deðiþtirme
            foreach (Table oldActiveTable in tables)
            {
                if (oldActiveTable.IsActive)
                {
                    oldActiveTable.Color = oldActiveTable.TableTaken() ? Color.Red : Color.Green;
                    oldActiveTable.IsActive = false;
                    Button oldActiveTableButton = FindTable(oldActiveTable.Name);
                    oldActiveTableButton.BackColor = oldActiveTable.Color;
                }
            }
            //if (oldActiveTable.TableTaken())
            //{
            //    oldActiveTable.Color = Color.Red;
            //}
            //else
            //{
            //    oldActiveTable.Color = Color.Green;
            //}
            #endregion
            activeTable.IsActive = true;
            activeTable.Color = Color.Yellow;
            btn.BackColor = Color.Yellow;
            lblTableNo.Text = btn.Text;
            lbOrders.Items.Clear();
            decimal totalprice = 0;
            foreach (Order order in activeTable.Order)
            {
                string orderDescription = $"Ürün Adi :{order.Product.Name} // Adet : {order.Count}";
                totalprice += order.Product.Price * order.Count;
                lbOrders.Items.Add(orderDescription);

            }
            lblTotalPrice.Text = totalprice.ToString();
        }

        private Button? FindTable(string tableName)
        {
            foreach (Control control in tpMasa.Controls)
            {
                if (control is Button && control.Text == tableName)
                {
                    return (Button)control;
                }
            }
            return null;
        }

        private void btnAddtoCart_Click(object sender, EventArgs e)
        {
            SiparisEkle siparisEkle = new SiparisEkle();
            siparisEkle.productManager = productManager;
            siparisEkle.tables = tables;
            siparisEkle.Show();

        }
    }
}