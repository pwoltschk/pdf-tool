﻿using PdfTool.CLI;
using PdfTool.CLI.Commands;
using System;
using System.Threading.Tasks;

namespace PdfTool
{
    internal class PdfToolService
    {
        private readonly ICommand _helpCommand;
        private readonly ICommand _compressCommand;
        private readonly ICommand _versionCommand;
        private readonly ICommand _splitCommand;
        private readonly ICommand _createCommand;
        private readonly ICommand _removeCommand;
        private readonly ICommand _extractCommand;
        private readonly ICommand _mergeCommand;
        private readonly ICommand _replaceCommand;

        public PdfToolService(
            ICommandFactory<CompressCommand> compressCommand,
            ICommandFactory<SplitCommand> splitCommand,
            ICommandFactory<HelpCommand> helpCommand,
            ICommandFactory<VersionCommand> versionCommand,
            ICommandFactory<CreateCommand> createCommand,
            ICommandFactory<RemoveCommand> removeCommand,
            ICommandFactory<ExtractCommand> extractCommand,
            ICommandFactory<ReplaceCommand> replaceCommand,
            ICommandFactory<MergeCommand> mergeCommand)
        {
            _compressCommand = compressCommand.Create();
            _helpCommand = helpCommand.Create();
            _versionCommand = versionCommand.Create();
            _splitCommand = splitCommand.Create();
            _createCommand = createCommand.Create();
            _removeCommand = removeCommand.Create();
            _extractCommand = extractCommand.Create();
            _replaceCommand = replaceCommand.Create();
            _mergeCommand = mergeCommand.Create();
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
                    await _createCommand.ExecuteAsync(args);
                    break;
                case "remove":
                    await _removeCommand.ExecuteAsync(args);
                    break;
                case "split":
                    await _splitCommand.ExecuteAsync(args);
                    break;
                case "extract":
                    await _extractCommand.ExecuteAsync(args);
                    break;
                case "replace":
                    await _replaceCommand.ExecuteAsync(args);
                    break;
                case "merge":
                    await _mergeCommand.ExecuteAsync(args);
                    break;
                default:
                    Console.WriteLine($"The specified command: {args[0]} is not available");
                    break;
            }
        }
    }
}
