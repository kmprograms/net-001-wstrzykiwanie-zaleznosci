using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspnetcoreDependenciesExample.Model;
using AspnetcoreDependenciesExample.Services;
using AspnetcoreDependenciesExample.Services.Impl;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspnetcoreDependenciesExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        private readonly IMessageService _messageService;

        public MessageController(IMessageService messageService)
        {
            _messageService = messageService;
        }

        // GET: api/message
        [HttpGet]
        public List<Message> Get()
        {
            return _messageService.GetAllMessages();
        }

        // POST: api/message
        [HttpPost]
        public Message Post( [FromBody] Message message )
        { 
            return _messageService.CreateMessage( message );
        }

    }
}
