using PdfTool.Processors.Adapter;
using System.Linq;
using System.Threading.Tasks;

namespace PdfTool.Services
{
    public class PageRemoveService : IPageRemoveService
    {
        private readonly IPdfReader _pdfReader;
        private readonly IPdfWriter _pdfWriter;

        public PageRemoveService(IPdfReader pdfReader, IPdfWriter pdfWriter)
        {
            _pdfReader = pdfReader;
            _pdfWriter = pdfWriter;
        }


        public async Task RemovePages(string inputPdfPath, string outputPdfPath, params int[] pages)
        {
            await Task.Run(() =>
            {
                using var inputPdfDocument = _pdfReader.Read(inputPdfPath);
                using var outputPdfDocument = _pdfWriter.Write(outputPdfPath);
                var pageCount = inputPdfDocument.GetNumberOfPages();

                for (var page = 1; page <= pageCount; page++)
                {
                    if (pages.Contains(page))
                        continue;

                    var pdfPage = inputPdfDocument.GetPage(page);
                    outputPdfDocument.AddNewPage(pdfPage);
                }
            });
        }
    }
}
