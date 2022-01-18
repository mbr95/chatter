using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Chatter.Client.Models;
using Microsoft.AspNetCore.SignalR.Client;
using System.Windows.Forms;
using Chatter.Client.Providers;

namespace Chatter.Client
{
    public partial class UserWindow : Form
    {
        private HubConnection _signalRConnection;
        private readonly string _userName;
        private BindingList<User> _activeUsers;
        private BindingList<string> _displayedChat;
        private BindingList<string> _groups;
        private string _currentChat;

        public UserWindow(string userName)
        {
            InitializeComponent();
            _userName = userName;
            _activeUsers = new();
            _displayedChat = new();
            _groups = new();
            SetWindowName();
            ShowActiveUsers();
            ShowMyGroups();
        }
        
        private async void UserWindow_Shown(object sender, System.EventArgs e)
        {
            await Connect();
            await _signalRConnection.InvokeAsync("SendUpdatedUsersAfterAdding", _userName);
        }

        private async void UserWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            await _signalRConnection.StopAsync();
            FormProvider.ConnectWindow.Show();
        }
        
        private void OpenPrivateChatBtn_MouseClick(object sender, MouseEventArgs e)
        {
            if(ActiveUsers.SelectedValue != null)
            {
                _currentChat = ActiveUsers.SelectedValue.ToString();
                var connectedUser = _activeUsers.FirstOrDefault(u => u.Id == _currentChat)?.Name;
                ChatConnectionLabel.Text = $"Connected with: {connectedUser}";
                _displayedChat = new BindingList<string>();
                MessagesBox.DataSource = _displayedChat;
                _displayedChat.ResetBindings();
            }
        }
        
        private async void SendMessageBtn_Click(object sender, EventArgs e)
        {
            var message = MessageText.Text;
            await _signalRConnection.InvokeAsync("SendMessage", _currentChat, message);
        }

        private async void AddGroupBtn_Click(object sender, EventArgs e)
        {
            var groupName = GroupNameBox.Text;
            await _signalRConnection.InvokeAsync("CreateGroup", groupName);
        }

        private void GroupNameBox_TextChanged(object sender, EventArgs e)
        {
            AddGroupBtn.Enabled = GroupNameBox.Text.Length > 0;
        }

        private async void AddToGroupBtn_Click(object sender, EventArgs e)
        {
            if (ActiveUsers.SelectedItem != null && MyGroups.SelectedItem != null)
            {
                var userId = ActiveUsers.SelectedValue.ToString();
                var groupName = MyGroups.SelectedItem.ToString();
                await _signalRConnection.InvokeAsync("AddToGroup", userId, groupName);
            }
        }

        private void OpenGroupChatBtn_Click(object sender, EventArgs e)
        {
            if (MyGroups.SelectedItem != null)
            {
                var groupName = MyGroups.SelectedItem.ToString();
                _currentChat = groupName;
                ChatConnectionLabel.Text = $"Connected with: {groupName}";
                _displayedChat = new BindingList<string>();
                MessagesBox.DataSource = _displayedChat;
                _displayedChat.ResetBindings();
            }
        }

        private async Task Connect()
        {
            _signalRConnection = ConnectionSingleton.GetConnection();
            _signalRConnection.On<List<User>>("UpdateActiveUsers", (activeUsers) =>
            {
                if (activeUsers.Count > _activeUsers.Count)
                {
                    AddActiveUsers(activeUsers);
                } else if (activeUsers.Count < _activeUsers.Count)
                {
                    RemoveActiveUsers(activeUsers);
                }
            });
            _signalRConnection.On<string, string>("ReceiveMessage", (sender, message) =>
            {
                if (_currentChat == sender)
                {
                    _displayedChat.Add(message);
                }
            });
            _signalRConnection.On<string>("ReceiveCreatedGroup", groupName =>
            {
                _groups.Add(groupName);
            });
            _signalRConnection.On<string>("ReceiveAddedToGroup", groupName =>
            {
                if (!_groups.Contains(groupName))
                {
                    _groups.Add(groupName);
                }
            });
            await _signalRConnection.StartAsync();
        }
        
        private void AddActiveUsers(List<User> activeUsers)
        {
            var usersToAdd = activeUsers.Except(_activeUsers).ToList();
            foreach (var user in usersToAdd)
            {
                _activeUsers.Add(user);
            }
        }

        private void RemoveActiveUsers(List<User> activeUsers)
        {
            var usersToRemove = _activeUsers.Except(activeUsers).ToList();
            foreach (var user in usersToRemove)
            {
                _activeUsers.Remove(user);
            }
        }

        private void ShowActiveUsers()
        {
            ActiveUsers.DataSource = _activeUsers;
            ActiveUsers.DisplayMember = "Name";
            ActiveUsers.ValueMember = "Id";
        }

        private void ShowMyGroups()
        {
            MyGroups.DataSource = _groups;
        }
        
        private void SetWindowName()
        {
            Text = $"Connected as: {_userName}";
        }
    }
}