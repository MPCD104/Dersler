using Interfaceler.Abstracts;

namespace Interfaceler
{
    public class Sms :INotification
    {
        public Sms()
        {
            SmsConnectionAdresi = "Vodafone";
        }
        public string SmsConnectionAdresi { get; set; }
        public string TelefonNumarasi { get; set; }
        public void BildirimGonder()
        {
            Console.WriteLine($"{TelefonNumarasi} telefon numarasına sms gönderildi.");
        }

        public void BildirimiIptalEt()
        {
            Console.WriteLine($"{TelefonNumarasi} telefon numarasına sms iptal edildi.");
        }
    }
}
