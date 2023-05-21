using ClassDers3;

//Otobüs bileti
//Ad Soyad
//Koltuk No
//Gidiş tarihi
//Nerden Nereye (İkisi de enum olacak) (İller Ankara,İstanbul,İzmir,Bursa)
//Tekli koltuk +20TL

//1- Bilet Satışı (Aynı istikamette aynı tarihe seçilen koltuk varsa uyarı verecek)
//2- Bilet Güncelleme (Aynı istikamette aynı tarihe seçilen koltuk varsa uyarı verecek)
//3- Yolcu Listesi (Seçilen tarih veya istikamete göre)
//4- Girilen Tarihe göre ciro
//5- İki şehir arasındaki ciro
//6- İki şehir arasındaki toplam yolcu sayısı
//7- Yolcu Listesini isme göre alfabetik sıralasın
List<Bilet> yolcuListesi = new List<Bilet>();
do
{
    Console.WriteLine("1 - Bilet satışı");
    Console.WriteLine("2 - Bilet Güncelleme");
    Console.WriteLine("3 - Yolcu Listesi");
    Console.WriteLine("4 - Girilen Tarihe göre ciro");
    Console.WriteLine("5 - İki şehir arasındaki ciro");
    Console.WriteLine("6 - İki şehir arasındaki toplam yolcu sayısı");
    Console.WriteLine("7- Çıkış");
    Menu secim = (Menu)Convert.ToInt32(Console.ReadLine());
    if (secim == Menu.Cikis)
    {
        break;
    }
    switch (secim)
    {
        case Menu.Satis:
            Bilet bilet = new Bilet();
            bool satilabilirMi = bilet.Sat(yolcuListesi);
            if (satilabilirMi)
            {
                bilet.Yazdir();
                yolcuListesi.Add(bilet);
            }

            break;
        case Menu.Guncelleme:
            Console.WriteLine("Güncellemek istediğiniz yolcunun ismini giriniz");
            string yolcuAdi = Console.ReadLine();
            Bilet? guncellenecekBilet = yolcuListesi.FirstOrDefault(bilet => bilet.AdSoyad.Contains(yolcuAdi));
            if (guncellenecekBilet is null)
            {
                Console.WriteLine("Yolcu bulunamadı"); break;
            }
            guncellenecekBilet.KoltukSec(yolcuListesi);

            break;
        case Menu.YolcuListesi:
            YolcuListesi();
            break;
        case Menu.TariheGoreCiro:
            break;
        case Menu.IkiSehirArasindakiCiro:
            break;
        case Menu.IkiSehirArasindakiYolcuSayisi:
            break;
        case Menu.Cikis:
            break;
        default:
            break;
    }

} while (true);

void YolcuListesi()
{
    foreach (Bilet yolcu in yolcuListesi)
    {
        Console.WriteLine($"Adı Soyadı {yolcu.AdSoyad} Koltuk No : {yolcu.KoltukNo}");
        Console.WriteLine($"İstikamet Başlangıç Noktası : {yolcu.BaslangicNoktasi} Varış Noktası : {yolcu.VarisNoktasi} Tarih : {yolcu.GidisTarihi.ToShortDateString()} {yolcu.GidisTarihi.ToShortTimeString()} ");
    }
}

void GirilenTariheGoreCiro(DateTime tarih)
{
    int toplamCiro = 0;
    foreach (Bilet bilet in yolcuListesi.Where(x => x.GidisTarihi == tarih))
    {
        toplamCiro += bilet.Fiyat;
    }
    //yolcuListesi.Count();  //Toplam Yolcu sayısı 


    //Bu kod foreach ile aynı mantıkta çalışır
    int toplamCiroDigerYontem = yolcuListesi.Where(x => x.GidisTarihi == tarih).Sum(bilet => bilet.Fiyat); // Where koşula göre filtreleme yapar. Sum içinde belirlenen değere göre Toplama işlemi yapar
    Console.WriteLine(toplamCiro);
}