using PdfTool.Processors;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PdfTool.CLI
{
    internal class ArgumentsFactory
    {
        public static ProcessorArgs Create(string[] args)
        {
            var processorArgs = new ProcessorArgs();
            var input = GetOptionValues(args, "input", "i");
            var pages = GetOptionValues(args, "page", "p");
            var fromPage = GetOptionValue(args, "from");
            var toPage = GetOptionValue(args, "to");


            input.ForEach(p => processorArgs.ReferencePaths.Add(p));
            processorArgs.FromPage = Int32.Parse(pages[0]);
            processorArgs.ToPage = Int32.Parse(pages[1]);

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

        static string GetOptionValue(string[] options, string option)
        {
            return options.FirstOrDefault(o => o.StartsWith("--" + option + ":"))?.Split(':')[1];
        }
    }
}
