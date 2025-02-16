using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirlineBookingSystem_Payments_Core.Entities;
using AirlineBookingSystem_Payments_Core.Repositories;
using Dapper;

namespace AirlineBookingSystem_Payments_Infrastructure.Repositories
{
    public class PaymentRespository: IPaymentRepository
    {
        private readonly IDbConnection _dbConnection;

        public PaymentRespository(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public async Task ProcessPaymentAsync(Payment payment)
        {
            const string sql = @"
            INSERT INTO Payments (Id, BookingId, Amount, PaymentDate)
            VALUES (@iD, @BookingId, @Amount, @PaymentDate)";
            await _dbConnection.ExecuteAsync(sql, payment);
        }

        public async Task RefundPaymentAsync(Guid id)
        {
            const string sql = "DELETE FROM Payments WHERE Id = @Id";
            await _dbConnection.ExecuteAsync(sql, new {Id = id});
        }
    }
}
