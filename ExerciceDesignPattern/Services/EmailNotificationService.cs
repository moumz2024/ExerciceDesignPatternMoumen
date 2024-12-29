using ExerciceDesignPattern.Adapters;
using ExerciceDesignPattern.Dtos;
using ExerciceDesignPattern.Factory;

namespace ExerciceDesignPattern.Services
{
    public interface IEmailNotificationService
    {
        public bool SendEmail(NotificationsDto emailDetails);
    }
    public class EmailNotificationService :IEmailNotificationService
    {
        private readonly NotificationFactory _notificationFactory;
        public EmailNotificationService(NotificationFactory notifFactory) {
            _notificationFactory = notifFactory;
        }
        public  bool SendEmail(NotificationsDto emailDetails) 
        {
            INotificationService emailNotification =  _notificationFactory.CreerNotificationService("email");
            return  emailNotification.EnvoyerNotification(emailDetails);
        }
    }
}
