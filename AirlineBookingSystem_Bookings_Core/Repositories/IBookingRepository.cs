﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirlineBookingSystem_Bookings_Core.Entities;

namespace AirlineBookingSystem_Bookings_Core.Repositories
{
    public interface IBookingRepository
    {
        Task<Booking> GetBookingByIdAsync(Guid id);
        Task AddBookingAsync(Booking booking);
    }
}
