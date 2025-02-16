using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirlineBookingSystem_Notifications_Core.Entities;

namespace AirlineBookingSystem_Notifications_Application.Interfaces
{
    public interface INotificationService
    {
        Task SendNotificationAsync(Notification notifications);
    }
}
