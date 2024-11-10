using System;
using Microsoft.AspNetCore.SignalR;

namespace signal_r_init.Hubs
{
	public class ChatHub:Hub
	{
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}

