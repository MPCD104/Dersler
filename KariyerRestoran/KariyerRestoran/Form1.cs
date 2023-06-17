namespace KariyerRestoran
{
    public partial class Form1 : Form
    {
        ProductManager productManager = new ProductManager();
        List<Table> tables = new List<Table>();
        public Form1()
        {
            InitializeComponent();
            for (int i = 1; i < 13; i++)
            {
                Table table = new Table();
                table.Name = "Masa " + i;
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
            FillProductsDataGridView();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
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
            Table? activeTable = tables.FirstOrDefault(x => x.Name == btn.Text);
            if (activeTable == null)
            {
                MessageBox.Show("Masa bulunamadý");
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
        }

        private Button? FindTable(string tableName) 
        {
            foreach (Control control in tpMasa.Controls)
            {
                if (control is Button && control.Text.Contains(tableName))
                {
                    return (Button)control;
                }
            }
            return null;
        }
    }
}