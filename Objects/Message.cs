using System;

namespace Messaging.Objects
{
    public class Message
    {
        public string Recipient { get; set; }
        public string Sender { get; set; }
        public DateTime MessageTime { get; set; }
        public string Content { get; set; }
    }
}
