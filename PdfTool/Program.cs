﻿using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PdfTool.CLI;
using System.Threading.Tasks;

namespace PdfTool
{
    class Program
    {
        static async Task Main(string[] args)
        {
            IHostBuilder builder = Host.CreateDefaultBuilder(args);

            builder.ConfigureServices(sp =>
            {
                sp.AddCommands();
                sp.AddSingleton<PdfToolService>();
            });

            using IHost host = builder.Build();

            using (var serviceScope = host.Services.CreateScope())
            {
                var services = serviceScope.ServiceProvider;


                var service = services.GetRequiredService<PdfToolService>();
                await service.ExecuteCommand(args);

            }

            await host.RunAsync();
        }
    }
}
