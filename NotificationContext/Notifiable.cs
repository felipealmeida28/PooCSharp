namespace PooCSharp.NotificationContext
{
    public abstract class Notifiable
    {
        public List<Notification> Notifications { get; set; }

        public void AddNotifications(Notification notification)
        {
            Notifications.Add(notification);
        }

        public void AddNotifications(IEnumerable<Notification> notification)
        {
            Notifications.AddRange(notification);
        }

        public bool IsInvalid => Notifications.Any();


    }
}