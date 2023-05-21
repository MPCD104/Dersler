namespace ClassDers3
{
    public class Bilet
    {
        public Bilet()
        {
            Fiyat = 300;
        }
        public Bilet(Istikamet baslangicNoktasi)
        {

        }
        public Bilet(string adSoyad, int koltukNo, DateTime gidisTarihi, Istikamet baslangicNoktasi, Istikamet varisNoktasi, bool tekliKoltuk, int fiyat)
        {
            AdSoyad = adSoyad;
            KoltukNo = koltukNo;
            GidisTarihi = gidisTarihi;
            BaslangicNoktasi = baslangicNoktasi;
            VarisNoktasi = varisNoktasi;
            TekliKoltuk = tekliKoltuk;
            Fiyat = fiyat;
        }

        public string AdSoyad { get; set; }
        public int KoltukNo { get; set; }
        public DateTime GidisTarihi { get; set; }
        public Istikamet BaslangicNoktasi { get; set; }
        public Istikamet VarisNoktasi { get; set; }
        public bool TekliKoltuk { get; set; }
        public int Fiyat { get; set; }

        /// <summary>
        /// Toplam Fiyatı verir
        /// </summary>   
        public int ToplamFiyat()
        {
            if (TekliKoltuk)
            {
                Fiyat += 20;
            }
            return Fiyat;
        }

        public bool Sat(List<Bilet> satilanBiletler)
        {
            Console.WriteLine("Gidiş tarihini girin. Örn : 19.05.2023 19:00");
            GidisTarihi = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("İzmir '35'");
            Console.WriteLine("İstanbul '34'");
            Console.WriteLine("Ankara '6'");
            Console.WriteLine("Bursa '16'");
            Console.WriteLine("Başlangıç noktasının plakasını girin. : ");
            BaslangicNoktasi = (Istikamet)Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Varış noktasının plakasını giriniz. :");
            VarisNoktasi = (Istikamet)Convert.ToInt32(Console.ReadLine());

            KoltukSec(satilanBiletler); 

            Console.WriteLine("İsim giriniz. :");
            AdSoyad = Console.ReadLine();

            Console.WriteLine("Tekli koltuk istiyor musunuz ? 'Evet' veya 'Hayır' ");
            string secim = Console.ReadLine();

            if (secim.ToLower() == "evet")
            {
                TekliKoltuk = true;
            }
            return true;
        }

        public void KoltukSec(List<Bilet> satilanBiletler) 
        {
            KoltukNo = 0;
            do
            {
                Console.WriteLine("Koltuk numarasını giriniz. :");
                int koltukNo = Convert.ToInt32(Console.ReadLine());

                if (satilanBiletler.Any(bilet => bilet.KoltukNo == koltukNo && bilet.BaslangicNoktasi == BaslangicNoktasi && bilet.VarisNoktasi == VarisNoktasi && bilet.GidisTarihi == GidisTarihi))
                {
                    Console.WriteLine("Bu bilet satılmış");
                }
                else
                {
                    KoltukNo = koltukNo;
                }
            } while (KoltukNo == 0); 
        }
        public void Yazdir()
        {
            Console.WriteLine("Bilet oluşturuldu");
            Console.WriteLine("********************");
            Console.WriteLine("İsim soyisim" + AdSoyad);
            Console.WriteLine("********************");
            Console.WriteLine("Tarih : " + GidisTarihi);
            Console.WriteLine("Başlangıç noktası :" + BaslangicNoktasi);
            Console.WriteLine("********************");
            Console.WriteLine("Varış noktası" + VarisNoktasi);
            Console.WriteLine("********************");
            Console.WriteLine("Koltuk numarası : " + KoltukNo);
            Console.WriteLine("********************");
            Console.WriteLine("Toplam fiyat : " + ToplamFiyat() + " TL");
            Console.ReadLine();
        }
         
    }
}

