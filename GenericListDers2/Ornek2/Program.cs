List<string> list = new List<string>();
string kelime;


do
{
    Console.WriteLine("Kelime giriniz. Çıkmak için c'ye basınız");
    kelime = Console.ReadLine();
    list.Add(kelime);

} while (kelime != "c");

Console.WriteLine("İstenilen kelimeleri giriniz.");
string arama = Console.ReadLine().ToUpper();


foreach (string item in list)
{
    if (item.ToLower().Contains(arama))
    {
        Console.WriteLine(item);
    }
}

