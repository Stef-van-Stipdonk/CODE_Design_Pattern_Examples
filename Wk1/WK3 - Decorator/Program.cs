

using WK3___Decorator;

var baseNotif = new Notification();
GetNotification(baseNotif);

var slackMsg = new SlackNotificationDecorator(baseNotif);
var winMsg = new WinNotificationDecorator(slackMsg);

GetNotification(winMsg);

void GetNotification(Notification notification)
{
    Console.WriteLine(notification.Operation());
}