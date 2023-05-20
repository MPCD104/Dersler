using ClassSinemaBiletApp;
List<Bilet> sinemaKariyerBiletleri = new List<Bilet>();
bool biletSatisiBasariliMi = false;
int koltukNo = 0;

do
{
    Bilet bilet = new Bilet();
    Console.Clear();
    Console.WriteLine("1- Bilet satışı");
    Console.WriteLine("2- Toplam gelir");
    int devamMi = Convert.ToInt32(Console.ReadLine());
    if (devamMi > 2)
    {
        Console.WriteLine("Hatalı seçim yaptınız");
        continue;
    }
    if (devamMi == 2)
    {
        ToplamGelir();
        break;
    }

    bilet.FilmSec();

    bilet.FilmTarihiSec();

    bilet.KoltukDuzeniGoster(sinemaKariyerBiletleri);

    KoltukSecimi(bilet.FilmAdi, bilet.FilmTarihi);

    if (biletSatisiBasariliMi)
    {
        Satis(bilet, bilet.FilmAdi, bilet.FilmTarihi);
    }

    Console.ReadLine();

} while (true);
//Filmlerin Toplam Geliri
void ToplamGelir()
{
    int toplamGelir = 0;
    foreach (Bilet bilet in sinemaKariyerBiletleri)
    {
        toplamGelir += bilet.Fiyat;
    }
    Console.WriteLine(toplamGelir);
}

void Satis(Bilet bilet, FilmAdi filmAdi, DateTime filmTarihi)
{

    bilet.Sat(filmAdi, filmTarihi, koltukNo);
    bilet.Yazdir();
    sinemaKariyerBiletleri.Add(bilet);
}

void KoltukSecimi(FilmAdi filmAdi, DateTime filmTarihi)
{
    do
    {
        Console.WriteLine("Koltuk Numarası giriniz.(1-25)");
        koltukNo = Convert.ToInt32(Console.ReadLine());
        biletSatisiBasariliMi = BiletSatilabilirMi(koltukNo, filmAdi, filmTarihi);
    } while (!biletSatisiBasariliMi);
}

bool BiletSatilabilirMi(int koltukNo, FilmAdi filmAdi, DateTime filmTarihi)
{
    if (sinemaKariyerBiletleri.Any(x => x.KoltukNo == koltukNo && x.FilmAdi == filmAdi && x.FilmTarihi == filmTarihi))
    {
        Console.WriteLine("Bu bilet daha önce satılmış");
        return false;
    }
    return true;
}

