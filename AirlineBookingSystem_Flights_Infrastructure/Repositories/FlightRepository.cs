using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirlineBookingSystem_Flights_Core.Entities;
using AirlineBookingSystem_Flights_Core.Repositories;
using Dapper;

namespace AirlineBookingSystem_Flights_Infrastructure.Repositories
{
    public class FlightRepository: IFlightRepository
    {
        private readonly IDbConnection _dbConnection;

        public FlightRepository(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public async Task AddFlightAsync(Flight flight)
        {
            const string sql = @"
            INSERT INTO Flights (Id, FlightNumber, Origin, Destinations,DepartureTime, ArrivalTime)
            VALUES (@Id, @FlightNumber, @Origin, @Destination, @DepartureTime, @ArrivalTime)";
        }

        public async Task DeleteFlightAsync(Guid id)
        {
            const string sql = "DELETE FROM Flights WHERE Id = @Id";
            await _dbConnection.ExecuteAsync(sql, new { id });
        }

        public async Task<IEnumerable<Flight>> GetFlightsAsync()
        {
            const string sql = "SELECT * FROM Flights";
            return await _dbConnection.QueryAsync<Flight>(sql);
        }
    }
}
