List<int> sayilar = new List<int>();
int sayi = 0;
do
{
    Console.WriteLine("Bir sayı giriniz");
    sayi = Convert.ToInt32(Console.ReadLine());
    if (sayi == -1) 
        break; 
    sayilar.Add(sayi);

} while (true);
 
List<int> uceBolunenler = sayilar.Where(x => x % 3 == 0).ToList();
List<int> beseBolunenler = sayilar.Where(x => x % 5 == 0).ToList();
List<int> yediyeBolunenler = sayilar.Where(x => x % 7 == 0).ToList();
List<int> bolunmeyenler = sayilar.Where(
    x => !(x % 2 == 0 ||
           x % 3 == 0 ||
           x % 5 == 0 ||
           x % 7 == 0)).ToList();

Console.WriteLine("İkiye bölünenler : " + string.Join(",", sayilar.Where(x => x % 2 == 0).ToList()));
Console.WriteLine("Üçe bölünenler : " + string.Join(",", uceBolunenler));
Console.WriteLine("Beşe bölünenler : " + string.Join(",", beseBolunenler));
Console.WriteLine("Yediye bölünenler : " + string.Join(",", yediyeBolunenler));
Console.WriteLine("Hiçbir sayıya bölünenler : " + string.Join(",", bolunmeyenler));