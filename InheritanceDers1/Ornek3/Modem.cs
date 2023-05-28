using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek3
{
    public class Modem : Elektronik
    {
        public bool FiberVarMi { get; set; }
        public int KablosuzHizi { get; set; }
        public bool UcGVarMi { get; set; }

        public void Indir (int paketBoyutu)
        {
            Ac();

            if (FiberVarMi)
            {
                KablosuzHizi += 3;
            }

            int indirilenPaket = 0;
            int sure = 0;

            do
            {
                indirilenPaket += KablosuzHizi;
                if (indirilenPaket>paketBoyutu)
                {
                    indirilenPaket = paketBoyutu;
                }
                Console.WriteLine($"{indirilenPaket} mb/ {paketBoyutu} mb Toplam süre : {++sure} sn");
                Thread.Sleep(1000);
            } while (indirilenPaket<paketBoyutu);
            Console.WriteLine("İndirme işlemi tamamlandı.");
        }

    }
}
