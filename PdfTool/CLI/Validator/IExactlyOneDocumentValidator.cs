using PdfTool.Processors;

namespace PdfTool.CLI.Validator
{
    internal interface IExactlyOneDocumentValidator
    {
        void Validate(ProcessorArgs args);
    }
}
