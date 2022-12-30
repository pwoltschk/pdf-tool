using PdfTool.CLI.Parser;
using PdfTool.CLI.Validator;
using PdfTool.Processors;
using System;

namespace PdfTool.CLI.Commands
{
    internal class SplitCommand : CommandBase
    {
        private readonly IExactlyOneDocumentValidator _exactlyOneValidator;
        private readonly INoPageParametersAllowedValidator _noPageParametersAllowedValidator;

        public SplitCommand(
            Func<Type, IProcessor> processorFactory,
            IArgumentsFactory argumentsFactor,
            IExactlyOneDocumentValidator exactlyOneValidator)
            : base(processorFactory, argumentsFactor)
        {
            _exactlyOneValidator = exactlyOneValidator;
        }

        public override void Validate(ProcessorArgs args)
        {
            _exactlyOneValidator.Validate(args);
            _noPageParametersAllowedValidator.Validate(args);
        }
    }
}
