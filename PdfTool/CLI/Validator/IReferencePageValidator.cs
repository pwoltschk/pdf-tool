using PdfTool.Processors;

namespace PdfTool.CLI.Validator
{
    internal interface IReferencePageValidator
    {
        void Validate(ProcessorArgs args);
        void ValidateRange(ProcessorArgs args);
    }
}
