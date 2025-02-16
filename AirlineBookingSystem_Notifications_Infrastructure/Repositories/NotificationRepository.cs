﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirlineBookingSystem_Notifications_Core.Entities;
using AirlineBookingSystem_Notifications_Core.Repositories;
using Dapper;

namespace AirlineBookingSystem_Notifications_Infrastructure.Repositories
{
    public class NotificationRepository: INotificationRepository
    {
        private readonly IDbConnection _dbConnection;

        public NotificationRepository(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public async Task LogNotificationAsync(Notification notification)
        {
            const string sql = @"
            INSERT INTO Notifications (Id, Recipient, Message, Type, SentAt)
            VALUES (@Id, @Recipient, @Message, @Type, @SentAt)";
            await _dbConnection.ExecuteAsync(sql, notification);
        }
    }
}
