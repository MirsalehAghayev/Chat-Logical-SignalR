using Microsoft.AspNetCore.SignalR;

namespace Signal_WebP323.Hubs
{
    public class ChatHub : Hub
    {
        public async Task AddTogroup(string group) 
        {
           await Groups.AddToGroupAsync(Context.ConnectionId, group);
        }

        public async Task RemoveFromGroup(string group) 
        {
           await Groups.RemoveFromGroupAsync(Context.ConnectionId, group);
        
        }
        public async Task SendMessage(string user, string group, string message)
        {
            await Clients.Group(group).SendAsync("ReceiveMessage", user, message);
        }

    }
}
