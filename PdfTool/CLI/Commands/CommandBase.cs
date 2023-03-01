using PdfTool.CLI.Parser;
using PdfTool.Processors;
using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;

namespace PdfTool.CLI.Commands
{
    internal abstract class CommandBase : ICommand
    {
        private readonly IProcessor _processor;
        private readonly IArgumentsFactory _argumentsFactory;
        private readonly ApplicationInfo _applicationInfo;

        protected CommandBase(
            Func<Type, IProcessor> processorFactory,
            IArgumentsFactory argumentsFactor, 
            IOptions<ApplicationInfo> applicationInfo)
        {
            _processor = processorFactory(GetType());
            _argumentsFactory = argumentsFactor;
            _applicationInfo = applicationInfo.Value;
        }

        public virtual async Task ExecuteAsync(string[] args)
        {
            var processorArgs = _argumentsFactory.Create(args);

            Validate(processorArgs);

            if (args[1] is "--help" or "-h")
            {
                Console.WriteLine(_applicationInfo.CommandDetails[GetType().Name]);
            }
            else
            {
                await _processor.ExecuteAsync(processorArgs);

            }
        }
        public abstract void Validate(ProcessorArgs args);
    }
}
