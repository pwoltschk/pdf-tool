using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PdfTool.CLI;
using PdfTool.Processors;
using System;
using System.Threading.Tasks;

namespace PdfTool
{
    internal class Program
    {
        private static async Task Main(string[] args)
        {
            var serviceCollection = new ServiceCollection();


            serviceCollection.AddProcessors();
            serviceCollection.AddCommands();
            serviceCollection.AddSingleton<PdfToolService>();


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
