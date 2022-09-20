using PdfTool.Processors;
using System.Linq;

namespace PdfTool.CLI
{
    internal class ArgumentsFactory
    {
        public static ProcessorArgs Create(string[] args)
        {
            var processorArgs = new ProcessorArgs();
            var input = args.FirstOrDefault(o => o.StartsWith("--input") || o.StartsWith("-i"));
            if (input != null)
            {
                var path = input.Split('"')[1];
                processorArgs.ReferencePaths.Add(path);
            }

            return processorArgs;
        }
    }
}
