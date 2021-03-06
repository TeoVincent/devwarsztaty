﻿using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace second_devwarsztaty
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .UseUrls("http://*:5051")
                .Build();

            host.Run();
        }
    }
}
