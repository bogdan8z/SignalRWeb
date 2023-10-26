using Microsoft.AspNetCore.SignalR;
using SignalRWeb.Model;
using SignalRWeb.SignalR.Interfaces;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace SignalRWeb.SignalR
{
    public sealed class MessagesHub : Hub<IMessageClient>
    {
        public async Task RefreshMessageList(string message)
        {
            var messageList = new List<MessageModel>
            {
                new MessageModel
                {
                    Id = 1,
                    Description = message
                },
            };
            var jsonMessageList = JsonSerializer.Serialize(messageList, new JsonSerializerOptions { ReferenceHandler = ReferenceHandler.IgnoreCycles });


            await Clients.All.ReceiveMessage("refresh-list", jsonMessageList);
        }
    }
}
