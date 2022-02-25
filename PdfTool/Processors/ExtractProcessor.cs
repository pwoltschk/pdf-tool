using iText.Kernel.Pdf;
using PdfTool.Services;
using System.Linq;
using Path = System.IO.Path;

namespace PdfTool.Processors
{
    internal class ExtractProcessor
    {
        private readonly IPageRemoveService _pageRemoveService;

        public ExtractProcessor(IPageRemoveService pageRemoveService)
        {
            _pageRemoveService = pageRemoveService;
        }

        public void Extract(string inputPdfPath, int fromPage, int toPage)
        {
            int pageCount = GetPageCount(inputPdfPath);
            var totalPages = Enumerable.Range(1, pageCount);
            var pagesToExtract = Enumerable.Range(fromPage, toPage - fromPage + 1);

            var pagesToDelete = totalPages.Except(pagesToExtract);

            var outputPdfPath = $"{Path.GetDirectoryName(inputPdfPath)}/{Path.GetFileNameWithoutExtension(inputPdfPath)}_extractedPages{fromPage}-{toPage}.pdf";

            _pageRemoveService.RemovePages(inputPdfPath, outputPdfPath, pagesToDelete.ToArray());
        }

        private static int GetPageCount(string pdfFilePath)
        {
            using PdfDocument pdfDocument = new PdfDocument(new PdfReader(pdfFilePath));
            return pdfDocument.GetNumberOfPages();
        }
    }
}
