using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek1
{
    public class Calisan
    {
        public Calisan()
        {
            BrutUcretOrani = 5000; 
        }
        //public
        //internal
        //protected
        //internal protected
        //private

        public string Adi { get; set; }
        public int SicilNo { get; set; }
        protected int Maas { get; set; }

        private int BrutUcretOrani { get; set; }

        public int BrutUcretHesapla() 
        {
            return BrutUcretOrani + Maas;
        }

        public void MaasAl()
        {
            Console.WriteLine($"{Maas} alındı");
        }
        public void ZamYap(int zamMiktari)
        {
            Maas += zamMiktari;
        }

        protected void CalisanBilgileri() 
        {
            Console.WriteLine($"Adı :{Adi}");
            Console.WriteLine($"Sicil No :{SicilNo}");
            Console.WriteLine($"Maas :{Maas}");
        }
    }
}
