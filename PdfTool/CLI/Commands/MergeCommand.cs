using PdfTool.CLI.Parser;
using PdfTool.CLI.Validator;
using PdfTool.Processors;
using System;

namespace PdfTool.CLI.Commands
{
    internal class MergeCommand : CommandBase
    {
        private readonly INoPageParametersAllowedValidator _noPageParametersAllowedValidator;

        public MergeCommand(
            Func<Type, IProcessor> processorFactory,
            IArgumentsFactory argumentsFactor,
            INoPageParametersAllowedValidator noPageParametersAllowedValidator)
            : base(processorFactory, argumentsFactor)
        {
            _noPageParametersAllowedValidator = noPageParametersAllowedValidator;
        }


        public override void Validate(ProcessorArgs args)
        {
            _noPageParametersAllowedValidator.Validate(args);

            if (args.ReferencePaths.Count < 2)
            {
                throw new ValidationException("You need to specify at least two documents that you want to merge");
            }
        }
    }
}
