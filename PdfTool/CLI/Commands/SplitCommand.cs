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

            if(args.FromPage > 0 || args.ToPage > 0)
            {
                throw new ValidationException("this command does not accept any page parameter");
            }
        }
    }
}
