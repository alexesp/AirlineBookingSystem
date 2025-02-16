using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace AirlineBookingSystem_Flights_Application.Commands
{
    public record CreateFlightCommand(string FlightNumber, string Origin, string Destination, DateTime DepartureTime, DateTime ArrivelTime): IRequest<Guid>;
   
}
