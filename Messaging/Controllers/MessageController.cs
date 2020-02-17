using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Messaging.Core.Messaging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Messaging.Objects;

namespace Messaging.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        private readonly ILogger<MessageController> _logger;
        private readonly IMessageProcessor _messageProcessor;

        public MessageController(
            ILogger<MessageController> logger,
            IMessageProcessor messageProcessor)
        {
            _logger = logger;
            _messageProcessor = messageProcessor;
        }

        // GET: api/Message
        [HttpGet]
        public async Task<IEnumerable<Message>> Get()
        {
            return await _messageProcessor.GetMessagesAsync("foo");
        }

        // GET: api/Message/5
        [HttpGet("{id}", Name = "Get")]
        public async Task<Message> Get(Guid id)
        {
            return await _messageProcessor.GetMessageAsync("foo", id);
        }

        // POST: api/Message
        [HttpPost]
        public async Task Post([FromBody] Message value)
        {
            await _messageProcessor.SendMessage("foo", value);
        }


    }
}
