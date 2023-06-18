namespace KariyerRestoran
{
    public partial class SiparisEkle : Form
    {
        public ProductManager productManager;
        public List<Table> tables;
        public SiparisEkle()
        {
            InitializeComponent();
        }

        private void btnSiparisEkle_Click(object sender, EventArgs e)
        { 
            foreach (Table table in tables)
            {
                if (table.IsActive)
                {
                    Order order = new Order();
                    order.Count = Convert.ToInt32(txtCount.Value);
                    order.Product = (Product)cmbProduct.SelectedItem;
                    table.Order.Add(order);
                }
            }
        } 

        private void SiparisEkle_Load(object sender, EventArgs e)
        {
            FillProductsComboBox();
            lblTableNo.Text = tables.FirstOrDefault(x => x.IsActive).Name;

        }
        private void FillProductsComboBox()
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = productManager.GetAllProducts();
            cmbProduct.DataSource = bindingSource;
            cmbProduct.DisplayMember = "Name";
            cmbProduct.ValueMember = "Id";

        }
    }
}
