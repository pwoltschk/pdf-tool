using PdfTool.CLI.Parser;
using PdfTool.CLI.Validator;
using PdfTool.Processors;
using System;

namespace PdfTool.CLI.Commands
{
    internal class RemoveCommand : CommandBase
    {
        private readonly IExactlyOneDocumentValidator _exactlyOneValidator;
        private readonly IReferencePageValidator _referencePageValidator;

        public RemoveCommand(
            Func<Type, IProcessor> processorFactory,
            IArgumentsFactory argumentsFactor,
            IExactlyOneDocumentValidator exactlyOneValidator,
            IReferencePageValidator referencePageValidator)
            : base(processorFactory, argumentsFactor)
        {
            _exactlyOneValidator = exactlyOneValidator;
            _referencePageValidator = referencePageValidator;
        }

        public override void Validate(ProcessorArgs args)
        {
            _exactlyOneValidator.Validate(args);
            _referencePageValidator.Validate(args);
        }
    }
}
