using PdfTool.Processors;
using System.Threading.Tasks;
using System;

namespace PdfTool.CLI.Commands
{
    internal class SplitCommand : ICommand
    {
        private IProcessor _processor;

        public SplitCommand(IProcessor processor)
        {
            _processor = processor;
        }

        public async Task ExecuteAsync(string[] args)
        {
            // todo introduce some factory /mapper class for the processor args
            var processorArgs = new ProcessorArgs();
            processorArgs.ReferencePaths.Add(args[2]);

            switch (args[1])
            {
                case "--input":
                case "-i":
                    await _processor.ExecuteAsync(processorArgs);
                    break;
                case "--help":
                case "-h":
                    //Todo help test for split
                    Console.WriteLine("help text for split");
                    break;
                default:
                    throw new NotSupportedException($"The option {args[1]}, is currently not suppoerted.");

            }
        }
    }
}
