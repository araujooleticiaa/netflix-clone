using Netflix_Clone.SharedContext;
using System;
using System.Collections.Generic;
using System.Text;

namespace Netflix_Clone.NetflixContext
{
    public class CatalogItem : Base
    {
        public CatalogItem(string name, string description, DateTime duration)
        {

            if(name == null)
            {
                AddNotification(new NotificationContext.Notification("Error", "Campos vazios não são permitidos"));
            }

            Name = name;
            Description = description;
            Duration = duration;
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Duration { get; set; }

    }
}
