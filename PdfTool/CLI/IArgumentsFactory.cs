using PdfTool.Processors;

namespace PdfTool.CLI
{
    public interface IArgumentsFactory
    {
        ProcessorArgs Create(string[] args);
    }
}
