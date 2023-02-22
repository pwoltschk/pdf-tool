using System.Threading.Tasks;

namespace PdfTool.Processors.Creation.Converter
{
    internal interface IConversionHandler
    {
        public Task ConvertAsync(string inputString);
    }
}
