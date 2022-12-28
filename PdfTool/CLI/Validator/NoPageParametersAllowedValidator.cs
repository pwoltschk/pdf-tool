using PdfTool.Processors;

namespace PdfTool.CLI.Validator
{
    internal class NoPageParametersAllowedValidator : INoPageParametersAllowedValidator
    {
        public void Validate(ProcessorArgs args)
        {
            if (args.FromPage > 0 || args.ToPage > 0)
            {
                throw new ValidationException("this command does not accept any page parameter");
            }
        }
    }
}
