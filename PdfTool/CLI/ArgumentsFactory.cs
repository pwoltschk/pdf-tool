using PdfTool.Processors;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PdfTool.CLI
{
    internal class ArgumentsFactory : IArgumentsFactory
    {
        public ProcessorArgs Create(string[] args)
        {
            var processorArgs = new ProcessorArgs();
            var input = GetOptionValues(args, "input", "i");
            var pages = GetOptionValues(args, "page", "p");
            var fromPage = GetOptionValue(args, "from", "f");
            var toPage = GetOptionValue(args, "to", "t");


            if (input.Count == 0 && fromPage == null && toPage == null && pages.Count == 0)
            {
                input.Add(args[1]);
                processorArgs.FromPage = Int32.Parse(pages[2]);
                processorArgs.ToPage = Int32.Parse(pages[3]);
                return processorArgs;
            }

            input.ForEach(p => processorArgs.ReferencePaths.Add(p));


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

            return processorArgs;
        }

        static List<string> GetOptionValues(string[] options, string longOption, string shortOption)
        {
            var optionValues = new List<string>();

            foreach (var option in options)
            {
                if (option.StartsWith("--" + longOption + " ") || option.StartsWith("-" + shortOption + " "))
                {
                    optionValues.Add(option.Split(' ')[1].Trim('"'));
                }
                else if (!option.Contains(":") && !option.Contains("-"))
                {
                    optionValues.Add(option.Trim('"'));
                }
            }

            return optionValues;
        }

        static string GetOptionValue(string[] options, string longOption, string shortOption)
        {
            return options.FirstOrDefault(o => o.StartsWith("--" + longOption + ":") || 
            o.StartsWith("-" + shortOption + ":"))?.Split(':')[1];
        }
    }
}
