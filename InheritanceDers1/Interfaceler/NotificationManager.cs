using Interfaceler.Abstracts; 

namespace Interfaceler
{
    public class NotificationManager
    {
        public INotification CreateNotification(int notificationTuru) 
        {
            INotification notification;
            switch (notificationTuru)
            {
                case 1: notification = new Sms(); break;
                case 2: notification = new PushNotification(); break; 
                case 3: notification = new Email(); break;
                case 4: notification = new Posta(); break;
                case 5: notification = new InstagramBildirimi(); break;
                default:notification = new Sms(); break;
            }
            return notification;
        }
    }
}
