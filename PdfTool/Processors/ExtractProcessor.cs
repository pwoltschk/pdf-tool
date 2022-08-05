using PdfTool.Processors.Adapter;
using PdfTool.Services;
using System.Linq;
using System.Threading.Tasks;
using Path = System.IO.Path;

namespace PdfTool.Processors
{
    internal class ExtractProcessor
    {
        private readonly IPageRemoveService _pageRemoveService;
        private readonly IPdfReader _pdfReader;

        public ExtractProcessor(IPageRemoveService pageRemoveService, IPdfReader pdfReader)
        {
            _pageRemoveService = pageRemoveService;
            _pdfReader = pdfReader;
        }

        public async Task Extract(string inputPdfPath, int fromPage, int toPage)
        {
            int pageCount = GetPageCount(inputPdfPath);
            var totalPages = Enumerable.Range(1, pageCount);
            var pagesToExtract = Enumerable.Range(fromPage, toPage - fromPage + 1);

            var pagesToDelete = totalPages.Except(pagesToExtract);

            var outputPdfPath = $"{Path.GetDirectoryName(inputPdfPath)}/{Path.GetFileNameWithoutExtension(inputPdfPath)}_extractedPages{fromPage}-{toPage}.pdf";

            _pageRemoveService.RemovePages(inputPdfPath, outputPdfPath, pagesToDelete.ToArray());
        }

        private int GetPageCount(string pdfFilePath)
        {
            using IPdfDocument pdfDocument = _pdfReader.GetPdfDocument(pdfFilePath);
            return pdfDocument.GetNumberOfPages();
        }
    }
}
