namespace Ornek2
{
    public class Bus
    {
        public BusType Tipi { get; set; }
        public decimal VergisizFiyat { get; set; }

        public decimal OtvliFiyatHesapla(bool ekrandaGoster) 
        {
            decimal otvYuzdesi = 0;
            switch (Tipi)
            {
                case BusType.Midibus:
                    otvYuzdesi = 1.04m;
                    break;
                case BusType.Minibus:
                    otvYuzdesi = 1.09m;
                    break;
                case BusType.Otobus:
                    otvYuzdesi = 1.01m;
                    break; 
            }
            decimal otvliFiyat = VergisizFiyat * otvYuzdesi;
            if (ekrandaGoster)
            {
                Console.WriteLine("OTV'li Fiyat :" + otvliFiyat);
            }
            return otvliFiyat;
        }
        public decimal KdvliFiyatHesapla() 
        {
            decimal kdvliFiyat = OtvliFiyatHesapla(false) * 1.18m;
            Console.WriteLine("KDV'li Fiyat :" + kdvliFiyat);
            return kdvliFiyat;
        }
    }
}
