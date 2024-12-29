using ExerciceDesignPattern.Dtos;
using ExerciceDesignPattern.Factory;

namespace ExerciceDesignPattern.Services
{
    public interface ISmsNotificationService
    {
        public bool sendSms(NotificationsDto smsDetails);
    }

    public class SmsNotificationService : ISmsNotificationService
    {
        private readonly NotificationFactory _notificationFactory;
        public SmsNotificationService(NotificationFactory notificationFactory)
        {
            _notificationFactory = notificationFactory;
        }
        public bool sendSms(NotificationsDto smsDetails)
        {
            INotificationService smsNotification = _notificationFactory.CreerNotificationService("sms");
            return smsNotification.EnvoyerNotification(smsDetails);
        }
    }
}
