using PdfTool.CLI.Parser;
using PdfTool.Processors;

namespace PdfTool.CLI.Commands
{
    internal class SplitCommand : CommandBase
    {
        public SplitCommand(IProcessor processor, IArgumentsFactory argumentsFactor) : base(processor, argumentsFactor)
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
