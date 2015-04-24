using System;
using Microsoft.Owin.Hosting;

namespace SelfHostedSignalR
{
    // Adapted from :: http://www.asp.net/signalr/overview/deployment/tutorial-signalr-self-host#server
    class Program
    {
        static void Main(string[] args)
        {
            const string url = "http://localhost:8080";

            using (WebApp.Start(url))
            {
                Console.WriteLine("Server running on {0}", url);
                Console.ReadLine();
            }
        }
    }
}
