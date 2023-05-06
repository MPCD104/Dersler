Console.WriteLine("Takım Eşleştirmeye Hoşgeldiniz..");
List<string> takimlar = new List<string>();
for (int i = 1; i <= 6; i++)
{
    Console.WriteLine($"{i}. Takımı Giriniz.");
    string takim = Console.ReadLine();
    takimlar.Add(takim);
}
// 0. fb
// 1. bjk
// 2. gs
// 3. ksk
// 4. ts
// 5. göztepe
int index = -1;
int randomMax = 6;
Random rand = new Random();
List<string> eslesmeler = new List<string>();
do
{
    randomMax = takimlar.Count; // 6-5
    index = rand.Next(randomMax); // 3-2
    string takim = takimlar[index]; // ksk-gs
    eslesmeler.Add(takim); // [ksk] - [ksk,gs]
    takimlar.Remove(takim);// [fb,bjk,gs,ts,göztepe] - [fb,bjk,ts,göztepe]

} while (takimlar.Count != 0);

string takim1 = string.Empty;
string takim2 = string.Empty;
for (int i = 0; i < 6; i += 2)
{
    takim1 = eslesmeler[i];
    takim2 = eslesmeler[i + 1]; 
    Console.WriteLine($"{takim1} vs {takim2}");
}
Console.ReadLine();