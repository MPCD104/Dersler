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
    public partial class IllerIlceler : Form
    {
        List<Sehir> sehirler = new List<Sehir>();
        public IllerIlceler()
        {
            InitializeComponent();
        }

        private void cmbIller_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sehir secilenSehir = (Sehir)cmbIller.SelectedItem;
            cmbIlceler.DataSource = secilenSehir.ilceler;
            cmbIlceler.DisplayMember = "Adi";
            cmbIlceler.ValueMember = "Id"; 
        }

        private void cmbIlceler_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void IllerIlceler_Load(object sender, EventArgs e)
        {
            Sehir izmir = new Sehir();
            izmir.SehirAdi = "İzmir";
            izmir.PlakaNo = 35;
            List<Ilce> izmirIlceler = new List<Ilce>();
            Ilce konak = new Ilce();
            konak.Id = 1;
            konak.Adi = "Konak";
            izmirIlceler.Add(konak);
  
            Ilce bornova = new Ilce();
            bornova.Id = 2;
            bornova.Adi = "Bornova";
            izmirIlceler.Add(bornova);
            
            Ilce karabaglar = new Ilce();
            karabaglar.Id = 2;
            karabaglar.Adi = "Karabaglar";
            izmirIlceler.Add(karabaglar);

            Ilce buca = new Ilce();
            buca.Id = 2;
            buca.Adi = "Buca";
            izmirIlceler.Add(buca);
            izmir.ilceler = izmirIlceler;

            Sehir istanbul = new Sehir();
            istanbul.SehirAdi = "İstanbul";
            istanbul.PlakaNo = 35;
            List<Ilce> istanbulIlceler = new List<Ilce>();
            Ilce kadikoy = new Ilce();
            kadikoy.Id = 1;
            kadikoy.Adi = "Kadikoy";
            istanbulIlceler.Add(kadikoy);

            Ilce beylikduzu = new Ilce();
            beylikduzu.Adi = "Beylikduzu";
            beylikduzu.Id = 2;
            istanbulIlceler.Add(beylikduzu);

            Ilce moda = new Ilce();
            moda.Id = 3;
            moda.Adi = "Moda";
            istanbulIlceler.Add(moda);
            istanbul.ilceler = istanbulIlceler;

            sehirler.Add(istanbul);
            sehirler.Add(izmir);

            cmbIller.DataSource = sehirler;
            cmbIller.DisplayMember = "SehirAdi";
            cmbIller.ValueMember = "PlakaNo";
        }
    }

}
