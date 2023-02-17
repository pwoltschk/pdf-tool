using PdfTool.Processors;
using System;
using System.Linq;

namespace PdfTool.CLI.Parser
{
    internal class ArgumentsFactory : IArgumentsFactory
    {
        private readonly IOptionsParser _optionsParser;

        public ArgumentsFactory(IOptionsParser optionsParser)
        {
            _optionsParser = optionsParser;
        }

        public ProcessorArgs Create(string[] args)
        {
            var processorArgs = new ProcessorArgs();

            AddReferencePaths(processorArgs, args);
            SetPageValues(processorArgs, args);

            return processorArgs;
        }

        private void AddReferencePaths(ProcessorArgs processorArgs, string[] args)
        {
            var input = _optionsParser.GetValues(args, "--input", "-i");
            if (input.Count == 0)
            {
                processorArgs.ReferencePaths.Add(args[1]);
            }
            else
            {
                input.ForEach(p => processorArgs.ReferencePaths.Add(p));
            }
        }

        private void SetPageValues(ProcessorArgs processorArgs, string[] args)
        {
            var pages = _optionsParser.GetValues(args, "--page", "-p");
            var fromPage = _optionsParser.GetValue(args, "--from", "-f");
            var toPage = _optionsParser.GetValue(args, "--to", "-t");

            if (fromPage != null && pages.Count > 0)
            {
                throw new NotSupportedException("You cannot specify 'from/f' and 'page/p' parameter at the same time");
            }

            if (fromPage != null)
            {
                processorArgs.FromPage = int.Parse(fromPage);
            }
            else if (pages.Count > 0)
            {
                processorArgs.FromPage = int.Parse(pages[0]);
            }

            if (toPage != null)
            {
                processorArgs.ToPage = int.Parse(toPage);
            }
            else if (pages.Count > 1)
            {
                processorArgs.ToPage = int.Parse(pages[1]);
            }

            if (processorArgs.FromPage != 0 && processorArgs.ToPage != 0) 
                return;

            var numbers = args
                .Select(s => int.TryParse(s, out var n) ? n : (int?)null)
                .OfType<int>().ToArray();

            if (numbers.Any())
            {
                processorArgs.FromPage = numbers[0];
            }
            if (numbers.Length > 1)
            {
                processorArgs.ToPage = numbers[1];
            }
        }
    }
}
