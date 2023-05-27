using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek2
{
    public class Ucgen : Sekil
    {
        public int DigerKenar { get; set; }

        public override void CevreHesaplama()
        {
            int Cevre = DigerKenar + Genislik + Yukseklik;
            Console.WriteLine($"Üçgenin çevresi = {Cevre}");
        }

        public override void AlanHesaplama()
        {
            double Alan = Genislik * Yukseklik / 2;
            Console.WriteLine($"Üçgenin alanı = {Alan}");
        }
    }
}
