using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormApp
{
    public class Sehir
    {
        public string SehirAdi  { get; set; }
        public int PlakaNo { get; set; }
        public List<Ilce> ilceler { get; set; }

    }

}
