namespace WinFormsApp1
{
    public partial class DersAdi : Form
    {
        List<Ogrenci> ogrenciList = new List<Ogrenci>();
        public DersAdi()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Ad = txtAd.Text;
            ogrenci.Soyad = txtSurname.Text;
            ogrenci.Vize = Convert.ToInt32(txtVize.Text);
            ogrenci.Final = Convert.ToInt32(txtFinal.Text);
            ogrenci.DersAdi = (Ders)cmbDersAdi.SelectedValue;
            lbOgrenciListesi.Items.Add(ogrenci.OgrenciBilgisiYazdýr());
            ogrenciList.Add(ogrenci);

        }

        private void DersAdi_Load(object sender, EventArgs e)
        {
            List<ComboBox> list = new List<ComboBox>();
            list.Add(new ComboBox { Key = Ders.react.ToString(), Value = Ders.react.GetHashCode() });
            list.Add(new ComboBox { Key = Ders.pyhton.ToString(), Value = Ders.pyhton.GetHashCode() });
            list.Add(new ComboBox { Key = Ders.netWeb.ToString(), Value = Ders.netWeb.GetHashCode() });
            cmbDersAdi.DataSource = list;
            cmbDersAdi.DisplayMember = "Key";
            cmbDersAdi.ValueMember = "Value";

            cmbDersListele.DataSource = list;
            cmbDersListele.DisplayMember = "Key";
            cmbDersListele.ValueMember = "Value";


        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            lbOgrenciListesi.Items.Clear();
            if (chkAA.Checked)
            {
                ListeDoldur("AA");
            }
            if (chkBA.Checked)
            {
                ListeDoldur("BA");
            }
            if (chkBB.Checked)
            {
                ListeDoldur("BB");
            }
            if (chkCB.Checked)
            {
                ListeDoldur("CB");
            }
            if (chkCC.Checked)
            {
                ListeDoldur("CC");
            }
            if (chkDD.Checked)
            {
                ListeDoldur("DD");
            }

        }
        private void ListeDoldur(string dersNotu)
        {
            foreach (var item in ogrenciList.Where(x => x.DersNotu == dersNotu && x.DersAdi == (Ders)cmbDersListele.SelectedValue))
            {
                lbOgrenciListesi.Items.Add(item.OgrenciBilgisiYazdýr());
            }
        }

        private void chkNotlar_CheckedChanged(object sender, EventArgs e)
        {
            bool tumuSeciliMi = chkAA.Checked && chkBA.Checked && chkBB.Checked && chkCB.Checked && chkCC.Checked && chkDD.Checked;
            bool herhangiBiriSeciliMi = chkAA.Checked || chkBA.Checked || chkBB.Checked || chkCB.Checked || chkCC.Checked || chkDD.Checked;
            if (tumuSeciliMi || !herhangiBiriSeciliMi)
            {
                chkTumu.Enabled = true;
            }
            if (herhangiBiriSeciliMi && !tumuSeciliMi)
            {
                chkTumu.Enabled = false;
            }
            if (tumuSeciliMi)
            {
                chkTumu.Text = "Tümünü kaldýr";
            }
            if (!tumuSeciliMi)
            {
                chkTumu.Text = "Tümünü seç";
            }
        }


        private void chkTumu_CheckedChanged(object sender, EventArgs e)
        {
            bool tumuSeciliMi = chkAA.Checked && chkBA.Checked && chkBB.Checked && chkCB.Checked && chkCC.Checked && chkDD.Checked;
            if (!(tumuSeciliMi))
            {
                chkAA.Checked = true;
                chkBB.Checked = true;
                chkBA.Checked = true;
                chkCB.Checked = true;
                chkCC.Checked = true;
                chkDD.Checked = true;
                chkTumu.Text = "Tümünü kaldýr";
            }
            else
            {
                chkAA.Checked = false;
                chkBB.Checked = false;
                chkBA.Checked = false;
                chkCB.Checked = false;
                chkCC.Checked = false;
                chkDD.Checked = false;
                chkTumu.Text = "Tümünü seç";
            }
        }
    }
}