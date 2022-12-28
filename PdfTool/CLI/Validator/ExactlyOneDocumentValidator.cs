using PdfTool.Processors;

namespace PdfTool.CLI.Validator
{
    internal class ExactlyOneDocumentValidator : IExactlyOneDocumentValidator
    {
        public void Validate(ProcessorArgs args)
        {
            if (args.ReferencePaths.Count != 1)
            {
                throw new ValidationException("You have to specify exactly one Pdf Document");
            }
        }
    }
}
