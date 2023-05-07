using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassYapisi
{
    public class Araba
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public int Yil { get; set; }
        public int MotorGucu { get; set; }

        public void KapiyiAc() 
        {
            Console.WriteLine("Kapı açıldı");
        }
    }
}
