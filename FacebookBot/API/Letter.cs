using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FacebookBot.API
{
    public class Letter
    {
        public string @object { get; set; }
        public Entry[] entry { get; set; }
    }
}
