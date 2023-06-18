namespace KariyerRestoran
{
    public partial class SiparisEkle : Form
    {
        public ProductManager productManager;
        public SiparisEkle()
        {
            InitializeComponent(); 
        }


        List<string> list = new List<string>();
        private void btnSiparisEkle_Click(object sender, EventArgs e)
        {

        }

        private void cmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SiparisEkle_Load(object sender, EventArgs e)
        {
            FillProductsComboBox();

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
