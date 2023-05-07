using Ornek4;

//Canli canli = new Canli();
//canli.Adi = "Köpek";
//canli.Yasi = 5;

int sayi1 = 5;
int sayi2 = sayi1;

sayi2 = 7;

Console.WriteLine(sayi1);

Canli canli2 = new Canli() // Ramde 1. adresi gösteriyor
{
    Adi = "Kedi",
    Yasi = 5,
};


//Canli canli3 = canli2; //1.adresteki değeri gösteriyor.
//canli3.Adi = "Kuş";

Canli canli4 = new Canli(); //Ramde 2. adresi gösteriyor.
canli4 = canli2; // 1. adrese bakıyor.
canli4.Adi = "Balık";

Console.WriteLine(canli4.Adi);
Console.WriteLine(canli2.Adi);