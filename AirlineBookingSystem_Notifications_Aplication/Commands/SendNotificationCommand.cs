using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace AirlineBookingSystem_Notifications_Application.Commands
{
    public record SendNotificationCommand(string Recipient, string Message, string Type) : IRequest;
    
}
