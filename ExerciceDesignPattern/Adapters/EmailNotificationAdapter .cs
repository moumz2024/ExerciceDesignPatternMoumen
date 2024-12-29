using ExerciceDesignPattern.Dtos;
using ExerciceDesignPattern.Services;
using System.Net;
using System.Net.Mail;
namespace ExerciceDesignPattern.Adapters
{
    public class EmailNotificationAdapter : INotificationService
    {
        public bool EnvoyerNotification(NotificationsDto emailDetails)
        {
            var client = new SmtpClient("smtp-relay.brevo.com", 587)
            {
                Credentials = new NetworkCredential("829dae001@smtp-brevo.com", "c2pTJyBQshqNLMv5"),
                EnableSsl = true
            };
            client.Send("benaida.a.moumen@gmail.com", emailDetails.recipients.FirstOrDefault(), emailDetails.subject, emailDetails.Body);
            Console.WriteLine($"Email envoyé avec le message : {emailDetails.Body}");
            return true;    
        }
    }
}
