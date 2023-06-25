using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kariyer.Kutuphane.Entities
{
    public class KutuphaneIslemleri : BaseEntity
    {
        public int UyeId { get; set; }
        public int KitapId { get; set; }
        public DateTime VerildigiTarih { get; set; }
        public DateTime SonGetirmeTarihi { get; set; }
    }
}
