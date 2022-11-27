using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdfTool.CLI.Parser
{
    internal interface IOptionsParser
    {
        List<string> GetValues(string[] options, string longOption, string shortOption);

        string GetValue(string[] options, string longOption, string shortOption);
    }
}
