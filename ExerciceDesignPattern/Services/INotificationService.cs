using ExerciceDesignPattern.Dtos;

namespace ExerciceDesignPattern.Services
{
    public interface INotificationService
    {
        bool EnvoyerNotification(NotificationsDto notifData);
    }
}
