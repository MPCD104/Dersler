using Ornek2;

Urun urun = new Urun();
Console.WriteLine("Ürün adi giriniz");
urun.Adi = Console.ReadLine();
Console.WriteLine("Adet giriniz");
urun.Adet = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ürün fiyatı giriniz");
urun.Fiyati = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{urun.Adi} ürününden toplam {urun.Adet} tane sipariş verdiniz. Toplam Fiyat : {urun.Adet * urun.Fiyati}");