namespace RefactoringLab;

public interface INotificationChannel
{
    void Send(string to, string message, DateTime? sendAt);
}

public class EmailNotificationChannel : INotificationChannel
{
    public void Send(string to, string message, DateTime? sendAt)
    {
        if (sendAt.HasValue)
        {
            Console.WriteLine(
                $"[email scheduled {sendAt.Value:g}] {to}: {message}");
        }
        else
        {
            Console.WriteLine($"[email] {to}: {message}");
        }
    }
}

public class SmsNotificationChannel : INotificationChannel
{
    public void Send(string to, string message, DateTime? sendAt)
    {
        if (sendAt.HasValue)
        {
            Console.WriteLine(
                $"[sms scheduled {sendAt.Value:g}] {to}: {message}");
        }
        else
        {
            Console.WriteLine($"[sms] {to}: {message}");
        }
    }
}
public class PushNotificationChannel : INotificationChannel
{
    public void Send(string to, string message, DateTime? sendAt)
    {
        if (sendAt.HasValue)
        {
            Console.WriteLine(
                $"[push scheduled {sendAt.Value:g}] {to}: {message}");
        }
        else
        {
            Console.WriteLine($"[push] {to}: {message}");
        }
    }
}

public class UrgentNotificationChannel : INotificationChannel
{
    private readonly INotificationChannel _inner;

    public UrgentNotificationChannel(INotificationChannel inner)
    {
        _inner = inner;
    }

    public void Send(string to, string message, DateTime? sendAt)
    {
        _inner.Send(to, $"[URGENT] {message}", sendAt);
    }
}

public class ScheduledNotificationChannel : INotificationChannel
{
    private readonly INotificationChannel _inner;
    private readonly DateTime _sendAt;

    public ScheduledNotificationChannel(
        INotificationChannel inner,
        DateTime sendAt)
    {
        _inner = inner;
        _sendAt = sendAt;
    }

    public void Send(string to, string message, DateTime? sendAt)
    {
        _inner.Send(to, message, _sendAt);
    }
}