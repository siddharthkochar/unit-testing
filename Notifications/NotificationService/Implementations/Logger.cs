using System;
using NotificationService.Abstractions;

namespace NotificationService.Implementations
{
    public class Logger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
