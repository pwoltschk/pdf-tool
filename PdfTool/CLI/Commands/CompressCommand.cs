using PdfTool.CLI.Parser;
using PdfTool.Processors;
using System;
using System.Threading.Tasks;

namespace PdfTool.CLI.Commands
{
    internal class CompressCommand : ICommand
    {
        private readonly IProcessor _processor;
        private readonly IArgumentsFactory _argumentsFactory;

        public CompressCommand(
            IProcessor processor,
            IArgumentsFactory argumentsFactor)
        {
            _processor = processor;
            _argumentsFactory = argumentsFactor;
        }

        public async Task ExecuteAsync(string[] args)
        {
            var processorArgs = _argumentsFactory.Create(args);

            if (args[1] is "--help" or "-h")
            {
                Console.WriteLine("help text for split");

            }
            else
            {
                await _processor.ExecuteAsync(processorArgs);

            }
        }
    }
}

