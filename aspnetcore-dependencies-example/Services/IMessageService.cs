using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspnetcoreDependenciesExample.Model;

namespace AspnetcoreDependenciesExample.Services
{
    public interface IMessageService
    {
        Message CreateMessage(Message message);
        List<Message> GetAllMessages();
    }
}
