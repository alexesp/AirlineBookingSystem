﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace AirlineBookingSystem_Bookings_Application.Commands
{
    public record CreateBookingCommand(Guid FlightId, string PassengerName, string SeatNumber) : IRequest<Guid>;
    
}
