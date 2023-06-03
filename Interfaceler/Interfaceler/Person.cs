using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaceler
{
    public class Person
    {
        private string _AdSoyad;

        public string AdSoyad
        {
            get { return _AdSoyad; }
            set { _AdSoyad = value; }
        }

        public string IsimSoyisim { get; set; }
        public int Yas { get; set; }

        public void Test() { }
    }
}
