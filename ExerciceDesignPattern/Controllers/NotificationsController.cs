using ExerciceDesignPattern.Dtos;
using ExerciceDesignPattern.Factory;
using ExerciceDesignPattern.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExerciceDesignPattern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationsController : ControllerBase
    {
        private readonly IEmailNotificationService _EmailnotifcationService;
        private readonly ISmsNotificationService _SmsnotifcationService;

        public NotificationsController(IEmailNotificationService emailnotificationService, ISmsNotificationService smsNotificationServ) {
            _EmailnotifcationService = emailnotificationService;
            _SmsnotifcationService = smsNotificationServ;

        }
        [HttpPost]
        [Route("SendEmail")]

        public async Task<IActionResult> SendEmail([FromBody] NotificationsDto emailDetails)
        {

            return Ok(_EmailnotifcationService.SendEmail(emailDetails));
        }

        [HttpPost]
        [Route("SendSms")]

        public async Task<IActionResult> SendSms([FromBody] NotificationsDto smsDetails)
        {

            return Ok(_SmsnotifcationService.sendSms(smsDetails));
        }
    }
}
