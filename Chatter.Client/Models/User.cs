using System;

namespace Chatter.Client.Models
{
    public class User : IEquatable<User>
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public bool Equals(User? other)
        {
            return other?.Id == Id;
        }

        public override bool Equals(object obj)
        {
            return obj is User && ((User)obj).Id == Id;
        }

        public override int GetHashCode()
        {
            return (Id, Name).GetHashCode();
        }
    }
}
