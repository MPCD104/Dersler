using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoApp
{
    public class KargoFirmasi
    {
        protected string CEOAdSoyad { get; set; }

        protected int VergiNo { get; set; }
        protected int Fiyat { get; set; }
        public int PaketFiyati { get { return Fiyat; } }

    }
}
