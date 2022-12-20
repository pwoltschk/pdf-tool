using PdfTool.CLI.Parser;
using PdfTool.Processors;
using System;

namespace PdfTool.CLI.Commands
{
    internal class SplitCommand : CommandBase
    {
        public SplitCommand(IProcessor processor, IArgumentsFactory argumentsFactor) : base(processor, argumentsFactor)
        {
        }

        public override void Validate(ProcessorArgs args)
        {
            throw new NotImplementedException();
        }
    }
}
