using NotificationService.Abstractions;

namespace NotificationService.Implementations
{
    public class User : IUser
    {
        public User(string name, string email, string username)
        {
            Name = name;
            Email = email;
            Username = username;
        }

        public string Name { get; }

        public string Email { get; }

        public string Username { get; }
    }
}
