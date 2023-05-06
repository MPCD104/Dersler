List<int> sayilar = new List<int>();
int sayi = 0;
do
{
    Console.WriteLine("Bir sayı giriniz");
    sayi = Convert.ToInt32(Console.ReadLine());
    sayilar.Add(sayi);

} while (sayi != -1);

sayilar.Remove(sayi);
List<int> ikiyeBolunenler = new List<int>();
List<int> uceBolunenler = new List<int>();
List<int> beseBolunenler = new List<int>();
List<int> yediyeBolunenler = new List<int>();
List<int> bolunmeyenler = new List<int>();

foreach (int item in sayilar)
{
    if (item % 2 == 0)
    {
        ikiyeBolunenler.Add(item);
    }
     if (item % 3 == 0)
    {
        uceBolunenler.Add(item);
    }
     if (item % 5 == 0)
    {
        beseBolunenler.Add(item);
    }
    if (item % 7 == 0)
    {
        yediyeBolunenler.Add(item);
    }
    if(!(item%2==0 || item%3==0 || item%5==0 || item%7==0))
       bolunmeyenler.Add(item);
}

Console.WriteLine("İkiye bölünen sayılar");
ListeYazdir(ikiyeBolunenler);
Console.WriteLine("Üçe bölünen sayılar");
ListeYazdir(uceBolunenler);
Console.WriteLine("Beşe bölünen sayılar");
ListeYazdir(beseBolunenler);
Console.WriteLine("Yediye bölünen sayılar");
ListeYazdir(yediyeBolunenler);
Console.WriteLine("İkiye,Üçe,Beşe,Yediye bölünmeyen sayılar");
ListeYazdir(bolunmeyenler);


void ListeYazdir(List<int> list) 
{
    foreach (int item in list)
    {
        Console.WriteLine(item);
    }
}





