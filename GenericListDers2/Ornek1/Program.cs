List<int> list = new List<int>();
int sayı = 0;
do
{
    Console.WriteLine("Sayı giriniz");
    sayı = Convert.ToInt32(Console.ReadLine());

    list.Add(sayı);

}while (sayı != -1);
list.Remove(-1);
Console.WriteLine(list.Max());
Console.WriteLine(list.Min());



