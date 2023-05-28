using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ornek4.Abstracts;

namespace Ornek4
{
    public class Kartal : Hayvan,IYurumeYetenegi,IUcmaYetenegi
    {
        public void Uc() 
        {
            Console.WriteLine("Uçuyor...");
        }

        public void Yuru()
        {
            Console.WriteLine("Yürüyor...");
        }
    }
}
