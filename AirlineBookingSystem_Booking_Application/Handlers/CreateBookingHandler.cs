using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirlineBookingSystem_Bookings_Application.Commands;
using AirlineBookingSystem_Bookings_Core.Entities;
using AirlineBookingSystem_Bookings_Core.Repositories;
using MediatR;

namespace AirlineBookingSystem_Bookings_Application.Handlers
{
    public class CreateBookingHandler : IRequestHandler<CreateBookingCommand, Guid>
    {
        private readonly IBookingRepository _repository;


        public CreateBookingHandler(IBookingRepository repository)
        {
            _repository = repository;
        }

        public async Task<Guid> Handle(CreateBookingCommand request, CancellationToken cancellationToken)
        {
            var booking = new Booking {
                Id = Guid.NewGuid(),
                FlightId = request.FlightId,
                PassengerName = request.PassengerName,
                SeatNumber = request.SeatNumber,
                BookingDate = DateTime.UtcNow
            };

            await _repository.AddBookingAsync(booking);

            return booking.Id;
        }
    }
}
