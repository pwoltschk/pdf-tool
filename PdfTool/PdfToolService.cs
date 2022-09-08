using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PdfTool.CLI;

namespace PdfTool
{
    internal class PdfToolService
    {
        public async Task ExecuteCommand(string[] args)
        {
            
            ICommand compressCommand = new HelpCommand();
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
                    await new VersionCommand().ExecuteAsync(null);
                    break;
                case "compress":
                    await compressCommand.ExecuteAsync(args);
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
