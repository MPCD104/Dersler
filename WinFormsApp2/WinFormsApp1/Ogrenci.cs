using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Ogrenci

    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int Vize { get; set; }
        public int Final { get; set; }
        public double Ortalama { get { return OrtalamaHesapla(); } }
        public string DersNotu { get { return DersNotuHesapla(); } }

        public Ders DersAdi { get; set; }

        private double OrtalamaHesapla ()
        {
            double notOrtalamasi = Vize * 0.4 + Final * 0.6;
            return notOrtalamasi;
        }
        private string DersNotuHesapla()
        { 
            if (100>=Ortalama && Ortalama>=80)
            {
                return "AA";
            }
            else if (80 > Ortalama && Ortalama >= 70)
            {
                return "BA";
            }
            else if (70 > Ortalama && Ortalama >= 60)
            {
                return "BB";
            }
            else if (60 > Ortalama && Ortalama >= 50)
            {
                return "CB";
            }
            else if (50 > Ortalama && Ortalama >= 45)
            {
                return "CC";
            }
            else 
            {
                return "DD";
            }

        }
        public string OgrenciBilgisiYazdır()
        {
            return $"{Ad} {Soyad} Ders Notu : {DersNotu} Ortalama : {Ortalama} Ders Adı : {DersAdi}";
        }

    }

}
