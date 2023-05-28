using Interfaceler.Abstracts;
using System;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaceler
{
    public class InstagramBildirimi : INotification
    {
        public string InstagramAdresi { get; set; }

        public void BildirimGonder()
        {
            Console.WriteLine($"{InstagramAdresi} kullanıcısına bildirim gönderildi.");
        }

        public void BildirimiIptalEt()
        {
            Console.WriteLine($"{InstagramAdresi} kullanıcısına bildirimi iptal edildi.");
        }
    }
}
