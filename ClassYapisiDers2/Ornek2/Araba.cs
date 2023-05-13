namespace Ornek2
{
    public class Araba
    {  
        public MotorHacmi MotorHacmi { get; set; }

        public decimal VergisizFiyat { get; set; }

        public decimal OtvliFiyatHesapla(bool ekrandaGoster)
        {
            decimal otvYuzdesi = 0;
            switch (MotorHacmi)
            {
                case MotorHacmi.CC1600eKadar:
                    if (VergisizFiyat < 184000)
                    {
                        otvYuzdesi = 1.45m;
                    }
                    else if (VergisizFiyat > 184001 && VergisizFiyat < 220000)
                    {
                        otvYuzdesi = 1.5m;
                    }
                    else if (VergisizFiyat > 220001 && VergisizFiyat < 250000)
                    {
                        otvYuzdesi = 1.6m;
                    }
                    else if (VergisizFiyat > 250001 && VergisizFiyat < 280000)
                    {
                        otvYuzdesi = 1.7m;
                    }
                    else
                    {
                        otvYuzdesi = 1.8m;
                    }
                    break;
                case MotorHacmi.CC1601ile2000Arasi:
                    if (VergisizFiyat < 170000)
                    {
                        otvYuzdesi = 2.3m;
                    }
                    else
                    {
                        otvYuzdesi = 2.5m;
                    }
                    break;
                case MotorHacmi.CC2001denBuyuk:
                    otvYuzdesi = 3.2m;
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
