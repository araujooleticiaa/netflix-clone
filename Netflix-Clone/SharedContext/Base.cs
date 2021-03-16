using Netflix_Clone.NotificationContext;
using System;
using System.Collections.Generic;
using System.Text;

namespace Netflix_Clone.SharedContext
{
    public abstract class Base : Notifiable
    {
        public Base()
        {
            Id = new Guid();
        }

        public Guid Id { get; set; }
    }
}
