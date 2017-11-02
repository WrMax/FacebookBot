using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FacebookBot.API
{
    public class Entry
    {
        public string id { get; set; }
        public string time { get; set; }
        public ContentDescription[] messaging { get; set; }

    }
}
