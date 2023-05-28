using Interfaceler;
using Interfaceler.Abstracts;

Console.WriteLine("Bildirim göndermek istediğiniz yöntemi giriniz. (1-SMS , 2- PushNotification 3- Email,4- Posta,5-Instagram)");
int secim = Convert.ToInt32(Console.ReadLine());

NotificationManager manager = new NotificationManager();
INotification notification =  manager.CreateNotification(secim);
notification.BildirimGonder();
notification.BildirimiIptalEt();


