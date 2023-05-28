using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaceler.Abstracts;

namespace Interfaceler
{
    public class PushNotification : INotification
    {
        public string DeviceId { get; set; }

        public void BildirimGonder()
        {
            Console.WriteLine($"{DeviceId} adresine push notification gönderildi.");
        }

        public void BildirimiIptalEt()
        {
            Console.WriteLine($"{DeviceId} adresine push notification iptal edildi.");
        }
    }
}
