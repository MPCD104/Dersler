namespace Ornek2
{
    public class ElektrikliArac
    {
        public ElektrikliAracMotorHacmi MotorHacmi { get; set; }
        public decimal VergisizFiyat { get; set; }
        public decimal OtvliFiyatHesapla(bool ekrandaGoster)
        {
            decimal otvYuzdesi = 0;
            switch (MotorHacmi)
            {
                case ElektrikliAracMotorHacmi.Kw160Gecmeyen:
                    otvYuzdesi = 1.1m;
                    break;
                case ElektrikliAracMotorHacmi.Kw160Gecen:
                    otvYuzdesi = 1.5m;
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



