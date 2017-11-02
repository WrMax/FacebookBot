using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FacebookBot.API
{
    public class ContentDescription
    {
        public User sender { get; set; }
        public User recipient { get; set; }
        public string timestamp { get; set; }
        public Message message { get; set; }

    }
}
