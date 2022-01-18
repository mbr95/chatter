using System.Collections.Generic;
using System.Linq;
using Chatter.Server.Models;

namespace Chatter.Server.Infrastructure
{
    public class ChatRegistry
    {
        private readonly List<User> _users = new();
        private readonly List<string> _groups = new();

        public List<User> GetUsers()
        {
            return _users.ToList();
        }

        public string GetUserName(string id)
        {
            return _users.FirstOrDefault(u => u.Id == id)?.Name;
        }

        public void AddUser(string id, string userName)
        {
            _users.Add(new User(){Id = id, Name = userName});
        }

        public void RemoveUser(string id)
        {
            _users.RemoveAll(u => u.Id == id);
        }

        public void AddGroup(string groupName)
        {
            _groups.Add(groupName);
        }

        public bool GroupExists(string groupName)
        {
            return _groups.Contains(groupName);
        }

        public bool UserExists(string userId)
        {
            return _users.Exists(u => u.Id == userId);
        }
    }
}