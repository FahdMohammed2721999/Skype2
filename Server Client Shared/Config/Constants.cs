﻿namespace Shared.Config
{
    using System.Net;

    public static class Constants
    {
        public static readonly IPAddress ServerIp = IPAddress.Parse("81.107.155.88");

        public const int TcpPort = 3001;

        public const int HttpPort = 3002;

        public const string HttpServerAddress = "http://81.107.155.88:3002";
    }
}