using PdfTool.Processors;
using System;
using System.Threading.Tasks;

namespace PdfTool.CLI.Commands
{
    internal class CompressCommand : ICommand
    {
        private IProcessor _processor;

        public CompressCommand(IProcessor processor)
        {
            _processor = processor;
        }

        public async Task ExecuteAsync(string[] args)
        {
            // todo introduce some factory /mapper class for the processor args
            var processorArgs = new ProcessorArgs();
            processorArgs.ReferencePaths.Add(args[2]);

            switch(args[1])
            {
                case "--input":
                case "-i":
                    await _processor.ExecuteAsync(processorArgs);
                    break;
                case "--help":
                case "-h":
                    //Todo help test for compression
                    Console.WriteLine("help text for compression");
                break;
                default:
                    throw new System.NotSupportedException($"The option {args[1]}, is currently not suppoerted.");

            }
        }
    }
}
