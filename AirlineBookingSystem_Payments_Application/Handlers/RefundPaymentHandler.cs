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
    public class RefundPaymentHandler : IRequestHandler<RefundPaymentCommand>
    {
        private readonly IPaymentRepository _repository;

        public RefundPaymentHandler(IPaymentRepository repository)
        {
            _repository = repository;
        }

        public async Task Handle(RefundPaymentCommand request, CancellationToken cancellationToken)
        {
           
            await _repository.RefundPaymentAsync(request.PaymentId);

           
        }
    }
}
