using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ornek4.Abstracts;

namespace Ornek4
{
    public class Ordek : Hayvan, IYuzmeYetenegi, IUcmaYetenegi, IYurumeYetenegi
    {
        public void Yuz()
        {
            Console.WriteLine("Yüzüyor...");
        }  

        public void HizliYuz()
        {
            Console.WriteLine("Daha hızlı yüzüyor.");
        }

        public void Yuru()
        {
            Console.WriteLine("Yürüyor...");
        }
    }
}
