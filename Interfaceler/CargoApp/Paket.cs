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

                switch (PaketBoyutu)
                {
                    case PaketBoyutu.Kucuk:
                        return KargoFirmasi.PaketFiyati * PaketBoyutu.Kucuk.GetHashCode();
                    case PaketBoyutu.Orta:
                        return KargoFirmasi.PaketFiyati * PaketBoyutu.Orta.GetHashCode();
                    default:
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
