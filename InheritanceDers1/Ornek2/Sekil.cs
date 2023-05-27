using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Ornek2
{
    public class Sekil
    {
        public int Genislik { get; set; }
        public int Yukseklik { get; set; }

        public virtual void AlanHesaplama()
        {
            double Alan = Genislik * Yukseklik;
            Console.WriteLine($"Şeklin alanı = {Alan}");
        }
        public virtual void CevreHesaplama()
        {
            int Cevre = 2 * (Genislik + Yukseklik);
            Console.WriteLine($"Karenin Çevresi = {Cevre}");
        }
    }
}
