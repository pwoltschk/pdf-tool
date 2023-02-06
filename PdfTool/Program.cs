using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PdfTool.CLI;
using PdfTool.Processors;
using System;
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
                sp.AddProcessors();
                sp.AddCommands();
                sp.AddSingleton<PdfToolService>();
            });

            using IHost host = builder.Build();

            using var serviceScope = host.Services.CreateScope();
            var services = serviceScope.ServiceProvider;

            try
            {
                var service = services.GetRequiredService<PdfToolService>();
                await service.ExecuteCommand(args);
            }
            catch (ValidationException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
