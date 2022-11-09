namespace WK3___Decorator;

public abstract class NotificationDecorator : Notification
{
    protected BaseNotification? _notification { get; set; }

    public NotificationDecorator(BaseNotification notification)
    {
        _notification = notification;
    }

    public void SetNotification(BaseNotification notification)
    {
        _notification = notification;
    }
    
    public override string Operation()
    {
        if (_notification != null)
            return _notification.Operation();

        return string.Empty;
    }
}