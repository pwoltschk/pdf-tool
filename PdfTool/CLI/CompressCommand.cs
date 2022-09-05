using PdfTool.Processors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdfTool.CLI
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
            processorArgs.ReferencePaths.Add(args[1]);

            await _processor.ExecuteAsync(processorArgs); 
        }
    }
}
