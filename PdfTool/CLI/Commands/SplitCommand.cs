using PdfTool.Processors;
using System.Threading.Tasks;
using System;
using PdfTool.CLI.Parser;

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
