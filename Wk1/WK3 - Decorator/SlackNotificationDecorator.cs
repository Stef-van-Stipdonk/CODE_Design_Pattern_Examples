namespace WK3___Decorator;

public class SlackNotificationDecorator : NotificationDecorator
{
    public SlackNotificationDecorator(BaseNotification notification) : base(notification)
    {
    }

    public override string Operation()
    {
        return $"Slack: {_notification?.Operation()}";
    }
}