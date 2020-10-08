using System;
using NotificationService.Abstractions;

namespace NotificationService.Implementations
{
    public class Email : INotificationService
    {
        private readonly IUser _user;
        private readonly ILogger _logger;

        public Email(IUser user, ILogger logger)
        {
            _user = user;
            _logger = logger;
        }

        public bool Notify()
        {
            if (string.IsNullOrEmpty(_user.Email))
            {
                _logger.Log("User email is empty");
                return false;
            }

            Console.WriteLine($"Hello {_user.Name}! Your email {_user.Email} has been activated.");
            return true;
        }
    }
}
