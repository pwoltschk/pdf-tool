using PdfTool.CLI.Parser;
using PdfTool.Processors;

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

