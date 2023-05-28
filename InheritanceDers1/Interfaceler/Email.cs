using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaceler.Abstracts;

namespace Interfaceler
{
    public class Email : INotification
    {
        public string EmailAdresi { get; set; }

        public void BildirimGonder()
        {
            Console.WriteLine($"{EmailAdresi} email adresine bildirim gönderildi.");
        }

        public void BildirimiIptalEt()
        {
            Console.WriteLine($"{EmailAdresi} email adresine bildirim iptal edildi.");
        }
    }
}
