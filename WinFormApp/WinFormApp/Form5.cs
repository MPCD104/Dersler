using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormApp
{
    public partial class Form5 : Form
    {
        List<Sehir> sehirler = new List<Sehir>();
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            Sehir sehir = new Sehir();
            sehir.SehirAdi = "İZMİR";
            sehir.PlakaNo = 35;
            sehirler.Add(sehir);

            Sehir sehir2 = new Sehir();
            sehir2.SehirAdi = "İSTANBUL";
            sehir2.PlakaNo = 34;
            sehirler.Add(sehir2);

            Sehir sehir3 = new Sehir();
            sehir3.SehirAdi = "ANKARA";
            sehir3.PlakaNo = 06;
            sehirler.Add(sehir3);

            Sehir sehir4 = new Sehir();
            sehir4.SehirAdi = "AYDIN";
            sehir4.PlakaNo = 09;
            sehirler.Add(sehir4);
             

            cmbSehirler.DataSource = sehirler;
            cmbSehirler.DisplayMember = "SehirAdi";
            cmbSehirler.ValueMember = "PlakaNo";

        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            Sehir seciliSehir = (Sehir)cmbSehirler.SelectedItem;
            MessageBox.Show($"{seciliSehir.PlakaNo} - {seciliSehir.SehirAdi}");
        }
    }
}
