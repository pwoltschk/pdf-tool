using PdfTool.Processors;
using System.Threading.Tasks;
using System;
using PdfTool.CLI.Parser;

namespace PdfTool.CLI.Commands
{
    internal class SplitCommand : ICommand
    {
        private IProcessor _processor;
        private IArgumentsFactory _argumentsFactory;

        public SplitCommand(
            IProcessor processor,
            IArgumentsFactory argumentsFactory)
        {
            _processor = processor;
            _argumentsFactory = argumentsFactory;
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
