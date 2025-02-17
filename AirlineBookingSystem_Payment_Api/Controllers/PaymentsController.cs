using AirlineBookingSystem_Payments_Application.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AirlineBookingSystem_Payment_Api.Controllers
{
    [ApiController]
    [Route("api/payments")]
    public class PaymentsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PaymentsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> ProcessPayment([FromBody] ProcessPaymentCommand command)
        {
            var id = await _mediator.Send(command);
            return CreatedAtAction(nameof(ProcessPayment), new { id }, command);
        }

        [HttpPost]
        public async Task<IActionResult> RefundPayment(Guid id)
        {
            await _mediator.Send(new RefundPaymentCommand(id));
            return NoContent();
        }
       
    }
}
