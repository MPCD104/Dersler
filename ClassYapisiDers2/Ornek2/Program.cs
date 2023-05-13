using Ornek2;

Console.WriteLine("Araç tipi seçiniz (1- Otomobil, 2-Bus, 3- Elektrikli Araç)");
int aracTipi = Convert.ToInt32(Console.ReadLine());
if (aracTipi == 1)
{
    Araba araba = new Araba();

    Console.WriteLine("Motor Hacmini Seçiniz");
    Console.WriteLine("1-1600 cc altı");
    Console.WriteLine("2-1601-2000 cc arası");
    Console.WriteLine("3-2001 cc üzeri");
    int motorHacmi = Convert.ToInt32(Console.ReadLine());
    araba.MotorHacmi = (MotorHacmi)motorHacmi;

    Console.WriteLine("Vergisiz fiyatını giriniz");
    decimal fiyat = Convert.ToDecimal(Console.ReadLine());
    araba.VergisizFiyat = fiyat;

    araba.OtvliFiyatHesapla(true);
    araba.KdvliFiyatHesapla();
}
else if(aracTipi == 2)
{
    Bus bus = new Bus();

    Console.WriteLine("Bus tipini seçiniz");
    Console.WriteLine("1-Midibus");
    Console.WriteLine("2-Minibus");
    Console.WriteLine("3-Otobus");
    int busTipi = Convert.ToInt32(Console.ReadLine());
    //Cast işlemi için parantez içinde objeden önce hangi tipe dönüştürmek istiyorsanız onun tipini yazmanız gerekli
    //(DonusturmekIstenenTip)donusturulecekObje
    bus.Tipi = (BusType)busTipi; // Cast işlemi yapıyoruz yani busTipi 3 olduğunda BusType.Otobus şekline çevirir

    Console.WriteLine("Vergisiz fiyatını giriniz");
    decimal fiyat = Convert.ToDecimal(Console.ReadLine());
    bus.VergisizFiyat = fiyat;

    bus.OtvliFiyatHesapla(true); // true göndermemizin sebebi ekranda cw içinde otv fiyat bilgisinin yazılmasını istediğimiz için
    bus.KdvliFiyatHesapla();

}
else if (aracTipi==3)
{
    ElektrikliArac eArac = new ElektrikliArac();
    Console.WriteLine("Motor Hacmi seçiniz.");
    Console.WriteLine("1- 160 kw geçmeyen");
    Console.WriteLine("2- 160 kw geçen");
    int motorHacmi = Convert.ToInt32(Console.ReadLine());
    eArac.MotorHacmi = (ElektrikliAracMotorHacmi)motorHacmi;

    Console.WriteLine("Vergisiz fiyatını giriniz");
    decimal fiyat = Convert.ToDecimal(Console.ReadLine());
    eArac.VergisizFiyat = fiyat;

    eArac.OtvliFiyatHesapla(true);
    eArac.KdvliFiyatHesapla();
}