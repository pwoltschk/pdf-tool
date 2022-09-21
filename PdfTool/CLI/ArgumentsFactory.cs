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
            var input = GetOptionValues(args, "input");
            var pages = GetOptionValue(args, "page");

            input.ForEach(p => processorArgs.ReferencePaths.Add(p));
            processorArgs.FromPage = Int32.Parse(pages);


            return processorArgs;
        }

        static List<string> GetOptionValues(string[] options, string option)
        {
            return options.Where(o => o.StartsWith("--" + option + " "))
                          .Select(o => o.Split(' ')[1].Trim('"'))
                          .ToList();
        }

        static string GetOptionValue(string[] options, string option)
        {
            return options.FirstOrDefault(o => o.StartsWith("--" + option + ":"))?.Split(':')[1];
        }
    }
}
