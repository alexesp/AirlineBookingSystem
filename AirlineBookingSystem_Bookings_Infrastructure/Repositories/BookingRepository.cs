﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirlineBookingSystem_Bookings_Core.Entities;
using AirlineBookingSystem_Bookings_Core.Repositories;
using Dapper;

namespace AirlineBookingSystem_Bookings_Infrastructure.Repositories
{
    public class BookingRepository: IBookingRepository
    {
        private readonly IDbConnection _dbConnection;

        public BookingRepository(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public async Task AddBookingAsync(Booking booking)
        {
            const string sql = @"
              INSERT INTO Bookings (Id, FlightId, PasswngerName, SeatNumber, BookingDate)
              VALUES (@Id, @FlightId, @PassengerName, @SeatNumber, @BookingDate)";

            await _dbConnection.ExecuteAsync(sql, booking);
        }

        public async Task<Booking> GetBookingByIdAsync(Guid id)
        {
            const string sql = "SELECT * FROM Bookings WHERE Id = @Id";
            return await _dbConnection.QuerySingleOrDefaultAsync<Booking>(sql, new { id });
        }
    }
}
