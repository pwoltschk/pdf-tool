using PdfTool.CLI;
using System;
using System.Threading.Tasks;

namespace PdfTool
{
    class Program
    {
        static async Task Main(string[] args)
        {
            if (args.Length == 0)
            {
                await new HelpCommand().ExecuteAsync(null);
                return;
            }

            switch (args[0])
            {
                case "--help":
                case "-h":
                case "help":
                    await new HelpCommand().ExecuteAsync(null);
                    break;
                case "--version":
                case "-v":
                case "version":
                    //ShowVersion();
                    break;
                case "compress":
                   // Compress(args);
                    break;
                case "create":
                   // Create(args);
                    break;
                case "remove":
                   // Remove(args);
                    break;
                default:
                    Console.WriteLine($"Unknown command: {args[0]}");
                    break;
            }
        }
    }
}
