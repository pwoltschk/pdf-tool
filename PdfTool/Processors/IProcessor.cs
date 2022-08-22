using System.Threading.Tasks;

namespace PdfTool.Processors
{
    internal interface IProcessor
    {
        Task ExecuteAsync(ProcessorArgs args);
    }
}
