using System;
using System.Threading.Tasks;
using Chatter.Server.Infrastructure;
using Microsoft.AspNetCore.SignalR;

namespace Chatter.Server.Hubs
{
    public class ChatHub : Hub
    {
        private readonly ChatRegistry _chatRegistry;

        public ChatHub(ChatRegistry chatRegistry)
        {
            _chatRegistry = chatRegistry;
        }

        public async Task SendUpdatedUsersAfterAdding(string userName)
        {
            _chatRegistry.AddUser(Context.ConnectionId, userName);
            var users = _chatRegistry.GetUsers();
            await Clients.All.SendAsync("UpdateActiveUsers", users);
        }

        public override async Task OnDisconnectedAsync(Exception? exception)
        {
            _chatRegistry.RemoveUser(Context.ConnectionId);
            var users = _chatRegistry.GetUsers();
            await Clients.All.SendAsync("UpdateActiveUsers", users);
            await base.OnDisconnectedAsync(exception);
        }

        public async Task SendMessage(string recipiant, string message)
        {
            var senderName = _chatRegistry.GetUserName(Context.ConnectionId);
            var content = $"[{senderName}]: {message}";
            var recipiantIsUser = _chatRegistry.UserExists(recipiant);
            if (recipiantIsUser)
            {
                await Clients.Client(recipiant).SendAsync("ReceiveMessage", Context.ConnectionId, content);
                await Clients.Caller.SendAsync("ReceiveMessage", recipiant, content);
            }
            else
            {
                await Clients.Group(recipiant).SendAsync("ReceiveMessage", recipiant, content);
            }
            
        }

        public async Task CreateGroup(string groupName)
        {
            var groupExists = _chatRegistry.GroupExists(groupName);
            if (!groupExists)
            {
                _chatRegistry.AddGroup(groupName);
                await Groups.AddToGroupAsync(Context.ConnectionId, groupName);
                await Clients.Caller.SendAsync("ReceiveCreatedGroup", groupName);
            }
        }

        public async Task AddToGroup(string userId, string groupName)
        {
            var groupExists = _chatRegistry.GroupExists(groupName);
            if (groupExists)
            {
                await Groups.AddToGroupAsync(userId, groupName);
                await Clients.Client(userId).SendAsync("ReceiveAddedToGroup", groupName);
            }
        }
    }
}