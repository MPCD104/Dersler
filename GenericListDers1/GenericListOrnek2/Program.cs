//Bir sayı giriniz
//20
//diziye ekleyecek mi ? diziden çıkaracak mı?
//çıkardığı eleman dizide yoksa uyarı vericek devam edecek
//ekleme çıkarma işlemini bitirmek için 0 girebilir.
//işlem bittiğinde dizideki bütün öğeleri yazsın

List<int> list = new List<int>();
int sayi = 0;
do
{
    Console.WriteLine("Sayı giriniz : ");
    sayi = Convert.ToInt32(Console.ReadLine());

    if (sayi != -1)
    {
        Console.WriteLine("Ekleme için E ye çıkarmak için C ye basiniz");
        ConsoleKeyInfo islem = Console.ReadKey();
        if (islem.Key == ConsoleKey.E)
        {
            list.Add(sayi);
        }
        else if (islem.Key == ConsoleKey.C)
        {
            if (list.Contains(sayi))
            {
                list.Remove(sayi);
            }
            else
            {
                Console.WriteLine("Sayi bulunamadi");
            }
        }
        else
        {
            Console.WriteLine("Yanlıs tusa bastınız.");
        }
    }

} while (sayi != -1);

foreach (var item in list)
{
    Console.WriteLine(item);
}

Console.ReadLine();