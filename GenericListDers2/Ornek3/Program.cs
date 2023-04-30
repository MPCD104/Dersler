#region Sayıları Ekleme
//Sayıları alıp eklemeye başladık
List<int> list = new List<int>();
int sayi = 0;
do
{
    Console.WriteLine("Sayıyı giriniz.");
    sayi = Convert.ToInt32(Console.ReadLine());
    list.Add(sayi);

} while (sayi != -1);
list.Remove(-1);
// sayı ekleme işlemini bitirdik.
#endregion
#region Sıralama
//Sıralamaya başladık

list.Sort();

foreach (int i in list)
{
    Console.WriteLine(i);

}
// sıralamayı bitirdik ekranda gösterdik
#endregion
#region Index ile arama

int index = 0;
do
{
    Console.WriteLine("Bir index değeri giriniz");
    index = Convert.ToInt32(Console.ReadLine());
    if (index > list.Count - 1)
    {
        Console.WriteLine("Girilen sayı index boyutundan büyüktür.");
    }
} while (list.Count <= index );

Console.WriteLine(list[index]);

#endregion
#region Arama
int sayininIndexDegeri = 0;
do
{
    Console.WriteLine("Aramak istedeiğiniz sayıyı giriniz.");
    int sayi2 = Convert.ToInt32(Console.ReadLine());
    sayininIndexDegeri = list.IndexOf(sayi2); // aranan değeri bulamazsa -1 döner
    if (sayininIndexDegeri == -1)
    {
        Console.WriteLine("Bulunamadı !");
    }
} while (sayininIndexDegeri == -1);

Console.WriteLine(sayininIndexDegeri);
#endregion