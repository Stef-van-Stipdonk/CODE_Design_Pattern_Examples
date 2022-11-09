namespace WK3___Decorator;

public class WinNotificationDecorator : NotificationDecorator
{
    public WinNotificationDecorator(BaseNotification notification) : base(notification)
    {
    }

    public override string Operation()
    {
        return $"Windows: {_notification?.Operation()}";
    }
}