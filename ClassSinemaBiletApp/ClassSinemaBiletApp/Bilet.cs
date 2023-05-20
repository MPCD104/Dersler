namespace ClassSinemaBiletApp
{
    public class Bilet
    {
        public string AdSoyad { get; set; }
        public int KoltukNo { get; set; }
        public FilmAdi FilmAdi { get; set; }
        public DateTime FilmTarihi { get; set; }
        public bool MisirPaketi { get; set; }
        public int Fiyat { get; set; }

        public void Sat(FilmAdi filmAdi, DateTime filmTarihi, int koltukNo)
        {
            FilmTarihi = filmTarihi;
            FilmAdi = filmAdi;
            KoltukNo = koltukNo;

            Console.WriteLine("Ad Soyad giriniz");
            AdSoyad = Console.ReadLine();

            Console.WriteLine("Mısır istiyor musunuz? (Evet,Hayır)");
            string misirIstiyorMu = Console.ReadLine();
            MisirPaketi = false;
            if (misirIstiyorMu.ToLower() == "evet")
            {
                MisirPaketi = true;
            }
        }

        public void FilmSec()
        {
            Console.WriteLine("Film seçiniz");
            Console.WriteLine("1- John Wick");
            Console.WriteLine("2- Karabasan");
            Console.WriteLine("3- Hızlı ve Öfkeli");
            FilmAdi = (FilmAdi)Convert.ToInt32(Console.ReadLine()); 
        }

        public void FilmTarihiSec()
        {
            Console.WriteLine("Film Saatini giriniz(Örnek : 20.05.2023 19:00)");
            FilmTarihi = Convert.ToDateTime(Console.ReadLine()); 
        }

        public int ToplamFiyat()
        {
            Fiyat = 100;
            if (MisirPaketi)
            {
                Fiyat += 10;
            }
            return Fiyat;
        }
        //****JohnWick****
        //****19.00 20.05.2023****
        //***  Koltuk No : 1 ****
        //*** Ali Fuat *****
        //*** Mısır İstiyor ****
        //Toplam : 110 TL
        public void Yazdir()
        {
            string misirIstiyorMu = "Mısır İstemiyor";
            if (MisirPaketi)
            {
                misirIstiyorMu = "Mısır İstiyor";
            }
            Console.WriteLine($"**** {FilmAdi} ****");
            Console.WriteLine($"**** {FilmTarihi.ToShortTimeString()}  {FilmTarihi.ToShortDateString()} ****");
            Console.WriteLine($"**** Koltuk No:{KoltukNo} ****");
            Console.WriteLine($"**** {AdSoyad} ****");
            Console.WriteLine($"**** {misirIstiyorMu} ****");
            Console.WriteLine($"Toplam Fiyat : {ToplamFiyat()}");
        }

        public void KoltukDuzeniGoster(List<Bilet> satilanBiletler)
        {
            #region Aciklama
            //John Wick
            // 1  2  D  4  5
            // 6  7  8  D  10
            // 11 12 13 14 15
            // 16 17 18 19 20
            // 21 22 23 24 25

            //Karabasan
            // 1  2  3  D  5
            // 6  7  8  D  10
            // 11 12 13 14 15
            // 16 17 18 19 20
            // 21 22 23 24 25
            #endregion
            int koltukNo = 0;
            for (int i = 1; i < 6; i++)
            {
                Console.WriteLine();
                for (int j = 1; j < 6; j++)
                {
                    koltukNo++;
                    if (satilanBiletler.Any(bilet => bilet.KoltukNo == koltukNo && bilet.FilmAdi == FilmAdi && bilet.FilmTarihi == FilmTarihi))
                    {
                        Console.Write("D ");
                    }
                    else
                    {
                        Console.Write($"{koltukNo} ");
                    }
                }
            }
            Console.WriteLine();
        }

    }
}
