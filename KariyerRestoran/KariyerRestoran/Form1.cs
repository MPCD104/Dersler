namespace KariyerRestoran
{
    public partial class Form1 : Form
    {
        ProductManager productManager = new ProductManager();
        public Form1()
        {
            InitializeComponent();
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
            if (dgvMenu.SelectedRows.Count>0)
            {
                Product product = (Product)dgvMenu.SelectedRows[0].DataBoundItem;
                txtProductId.Value = product.Id;
                txtProductName.Text = product.Name;
                txtProductPrice.Text = product.Price.ToString();
            }
           
        }
    }
}