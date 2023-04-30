List<int> list = new List<int>();

int sayi = 0;
do
{
    Console.WriteLine("Sayi giriniz");
    sayi = Convert.ToInt32(Console.ReadLine());
    list.Add(sayi);

} while (sayi != -1);
list.Remove(-1);
Console.WriteLine("Küçükten büyüğe doğru sıralamak için K, tersten sıralamak için B'ye basınız");
ConsoleKeyInfo key = Console.ReadKey();
Console.WriteLine();
if (key.Key == ConsoleKey.K)
{
    //list.OrderBy(x => x).ToList();
    list.Sort(); 
}
else if (key.Key == ConsoleKey.B)
{
    list.OrderByDescending(x => x);
}

foreach (var item in list)
{
    Console.WriteLine(item);
}

Console.ReadLine();
