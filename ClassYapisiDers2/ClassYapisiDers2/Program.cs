using ClassYapisiDers2;
List<Kisi> kisiler = new List<Kisi>();
do
{
    Console.WriteLine("1- Ekleme");
    Console.WriteLine("2- Silme");
    Console.WriteLine("3- Listeleme");
    Console.WriteLine("4- Arama");
    Console.WriteLine("5- Güncelleme");
    Console.WriteLine("6- Çıkış");
    Console.WriteLine("Yapmak istediğiniz işlemi seçiniz...");
    int yapilacakIslem = Convert.ToInt32(Console.ReadLine());

    if (yapilacakIslem == 6) break;

    switch (yapilacakIslem)
    {
        case 1: Ekleme(); break;
        case 2: Silme(); break;
        case 3: Listeleme(kisiler); break;
        case 4: Arama(); break;
        case 5: Guncelleme(); break;
        default: Console.WriteLine("Yanlış seçim yaptınız!"); break;
    }
} while (true);

void Ekleme()
{
    do
    {
        Kisi kisi = new Kisi();
        Console.WriteLine("Ad soyad giriniz.(Çıkış için -1 yazınız)");
        string adSoyad = Console.ReadLine();

        if (adSoyad == "-1") break;

        Console.WriteLine("Telefon numarası giriniz");
        string telefonNumarasi = Console.ReadLine();

        kisi.AdiSoyadi = adSoyad;
        kisi.TelefonNumarasi = telefonNumarasi;

        kisiler.Add(kisi); // listeye ekliyoruz
    } while (true);
}

List<Kisi> Arama()
{
    Console.WriteLine("Aramak istediğiniz numarayı veya ismi giriniz?");
    string aranacakKelime = Console.ReadLine();

    #region Alternatif arama
    //Aşağıdaki kod ile aynı işlemi yapar.
    //List<Kisi> bulunanlar1 = new List<Kisi>();
    //foreach (Kisi item in kisiler)
    //{
    //    if (x.TelefonNumarasi.Contains(aranacakKelime) || x.AdiSoyadi.Contains(aranacakKelime))
    //    {
    //        bulunanlar1.Add(x);
    //    }
    //}
    #endregion
    List<Kisi> bulunanKisiler = kisiler.Where(item => item.TelefonNumarasi.Contains(aranacakKelime) ||
                                                   item.AdiSoyadi.Contains(aranacakKelime)).ToList();

    if (!bulunanKisiler.Any()) // Any == Count>0
    {
        Console.WriteLine("Değer bulunamadı");
    }

    Listeleme(bulunanKisiler);

    return bulunanKisiler;
}

void Listeleme(List<Kisi> list)
{
    for (int i = 0; i < list.Count; i++)
    {
        Console.WriteLine($"{i + 1} - Kisi Adı : {list[i].AdiSoyadi} Telefon Numarası : {list[i].TelefonNumarasi}");
    }
}

void Silme()
{
    Kisi secilenKisi = Secim();
    kisiler.Remove(secilenKisi);
}

Kisi Secim() 
{
    List<Kisi> bulunanlar = Arama();
    Console.WriteLine("İşlem yapmak istediğiniz kaydın öğe numarasını giriniz.");
    int secilenKisiOgeNumarasi = Convert.ToInt32(Console.ReadLine());
    return bulunanlar[secilenKisiOgeNumarasi - 1]; 
}

void Guncelleme()
{
    Kisi kisi = Secim();
    foreach (var item in kisiler)
    {
        if (item.AdiSoyadi == kisi.AdiSoyadi && item.TelefonNumarasi == kisi.TelefonNumarasi)
        {
            Console.WriteLine("Yeni numarayi giriniz");
            string yeniNumara = Console.ReadLine();
            item.TelefonNumarasi = yeniNumara;
            break;
        }
    }
}