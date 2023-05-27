using Ornek3.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek3
{
    public class Bilgisayar
    {
        public int Ram { get; set; }
        public IslemciTipi Islemci { get; set; }

        public IsletimSistemi IsletimSistemi { get; set; }

        public string Hdd { get; set; }

        public Gpu EkranKarti { get; set; }
    }

}
