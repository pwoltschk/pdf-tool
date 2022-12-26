using PdfTool.CLI.Parser;
using PdfTool.Processors;
using System;
using System.Threading.Tasks;

namespace PdfTool.CLI.Commands
{
    internal class HelpCommand : CommandBase
    {
        public HelpCommand(Func<Type, IProcessor> processorFactory, IArgumentsFactory argumentsFactor) : base(processorFactory, argumentsFactor)
        {
        }

        public override async Task ExecuteAsync(string[] args)
        {
            await Task.Run(() =>
            {
                Console.WriteLine("This is a Commandline tool for modify or create pdf documents \n " +
                "remove --input \"C:/MyPath\" --page:2\r\n" +
                "extract --input \"C:/MyPath\" --from:2 -to:4\r\n" +
                "merge --input \"C:/MyPath1\" \"C:/MyPath2\" \"C:/MyPath3\" \"C:/MyPath4\"\r\n" +
                "replace --input \"C:/MyPath\" --page 2 4\r\n" +
                "split --input \"C:/MyPath\" ");
            });

        }

        public override void Validate(ProcessorArgs args)
        {
        }
    }
}
