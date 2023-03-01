using PdfTool.CLI.Parser;
using PdfTool.Processors;
using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using System.Collections.Generic;

namespace PdfTool.CLI.Commands
{
    internal class HelpCommand : CommandBase
    {
        private readonly ApplicationInfo _applicationInfo;
        public HelpCommand(Func<Type, IProcessor> processorFactory, IArgumentsFactory argumentsFactor, IOptions<ApplicationInfo> applicationInfo)
            : base(processorFactory, argumentsFactor, applicationInfo)
        {
            _applicationInfo = applicationInfo.Value;
        }

        public override async Task ExecuteAsync(string[] args)
        {
            await Task.Run(() =>
            {
                Console.WriteLine(_applicationInfo.MainText);
                foreach (KeyValuePair<string, string> entry in _applicationInfo.CommandDetails)
                {
                    Console.WriteLine($"The {entry.Key}:\n{entry.Value}\n");
                }
            });

        }

        public override void Validate(ProcessorArgs args)
        {
        }
    }
}
