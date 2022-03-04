using PdfTool.Processors.Creation.Converter.Libre;

namespace PdfTool.Processors.Creation.Converter
{
    internal class WordConversionHandler : IConversionHandler
    {
        public void Convert(string inputString)
        {
            new LibreProcessExecutor().ConvertToPdf(inputString);
        }
    }
}
