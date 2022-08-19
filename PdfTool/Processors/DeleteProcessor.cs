using PdfTool.Services;
using System.Linq;
using System.Threading.Tasks;
using Path = System.IO.Path;

namespace PdfTool.Processors
{
    internal class DeleteProcessor
    {
        private readonly IPageRemoveService _pageRemoveService;

        public DeleteProcessor(IPageRemoveService pageRemoveService)
        {
            _pageRemoveService = pageRemoveService;
        }

        public async Task Delete(string inputPdfPath, int pageToDelete)
        {
            var outputPdfPath = $"{Path.GetDirectoryName(inputPdfPath)}/{Path.GetFileNameWithoutExtension(inputPdfPath)}_removedPage{pageToDelete}.pdf";

            await _pageRemoveService.RemovePages(inputPdfPath, outputPdfPath, pageToDelete);
        }

        public async Task Delete(string inputPdfPath, int fromPage, int toPage)
        {
            var pagesToDelete = Enumerable.Range(fromPage, toPage - fromPage + 1);
            var outputPdfPath = $"{Path.GetDirectoryName(inputPdfPath)}/{Path.GetFileNameWithoutExtension(inputPdfPath)}_removedPage{fromPage}-{toPage}.pdf";

            await _pageRemoveService.RemovePages(inputPdfPath, outputPdfPath, pagesToDelete.ToArray());
        }
    }
}

