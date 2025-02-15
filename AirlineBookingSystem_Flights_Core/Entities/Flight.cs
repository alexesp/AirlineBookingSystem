using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineBookingSystem_Flights_Core.Entities
{
    public class Flight
    {
        public Guid Id { get; set; }
        public string FlightName { get; set; }
        public string Origin { get; set; }
        public string Destinations { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }

    }
}
