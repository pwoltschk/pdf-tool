using PdfTool.Processors.Adapter;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace PdfTool.Processors
{
    internal class MergeProcessor : IProcessor
    {
        private readonly IPdfReader _pdfReader;
        private readonly IPdfWriter _pdfWriter;

        public MergeProcessor(IPdfReader pdfReader, IPdfWriter pdfWriter)
        {
            _pdfReader = pdfReader;
            _pdfWriter = pdfWriter;
        }

        public async Task ExecuteAsync(ProcessorArgs args)
        {
            await Merge(args.ReferencePaths.ToArray());
        }


        private async Task Merge(params string[] pdf)
        {
            var outputPdfPath = Path.GetFullPath(pdf.First());

            await Task.Run(() =>
            {
                using var mergedPdfDocument = _pdfWriter.Write($"{outputPdfPath}_merged.pdf");
                foreach (var pdfFile in pdf)
                {
                    using var pdfDocument = _pdfReader.Read(pdfFile);
                    var pageCount = pdfDocument.GetNumberOfPages();
                    for (var page = 1; page <= pageCount; page++)
                    {
                        var pdfPage = pdfDocument.GetPage(page);
                        mergedPdfDocument.AddPage(pdfPage.CopyTo(mergedPdfDocument));
                    }
                }
            });
        }
    }
}
