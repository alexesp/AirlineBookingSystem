using AirlineBookingSystem_Flights_Application.Commands;
using AirlineBookingSystem_Flights_Application.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AirlineBookingSystem_Flight_Api.Controllers
{
    [ApiController]
    [Route("api/flights")]
    public class FligtsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public FligtsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> AddFlights([FromBody] CreateFlightCommand command)
        {
            var id = await _mediator.Send(command);
            return CreatedAtAction(nameof(GetFlights), new { id }, command);
        }

        [HttpGet]
        public async Task<IActionResult> GetFlights(Guid id)
        {
            var flights = await _mediator.Send(new GetAllFlightsQuery());
            return Ok(flights);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFlight(Guid id)
        {
            await _mediator.Send(new DeleteFlightCommand(id));
            return NoContent();
        }
    }
}
