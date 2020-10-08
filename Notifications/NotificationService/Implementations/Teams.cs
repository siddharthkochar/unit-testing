using System;
using System.Collections.Generic;
using NotificationService.Abstractions;

namespace NotificationService.Implementations
{
    public class Teams : INotificationService
    {
        private readonly IUser _user;

        public Teams(IUser user)
        {
            _user = user;
        }

        public bool Notify()
        {
            Console.WriteLine($"Notified {_user.Username} on Microsoft Teams");
            return true;
        }
    }
}
