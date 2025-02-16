using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirlineBookingSystem_Flights_Application.Queries;
using AirlineBookingSystem_Flights_Core.Entities;
using AirlineBookingSystem_Flights_Core.Repositories;
using MediatR;

namespace AirlineBookingSystem_Flights_Application.Handlers
{
    public class GetAllFlightHandler : IRequestHandler<GetAllFlightsQuery, IEnumerable<Flight>>
    {
        private readonly IFlightRepository _repository;

        public GetAllFlightHandler(IFlightRepository repository)
        {
            _repository = repository; 
        }

        public async Task<IEnumerable<Flight>> Handle(GetAllFlightsQuery request, CancellationToken cancellationToken)
        {
            return await _repository.GetFlightsAsync();
        }
    }
}
