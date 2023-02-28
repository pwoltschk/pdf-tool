using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PdfTool.CLI;
using PdfTool.Processors;
using System;
using System.IO;
using System.Net.Mime;
using System.Threading.Tasks;

namespace PdfTool
{
    internal class Program
    {
        private static async Task Main(string[] args)
        {
            var serviceCollection = new ServiceCollection();

            var configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            serviceCollection.AddProcessors();
            serviceCollection.AddCommands();
            serviceCollection.AddSingleton<PdfToolService>();
            serviceCollection.Configure<ApplicationInfo>(configuration.GetSection(ApplicationInfo.Section));

            var serviceProvider = serviceCollection.BuildServiceProvider();

            try
            {
                var service = serviceProvider.GetRequiredService<PdfToolService>();
                await service.ExecuteCommand(args);
            }
            catch (ValidationException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
