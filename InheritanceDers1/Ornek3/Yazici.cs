using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek3
{
    public class Yazici : Elektronik
    {
        public bool Wifi { get; set; }
        public bool Tarayici { get; set; }
        public bool Fotokopi { get; set; }
        public bool WifiDurumu { get; set; }

        private void IslemYap(string islemMesaji)
        {
            if (!AcikMi())
            {
                AcKapa();
            }
            Console.WriteLine(islemMesaji);
        }
        public void Tara()
        {
            IslemYap("Taraniyor..");
        }

        public void Yazdir()
        {
            IslemYap("Yazdiriliyor..");
        }

        public void WifiAcKapa()
        {
            if (WifiDurumu)
                Console.WriteLine("Wifi Kapanıyor..");
            else
            {
                Console.WriteLine("Wifi Açılıyor..");
            }
            WifiDurumu =! WifiDurumu;
        }
    }
}
