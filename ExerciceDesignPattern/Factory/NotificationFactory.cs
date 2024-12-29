using ExerciceDesignPattern.Adapters;
using ExerciceDesignPattern.Services;

namespace ExerciceDesignPattern.Factory
{
    public  class NotificationFactory
    {
        public  INotificationService CreerNotificationService(string type)
        {
            return type.ToLower() switch
            {
                "email" => new EmailNotificationAdapter(),
                "sms" => new SMSNotificationAdapter(),
                _ => throw new ArgumentException("Type de notification inconnu")
            };
        }
    }
}
