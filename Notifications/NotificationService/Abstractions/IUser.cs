namespace NotificationService.Abstractions
{
    public interface IUser
    {
        string Name { get; }
        string Email { get; }
        string Username { get; }
    }
}
