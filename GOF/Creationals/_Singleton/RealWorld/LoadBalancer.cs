﻿namespace GOF.Creationals._Singleton.RealWorld
{
    public sealed class LoadBalancer
    {
        private static readonly LoadBalancer instance = new();

        private readonly List<Server> servers;
        private readonly Random random = new();

        private LoadBalancer()
        {
            servers = [
                new(Name: "ServerI", Ip: "120.14.220.18"),
                new(Name: "ServerII", Ip: "120.14.220.19"),
                new(Name: "ServerIII", Ip: "120.14.220.20"),
                new(Name: "ServerIV", Ip: "120.14.220.21"),
                new(Name: "ServerV", Ip: "120.14.220.22"),
            ];
        }

        public static LoadBalancer GetLoadBalancer()
        {
            return instance;
        }

        public Server NextServer
        {
            get => servers[random.Next(servers.Count)];
        }

    }

    public record Server(string Name, string Ip);
}
