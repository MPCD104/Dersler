namespace Ornek2
{
    public class Urun
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public int Fiyati { get; set; }
        public int Adet { get; set; }

        public int ToplamFiyat()
        {
            int toplamFiyat = Adet * Fiyati;
            //Eğer bir üründen 100 TL'den fazla sipariş verdiysek 10 TL indirim yapıyoruz.
            if (toplamFiyat >= 100)
            {
                return toplamFiyat - 10;
            }
            return toplamFiyat;
        }
    }
}
