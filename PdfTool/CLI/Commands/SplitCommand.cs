using PdfTool.CLI.Parser;
using PdfTool.Processors;
using System;

namespace PdfTool.CLI.Commands
{
    internal class SplitCommand : CommandBase
    {
        public SplitCommand(Func<Type, IProcessor> processorFactory, IArgumentsFactory argumentsFactor) : base(processorFactory, argumentsFactor)
        {
        }

        public override void Validate(ProcessorArgs args)
        {
            if (args.ReferencePaths.Count != 1)
            {
                throw new ValidationException("You have to specify exactly one Pdf Document");
            }
            if(args.FromPage > 0 || args.ToPage > 0)
            {
                throw new ValidationException("Split does not accept any page parameter");
            }
        }
    }
}
