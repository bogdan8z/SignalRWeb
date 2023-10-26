using Microsoft.AspNetCore.Mvc;
using SignalRWeb.Model;
using System.Text.Json.Serialization;
using System.Text.Json;
using Microsoft.AspNetCore.SignalR;
using SignalRWeb.SignalR.Interfaces;
using SignalRWeb.SignalR;

namespace SignalRWeb.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MessageController : ControllerBase
    {
        readonly IHubContext<MessagesHub, IMessageClient> _mydataHub;
        public MessageController(IHubContext<MessagesHub, IMessageClient> mydataHub)
        {
            _mydataHub = mydataHub;
        }

        [HttpPost]
        public async Task SendNewMessageAsync()
        {
            var messageList = new List<MessageModel>
            {
                new MessageModel
                {
                    Id = 1,
                    Description = "message-1"
                },
                new MessageModel
                {
                    Id = 2,
                    Description = "message-2"
                }
            };
            var jsonMessageList = JsonSerializer.Serialize(messageList, new JsonSerializerOptions { ReferenceHandler = ReferenceHandler.IgnoreCycles });

            await _mydataHub.Clients.All.ReceiveMessage("new-messages", jsonMessageList);
        }
    }
}
