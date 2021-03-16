using Netflix_Clone.SharedContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Netflix_Clone.NetflixContext
{
    public class Catalog : Context
    {
        public Catalog(string title, string url) : base(title, url)
        {
            Items = new List<CatalogItem>();
        }

        public List<CatalogItem> Items { get; set; }

        public int totality
        {
            get
            {
                return Items.Count();
            }
        }
    }
}   
