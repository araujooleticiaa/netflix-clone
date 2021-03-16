using Netflix_Clone.SharedContext;
using System;
using System.Collections.Generic;
using System.Text;

namespace Netflix_Clone.NetflixContext
{
    public abstract class Context : Base
    {
        public Context(string title, string url)
        {
            Title = title;
            Url = url;
        }

        public string Title { get; set; }
        public string  Url { get; set; }
    }
}
