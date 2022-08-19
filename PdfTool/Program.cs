using PdfTool.Processors;
using PdfTool.Processors.Adapter;

namespace PdfTool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            new MergeProcessor(new PdfReaderAdapter(), new PdfWriterAdapter()).Merge("C:\\Users\\wopa\\Documents\\starvpn\\starvpn_1.pdf", "C:\\Users\\wopa\\Documents\\starvpn\\starvpn_2.pdf");
        }
    }
}