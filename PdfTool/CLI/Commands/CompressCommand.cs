using Microsoft.Extensions.Options;
using PdfTool.CLI.Parser;
using PdfTool.CLI.Validator;
using PdfTool.Processors;
using System;

namespace PdfTool.CLI.Commands
{
    internal class CompressCommand : CommandBase
    {
        private readonly IExactlyOneDocumentValidator _exactlyOneValidator;
        private readonly INoPageParametersAllowedValidator _noPageParametersAllowedValidator;
        public CompressCommand(
            Func<Type, IProcessor> processorFactory,
            IArgumentsFactory argumentsFactor,
            IExactlyOneDocumentValidator exactlyOneValidator,
            IOptions<ApplicationInfo> applicationInfo,
            INoPageParametersAllowedValidator noPageParametersAllowedValidator)
            : base(processorFactory, argumentsFactor, applicationInfo)
        {
            _exactlyOneValidator = exactlyOneValidator;
            _noPageParametersAllowedValidator = noPageParametersAllowedValidator;
        }

        public override void Validate(ProcessorArgs args)
        {
            _exactlyOneValidator.Validate(args);
            _noPageParametersAllowedValidator.Validate(args);
        }
    }
}

