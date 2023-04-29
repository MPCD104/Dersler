using System.Security.Cryptography.X509Certificates;

List<int> dizi = new List<int> 
{
    1,2,3, 4, 5, 6, 7,7,7,7,7
};

dizi.Add(20);
dizi[2] = 10;

for (int i = 0; i < dizi.Count; i++)
{
    if (dizi[i] == 6)
    {
        Console.WriteLine("Dizi içerisinde 6 sayısı bulunuyor.");
    }
}


if (dizi.Contains(6))
{
    Console.WriteLine("Dizi içerisinde 6 sayısı bulunuyor.");
}

dizi.AddRange(new List<int>() { 90, 99 });



for (int i = 0; i < dizi.Count; i++)
{
    Console.WriteLine($"{i}. eleman {dizi[i]}");
}

Console.WriteLine("Dizideki eşsiz ögeler");
List<int> diziList = dizi.Distinct().ToList();

dizi.FirstOrDefault();
for (int i = 0; i < diziList.Count; i++)
{
    Console.WriteLine($"{i}. eleman {diziList[i]}");
}
Console.ReadLine();