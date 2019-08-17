using System.IO;
using Microsoft.AspNetCore.Hosting;
using System;

namespace PierresTreats
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("asdf;");
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .Build();

            host.Run();
        }
    }
}