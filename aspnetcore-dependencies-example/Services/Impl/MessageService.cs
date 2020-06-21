using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspnetcoreDependenciesExample.Model;
using Microsoft.Extensions.Logging;

namespace AspnetcoreDependenciesExample.Services.Impl
{
    public class MessageService: IMessageService
    {
        private  readonly List<Message> _messages = new List<Message>();
        private readonly ILogger<MessageService> _logger;

        public MessageService(ILogger<MessageService> logger)
        {
            this._logger = logger;
        }

        public Message CreateMessage(Message message)
        {
            var createdMessage = message;
            if (message.Title.Length > message.Text.Length)
            {
                createdMessage =  new Message() { Title = message.Title.Substring(0, message.Text.Length), Text = message.Text };
            }

            _logger.LogInformation("message created");
            _logger.LogInformation("messages size {Size}", _messages.Count);
            _messages.Add(createdMessage);
            return createdMessage;
        }

        public List<Message> GetAllMessages()
        {
            return _messages.ConvertAll(message => message);
        }
    }
}
