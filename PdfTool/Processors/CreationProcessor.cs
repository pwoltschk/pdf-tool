
using PdfTool.Processors.Creation;

namespace PdfTool.Processors
{
    internal class CreationProcessor
    {
        private readonly IConversionHandlerFactory _conversionHandlerFactory;

        public CreationProcessor(IConversionHandlerFactory conversionHandlerFactory)
        {
            _conversionHandlerFactory = conversionHandlerFactory;
        }

        public void Create(string inputPath)
        {
            var converter = _conversionHandlerFactory.Create(inputPath);

            converter.Convert(inputPath);
        }
    }
}
