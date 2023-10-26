namespace SignalRWeb.SignalR.Interfaces
{
    public interface IMessageClient
    {
        Task ReceiveMessage(string type, string message);
    }
}
