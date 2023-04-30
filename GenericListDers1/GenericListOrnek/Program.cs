List<int> dizi = new List<int>();
int eklenenSayi = -1;
int arananSayi = 0;
int index = -1;
do
{
    Console.WriteLine("Diziye eklenecek sayıyı giriniz. Çıkış için '-1' girebilirsiniz.");
    eklenenSayi = Convert.ToInt32(Console.ReadLine());
    dizi.Add(eklenenSayi);

} while (eklenenSayi != -1);

dizi.Remove(-1);
do
{
    Console.WriteLine("Aranacak sayıyı giriniz.");
    arananSayi = Convert.ToInt32(Console.ReadLine());

    index = dizi.IndexOf(arananSayi);

    switch (index)
    {
        case -1: Console.WriteLine("Aranan sayı bulununamadı"); break;
        case 0: Console.WriteLine("Aranan sayi ilk indexte"); break;

        default:
            Console.WriteLine($"Aranan sayi {index}. indexte");
            break;
    }
} while (dizi.Count - 1 != index);
Console.WriteLine("Aranan sayi son index.");

Console.ReadLine();