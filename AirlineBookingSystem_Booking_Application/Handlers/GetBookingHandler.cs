using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirlineBookingSystem_Bookings_Application.Queries;
using AirlineBookingSystem_Bookings_Core.Entities;
using AirlineBookingSystem_Bookings_Core.Repositories;
using MediatR;

namespace AirlineBookingSystem_Bookings_Application.Handlers
{
    public class GetBookingHandler: IRequestHandler<GetBookingQuery, Booking>
    {
        private readonly IBookingRepository _repository;

        public GetBookingHandler(IBookingRepository repository)
        {
            _repository = repository;
        }  
        
        public async Task<Booking> Handle(GetBookingQuery request, CancellationToken cancellationToken)
        {
            return await _repository.GetBookingByIdAsync(request.Id);
        }
    }
}
