using System.Collections.Generic;

namespace PdfTool.CLI.Parser
{
    internal interface IOptionsParser
    {
        List<string> GetValues(string[] options, string longOption, string shortOption);

        string GetValue(string[] options, string longOption, string shortOption);
    }
}
