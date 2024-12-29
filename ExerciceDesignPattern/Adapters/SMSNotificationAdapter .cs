using ExerciceDesignPattern.Dtos;
using ExerciceDesignPattern.Services;

namespace ExerciceDesignPattern.Adapters
{
    public class SMSNotificationAdapter : INotificationService
    {
        public bool EnvoyerNotification(NotificationsDto smsDetails)
        {
            Console.WriteLine($"SMS envoyé avec le message : {smsDetails.Body}");
            return true;
        }
    }
}
