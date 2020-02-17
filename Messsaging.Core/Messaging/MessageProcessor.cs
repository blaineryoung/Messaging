using Messaging.Objects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Messaging.Core.Messaging
{
#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously

    public class MessageProcessor : IMessageProcessor
    {

        public async Task<Message> GetMessageAsync(string userId, Guid messageId)

        {
            return MakeMessage(userId);
        }

        public async Task<IEnumerable<Message>> GetMessagesAsync(string userId)
        {
            List<Message> messages = new List<Message>();

            for (int i = 0; i < 10; i++)
            {
                messages.Add(MakeMessage(userId));
            }

            return messages;
        }


        public async Task SendMessage(string userId, Message message)

        {
            // do nothing
        }

#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
        private Message MakeMessage(string userId)
        {
            return new Message()
            {
                Content = "Lorem Ipsom",
                MessageTime = DateTime.Now,
                Recipient = userId,
                Sender = "foo@bar.com"
            };
        }
    }
}
