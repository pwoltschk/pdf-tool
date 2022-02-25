using PdfTool.Processors.Creation.Converter;

namespace PdfTool.Processors.Creation
{
    internal interface IConversionHandlerFactory
    {
        public IConversionHandler Create(string inputPath);

    }
}
