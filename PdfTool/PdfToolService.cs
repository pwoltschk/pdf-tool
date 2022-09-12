using PdfTool.CLI;
using System;
using System.Threading.Tasks;

namespace PdfTool
{
    internal class PdfToolService
    {
        private readonly ICommand _helpCommand;
        private readonly ICommand _compressCommand;
        private readonly ICommand _versionCommand;

        public PdfToolService(
            ICommandFactory<CompressCommand> compressCommand,
            ICommandFactory<CompressCommand> helpCommand,
            ICommandFactory<CompressCommand> versionCommand)
        {
            _compressCommand = compressCommand.Create();
            _helpCommand = helpCommand.Create();
            _versionCommand = versionCommand.Create();
        }

        public async Task ExecuteCommand(string[] args)
        {
            if (args.Length == 0)
            {
                await _helpCommand.ExecuteAsync(null);
                return;
            }

            switch (args[0])
            {
                case "--help":
                case "-h":
                case "help":
                    await _helpCommand.ExecuteAsync(null);
                    break;
                case "--version":
                case "-v":
                case "version":
                    await _versionCommand.ExecuteAsync(null);
                    break;
                case "compress":
                    await _compressCommand.ExecuteAsync(args);
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
