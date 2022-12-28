using PdfTool.Processors;

namespace PdfTool.CLI.Validator
{
    internal interface INoPageParametersAllowedValidator
    {
        void Validate(ProcessorArgs args);
    }
}
