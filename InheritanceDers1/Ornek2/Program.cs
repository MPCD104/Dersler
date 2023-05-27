
using Ornek2;

Console.WriteLine("Hesap yapmak istediğiniz şekili seçiniz (1- Kare, 2- Üçgen)");
int secim = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Yükseklik Giriniz.");
int Yukseklik = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Genişlik Giriniz.");
int Genislik = Convert.ToInt32(Console.ReadLine());


if (secim==1)
{
    Kare kare = new Kare(); 
    kare.Yukseklik=Yukseklik;
    kare.Genislik=Genislik;
    kare.AlanHesaplama();
    kare.CevreHesaplama();
}
else if (secim==2)
{
    Ucgen ucgen = new Ucgen();
    ucgen.Yukseklik=Yukseklik;
    ucgen.Genislik=Genislik;
    ucgen.AlanHesaplama();
    ucgen.CevreHesaplama();
}
