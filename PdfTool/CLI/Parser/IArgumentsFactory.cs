using PdfTool.Processors;

namespace PdfTool.CLI.Parser
{
    public interface IArgumentsFactory
    {
        ProcessorArgs Create(string[] args);
    }
}
