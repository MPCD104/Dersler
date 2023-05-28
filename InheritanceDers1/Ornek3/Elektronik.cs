using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek3
{
    public class Elektronik
    {
        public int Fiyat { get; set; }
        public string Marka { get; set; }
        bool Durum { get; set; }
        public void AcKapa()
        {
            if (Durum)
                Console.WriteLine("Kapanıyor..");
            else
            {
                Console.WriteLine("Açılıyor..");
            }
            Durum = !Durum;
        }

        public bool AcikMi()
        {
            return Durum;
        }

        public void Ac() 
        {
            if (!AcikMi())
            {
                AcKapa();
            }
        }

    }
}
