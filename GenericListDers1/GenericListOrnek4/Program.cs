List<string> list = new List<string>();
string kelime = "";
do
{
    Console.WriteLine("Kelime ekleyin : ");
    kelime = Console.ReadLine();

    if (string.IsNullOrEmpty(kelime))
        Console.WriteLine("Boş kelime girilemez");
    else
        list.Add(kelime); 
} while (kelime != "Ç");

Console.WriteLine("Aramak istediğiniz Harf ve kelimeyi giriniz");
string arananString = Console.ReadLine();

foreach (string item in list)
{
    if (item.Contains(arananString))
    {
        Console.WriteLine(item);
    }
}
Console.ReadLine();