using AirlineBookingSystem_Notifications_Application.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AirlineBookingSystem_Notification_Api.Controllers
{
    [ApiController]
    [Route("api/notifications")]
    public class NotificationsController : ControllerBase
    {

        private readonly IMediator _mediator;

        public NotificationsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> SendNotification([FromBody] SendNotificationCommand command)
        {
             await _mediator.Send(command);
            return Ok();
        }


    }
}
