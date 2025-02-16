using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirlineBookingSystem_Flights_Core.Entities;
using MediatR;

namespace AirlineBookingSystem_Flights_Application.Queries
{
    public record GetAllFlightsQuery : IRequest<IEnumerable<Flight>>;
    
}
