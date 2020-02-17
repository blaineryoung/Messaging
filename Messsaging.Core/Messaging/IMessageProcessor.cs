using Messaging.Objects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Messaging.Core.Messaging
{
    public interface IMessageProcessor
    {
        Task<IEnumerable<Message>> GetMessagesAsync(string userId);

        Task<Message> GetMessageAsync(string userId, Guid messageId);

        Task SendMessage(string userId, Message message);
    }
}
