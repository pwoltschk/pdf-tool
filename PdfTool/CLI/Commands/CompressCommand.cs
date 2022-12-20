using PdfTool.CLI.Parser;
using PdfTool.Processors;
using System;
using System.Threading.Tasks;

namespace PdfTool.CLI.Commands
{
    internal class CompressCommand : CommandBase
    {
        public CompressCommand(IProcessor processor, IArgumentsFactory argumentsFactor) : base(processor, argumentsFactor)
        {
        }

        public override void Validate(ProcessorArgs args)
        {
        }
    }
}

