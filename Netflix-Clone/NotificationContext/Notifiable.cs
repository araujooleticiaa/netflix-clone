using System;
using System.Collections.Generic;
using System.Text;

namespace Netflix_Clone.NotificationContext
{
    public abstract class Notifiable
    {
        public List<Notification> Notifications { get; set; }

        public Notifiable()
        {
            Notifications = new List<Notification>();
        }

        public void AddNotification(Notification notifications)
        {
            Notifications.Add(notifications);
        }

    }
}
