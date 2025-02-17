using AirlineBookingSystem_Bookings_Application.Commands;
using AirlineBookingSystem_Bookings_Application.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AirlineBookingSystem_Booking_Api.Controllers
{
    [ApiController]
    [Route("api/bookings")]
    public class BookingsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BookingsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> AddBooking([FromBody] CreateBookingCommand command)
        {
            var id = await _mediator.Send(command);
            return CreatedAtAction(nameof(GetBookingById), new { id }, command);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBookingById(Guid id)
        {
            var booking = await _mediator.Send(new GetBookingQuery(id));
            return Ok(booking);
        }

    }
}
