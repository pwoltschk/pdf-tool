using Microsoft.Extensions.Options;
using PdfTool.CLI.Parser;
using PdfTool.Processors;
using System;
using System.Threading.Tasks;

namespace PdfTool.CLI.Commands
{
    internal class VersionCommand : CommandBase
    {
        public VersionCommand(Func<Type, IProcessor> processorFactory, IArgumentsFactory argumentsFactor, IOptions<ApplicationInfo> applicationInfo) 
            : base(processorFactory, argumentsFactor, applicationInfo)
        {
        }

        public override async Task ExecuteAsync(string[] args)
        {
            await Task.Run(() =>
            {
                Console.WriteLine("0.0");
            });
        }

        public override void Validate(ProcessorArgs args)
        {
        }
    }
}
