using System.Collections.Generic;
using System.Linq;

namespace PdfTool.CLI.Parser
{
    internal class OptionsParser : IOptionsParser
    {
        public List<string> GetValues(string[] options, string longOption, string shortOption)
        {
            var optionValues = new List<string>();
            for (var i = 0; i < options.Length; i++)
            {
                if (options[i] != longOption && options[i] != shortOption) 
                    continue;

                for (var j = i + 1; j < options.Length; j++)
                {
                    if (options[j].StartsWith("--") || options[j].StartsWith("-"))
                    {
                        break;
                    }
                    optionValues.Add(options[j].Trim('"'));
                }
            }

            return optionValues;
        }

        public string GetValue(string[] options, string longOption, string shortOption)
        {
            return options.FirstOrDefault(o => o.StartsWith(longOption + ":") ||
            o.StartsWith(shortOption + ":"))?.Split(':')[1];
        }
    }
}
