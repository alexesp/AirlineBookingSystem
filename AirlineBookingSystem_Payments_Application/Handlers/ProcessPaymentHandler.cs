using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirlineBookingSystem_Payments_Application.Commands;
using AirlineBookingSystem_Payments_Core.Entities;
using AirlineBookingSystem_Payments_Core.Repositories;
using MediatR;

namespace AirlineBookingSystem_Payments_Application.Handlers
{
    public class ProcessPaymentHandler : IRequestHandler<ProcessPaymentCommand, Guid>
    {
        private readonly IPaymentRepository _repository;

        public ProcessPaymentHandler(IPaymentRepository repository)
        {
            _repository = repository;
        }

        public async Task<Guid> Handle(ProcessPaymentCommand request, CancellationToken cancellationToken)
        {
            var payment = new Payment
            {
                Id = Guid.NewGuid(),
                BookingId = Guid.NewGuid(),
                Amount = request.Amount,
                PaymentDate = DateTime.UtcNow
            };

            await _repository.ProcessPaymentAsync(payment);

            return payment.Id;
        }
    }
}
