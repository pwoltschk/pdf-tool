using PdfTool.Processors.Adapter;
using PdfTool.Services;
using System.Linq;
using System.Threading.Tasks;
using Path = System.IO.Path;

namespace PdfTool.Processors
{
    internal class ExtractProcessor : IProcessor
    {
        private readonly IPageRemoveService _pageRemoveService;
        private readonly IPdfReader _pdfReader;

        public ExtractProcessor(IPageRemoveService pageRemoveService, IPdfReader pdfReader)
        {
            _pageRemoveService = pageRemoveService;
            _pdfReader = pdfReader;
        }

        public async Task ExecuteAsync(ProcessorArgs args)
        {
            await Extract(args.ReferencePaths.Single(), args.FromPage, args.ToPage);
        }

        public async Task Extract(string inputPdfPath, int fromPage, int toPage)
        {
            var pageCount = GetPageCount(inputPdfPath);
            var totalPages = Enumerable.Range(1, pageCount);
            var pagesToExtract = Enumerable.Range(fromPage, toPage - fromPage + 1);

            var pagesToDelete = totalPages.Except(pagesToExtract);

            var outputPdfPath = $"{Path.GetDirectoryName(inputPdfPath)}/{Path.GetFileNameWithoutExtension(inputPdfPath)}_extractedPages{fromPage}-{toPage}.pdf";

            await _pageRemoveService.RemovePages(inputPdfPath, outputPdfPath, pagesToDelete.ToArray());
        }

        private int GetPageCount(string pdfFilePath)
        {
            using var pdfDocument = _pdfReader.Read(pdfFilePath);
            return pdfDocument.GetNumberOfPages();
        }
    }
}
