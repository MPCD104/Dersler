using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ornek4.Abstracts;

namespace Ornek4
{
    public class Balik : Hayvan, IYuzmeYetenegi
    {
        public void HizliYuz()
        {
            Console.WriteLine("Hızlı Yüz");
        }

        public void Yuz()
        {
            Console.WriteLine("Yüzüyor.");
        }
    }
}
