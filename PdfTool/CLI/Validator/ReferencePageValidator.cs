using PdfTool.Processors;

namespace PdfTool.CLI.Validator
{
    internal class ReferencePageValidator : IReferencePageValidator
    {
        public void Validate(ProcessorArgs args)
        {
            if (args.FromPage == 0)
            {
                throw new ValidationException("This command need a reference page to be setup");
            }
        }

        public void ValidateRange(ProcessorArgs args)
        {
            if (args.FromPage is 0 or 0)
            {
                throw new ValidationException("This command need at least 2 pages specified");
            }
        }
    }
}
