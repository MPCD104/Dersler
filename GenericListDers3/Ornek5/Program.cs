Console.WriteLine("ALIŞVERİŞ LİSTESİ OLUŞTUR");
List<string> list = new List<string>();
do
{
    Console.WriteLine("ÜRÜN GİR");
    string urun = Console.ReadLine();
    if (urun == "-1") break;
    list.Add(urun);
} while (true);

Console.WriteLine("ATLAMAK İSTEDİĞİNİZ ÜRÜN SAYISINI GİRİNİZ");
int sayi=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("ALMAK İSTEDİĞİMİZ ÜRÜN SAYISI");
int sayi2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("ÜRÜNLER " + string.Join(",", list.Skip(sayi).Take(sayi2).ToList()));
Console.ReadLine();


