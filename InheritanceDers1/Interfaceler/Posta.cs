using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaceler.Abstracts;

namespace Interfaceler
{
    public class Posta:INotification
    {
        public string PostaAdresi { get; set; }

        public void BildirimGonder()
        {
            Console.WriteLine($"{PostaAdresi} posta adresine posta gönderildi.");
        } 

        public void BildirimiIptalEt()
        {
            Console.WriteLine($"{PostaAdresi} posta adresine posta iptal edildi.");
        }
    }
}
