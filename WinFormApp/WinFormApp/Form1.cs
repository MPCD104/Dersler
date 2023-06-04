namespace WinFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelam_Click(object sender, EventArgs e)
        {
            string isim = txtIsim.Text;
            MessageBox.Show($"Selam {isim}");
        }
    }
}