using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirlineBookingSystem_Notifications_Application.Interfaces;
using AirlineBookingSystem_Notifications_Core.Entities;

namespace AirlineBookingSystem_Notifications_Application.Services
{
    public class NotificationService :INotificationService
    {
        public async Task SendNotificationAsync(Notification notification)
        {
            Console.WriteLine($"Notification sent to {notification.Recipient}: {notification.Message}");
        }

    }
}
