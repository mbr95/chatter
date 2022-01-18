using Microsoft.AspNetCore.SignalR.Client;

namespace Chatter.Client.Providers
{
    public class ConnectionSingleton
    {
        private static ConnectionSingleton _connectionInstance;
        private static readonly object _lock = new object();

        private ConnectionSingleton()
        {
            Connection = new HubConnectionBuilder()
                .WithUrl("https://localhost:4200/chathub")
                .Build();
        }

        public HubConnection Connection { get; set; }

        public static HubConnection GetConnection()
        {
            if (_connectionInstance == null)
            {
                lock (_lock)
                {
                    if (_connectionInstance == null)
                    {
                        _connectionInstance = new ConnectionSingleton();
                    }
                }
            }

            return _connectionInstance.Connection;
        }
    }
}