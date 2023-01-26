using Microsoft.AspNetCore.SignalR;

namespace CollaborationSingalR.Server.Hubs
{
    public class CollaborateHub : Hub
    {
        public override async Task OnConnectedAsync()
        {
            await SendEvent("", "User connected");
            await base.OnConnectedAsync();
        }

        public async Task SendEvent(string user, string move)
        {
            await Clients.All.SendAsync("ReceiveMoveObject", user, move);
        }
    }    
}
