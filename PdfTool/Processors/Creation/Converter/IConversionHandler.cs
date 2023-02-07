using System.Threading.Tasks;

namespace PdfTool.Processors.Creation.Converter
{
    internal interface IConversionHandler
    {
        public static CreationFileType CreationFileType { get; }
        public Task ConvertAsync(string inputString);
    }
}
