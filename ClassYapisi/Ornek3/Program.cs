using Ornek2;

List<Urun> adisyon = new List<Urun>();
int secim = 0;
do
{
    Console.WriteLine("1- Ürün Ekleme");
    Console.WriteLine("2- Ürün Listeleme");
    Console.WriteLine("3- Ürün Çıkarma");
    Console.WriteLine("4- Ödeme Yap");
    Console.WriteLine("5- Çıkış");
    Console.WriteLine("Seçim yapınız...");
    secim = Convert.ToInt32(Console.ReadLine());
    if (secim == 5) break;
    switch (secim)
    {
        case 1: UrunEkleme(); break;
        case 2: UrunListeleme(); break;
        case 3: UrunListeleme(); UrunCikarma(); break;
        case 4: OdemeYap(); break;
        default:
            break;
    }
} while (true);

void UrunEkleme()
{
    Urun urun = new Urun();
    Console.WriteLine("Ürün Id giriniz");
    urun.Id = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ürün adi giriniz");
    urun.Adi = Console.ReadLine();
    Console.WriteLine("Adet giriniz");
    urun.Adet = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ürün fiyatı giriniz");
    urun.Fiyati = Convert.ToInt32(Console.ReadLine());

    adisyon.Add(urun);

}
void UrunCikarma()
{
    //Adisyon
    // 1-Kahve
    // 2-Çay
    // 3-Su
    Console.WriteLine("Çıkarmak istediğiniz ürünün Id'sini giriniz");
    int id = Convert.ToInt32(Console.ReadLine());
    Urun cikarilmakIstenenUrunBilgisi;
    //Burası aşağıdaki kod ile aynı işlemi yapar.
    //foreach (Urun item in adisyon)
    //{
    //    if (item.Id == id)
    //    {
    //        cikarilmakIstenenUrunBilgisi = item;
    //        break;
    //    }
    //}
    cikarilmakIstenenUrunBilgisi = adisyon.FirstOrDefault(item => item.Id == id);
    adisyon.Remove(cikarilmakIstenenUrunBilgisi);
}
void UrunListeleme()
{
    // 3 adet Kahve
    // Adet Fiyatı : 10 TL
    // Toplam Fiyat : 30 TL
    for (int i = 0; i < adisyon.Count; i++)
    {
        // 3 adet Kahve (Ürün Id : 1)
        Console.WriteLine($"{adisyon[i].Adet} adet {adisyon[i].Adi} (Ürün Id : {adisyon[i].Id})");
        // Adet Fiyatı : 10 TL
        Console.WriteLine($"Adet Fiyatı : {adisyon[i].Fiyati} TL");
        // Toplam Fiyat : 30 TL
        Console.WriteLine($"Toplam Fiyat : {adisyon[i].ToplamFiyat()} TL");
        Console.WriteLine("******************");
    }
}

void OdemeYap()
{
    int adisyonToplami = 0;
    foreach (Urun item in adisyon)
    {
        adisyonToplami += item.ToplamFiyat();
    }

    //AdisyonToplami 100 TL'den fazla ise 5 TL indirim yapıyoruz.
    if (adisyonToplami>=100)
    {
        adisyonToplami -= 5;
    }

    Console.WriteLine("Ödemeniz gereken toplam tutar :" + adisyonToplami);
}