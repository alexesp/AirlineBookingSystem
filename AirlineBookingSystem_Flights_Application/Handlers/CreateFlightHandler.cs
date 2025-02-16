using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirlineBookingSystem_Flights_Application.Commands;
using AirlineBookingSystem_Flights_Core.Entities;
using AirlineBookingSystem_Flights_Core.Repositories;
using MediatR;

namespace AirlineBookingSystem_Flights_Application.Handlers
{
    public class CreateFlightHandler : IRequestHandler<CreateFlightCommand, Guid>
    {
        private readonly IFlightRepository _repository;

        public CreateFlightHandler(IFlightRepository repository)
        {
            _repository = repository;
        }

        public async Task<Guid> Handle(CreateFlightCommand request, CancellationToken cancellationToken)
        {
            var flight = new Flight
            {
                Id = Guid.NewGuid(),
                FlightNumber = request.FlightNumber,
                Origin = request.Origin,
                Destination = request.Destination,
                DepartureTime = request.DepartureTime,
                ArrivalTime = request.ArrivelTime


            };

            await _repository.AddFlightAsync(flight);
            return flight.Id;
        }
    }
}
