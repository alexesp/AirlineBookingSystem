using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirlineBookingSystem_Flights_Application.Commands;
using AirlineBookingSystem_Flights_Core.Repositories;
using MediatR;

namespace AirlineBookingSystem_Flights_Application.Handlers
{
    public class DeleteFlightHandler :IRequestHandler<DeleteFlightCommand>
    {
        private readonly IFlightRepository _repository;

        public DeleteFlightHandler(IFlightRepository repository)
        {
            _repository = repository;
        }

        public async Task Handle(DeleteFlightCommand request, CancellationToken cancellationToken)
        {
            await _repository.DeleteFlightAsync(request.Id);
        }
    }
}
