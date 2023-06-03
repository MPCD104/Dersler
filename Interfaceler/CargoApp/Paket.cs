using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoApp
{
    public class Paket
    {
        public string AliciAdSoyad { get; set; }
        public string GonderenAdSoyad { get; set; }
        public PaketBoyutu PaketBoyutu { get; set; }
        public KargoFirmasi KargoFirmasi { get; set; }
        public bool OdemePesinMiYapilacak { get; set; }
        public int PaketFiyati
        {
            get
            {
                if (PaketBoyutu == PaketBoyutu.Kucuk)
                {
                    return KargoFirmasi.PaketFiyati * PaketBoyutu.Kucuk.GetHashCode();
                }
                else if (PaketBoyutu == PaketBoyutu.Orta)
                {
                    return KargoFirmasi.PaketFiyati * PaketBoyutu.Orta.GetHashCode();
                }
                else
                {
                    //PaketBoyutu PackageSize = (PaketBoyutu)3;
                    //PaketFiyati = KargoFirmasi.PaketFiyati * (int)PaketBoyutu.Buyuk;

                    return KargoFirmasi.PaketFiyati * PaketBoyutu.Buyuk.GetHashCode();
                }
            }
        }


        public void Gonder()
        {
            if (OdemePesinMiYapilacak)
            {
                Console.WriteLine($"Kargo ücretiniz = {PaketFiyati} TL");
            }
            Console.WriteLine("Kargo gönderildi.");


        }
        public void Al()
        {
            if (!OdemePesinMiYapilacak)
            {
                Console.WriteLine($"Kargo ücretiniz = {PaketFiyati} TL");
            }
            Console.WriteLine("Kargo alındı.");
        }
    }
}
