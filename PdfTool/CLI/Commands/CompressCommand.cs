using PdfTool.CLI.Parser;
using PdfTool.Processors;
using System;

namespace PdfTool.CLI.Commands
{
    internal class CompressCommand : CommandBase
    {
        public CompressCommand(IProcessor processor, IArgumentsFactory argumentsFactor) : base(processor, argumentsFactor)
        {
        }

        public override void Validate(ProcessorArgs args)
        {
            if (args.ReferencePaths.Count != 1)
            {
                throw new Exception("You have to specify exactly one Pdf Document");
            }
            if (args.FromPage > 0 || args.ToPage > 0)
            {
                throw new Exception("Split does not accept any page parameter");
            }
        }
    }
}

