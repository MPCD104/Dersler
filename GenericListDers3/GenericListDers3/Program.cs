Console.WriteLine("Takım Eşleştirmeye Hoşgeldiniz..");

List<string> takimlar = new List<string>();


for (int i = 1; i <= 6; i++)
{
    Console.WriteLine($"{i}. Takımı Giriniz.");
    string takim = Console.ReadLine();
    takimlar.Add(takim);
}

Random rand = new Random();
List<int> indexes = new List<int>(); //3,4,5,0,1,2
int index = -1;
int counter = 0;
do
{
    index = rand.Next(6); //3,4,3,3,5
    if (!indexes.Contains(index))
    {
        indexes.Add(index);
        counter = counter + 1;
    }
} while (counter != 6);

string takim1 = string.Empty;
string takim2 = string.Empty;
for (int i = 0; i < 6; i += 2)
{
    //indexes[0] , indexes[1] (takimlar[3], takimlar[4])
    //indexes[2] , indexes[3] (takimlar[5], takimlar[0])
    //indexes[4] , indexes[5] (takimlar[1], takimlar[2])
    takim1 = takimlar[indexes[i]]; //0 
    takim2 = takimlar[indexes[i + 1]]; //1

    Console.WriteLine($"{takim1} vs {takim2}");
}

Console.ReadLine();