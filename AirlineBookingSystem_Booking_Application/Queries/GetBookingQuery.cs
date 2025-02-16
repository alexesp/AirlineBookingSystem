using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirlineBookingSystem_Bookings_Core.Entities;
using MediatR;

namespace AirlineBookingSystem_Bookings_Application.Queries
{
    public record GetBookingQuery(Guid Id): IRequest<Booking>;
    
}
