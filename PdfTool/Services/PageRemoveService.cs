using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas;
using iText.Kernel.Pdf.Xobject;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace PdfTool.Services
{
    internal class PageRemoveService : IPageRemoveService
    {
        public async Task RemovePages(string inputPdfPath, string outputPdfPath, params int[] pages)
        {
            await Task.Run(() =>
            {
                using PdfDocument inputPdfDocument = new(new PdfReader(inputPdfPath));
                using PdfDocument outputPdfDocument = new(new PdfWriter(outputPdfPath));
                int pageCount = inputPdfDocument.GetNumberOfPages();

                for (int page = 1; page <= pageCount; page++)
                {
                    if (!pages.Contains(page))
                    {
                        PdfPage pdfPage = inputPdfDocument.GetPage(page);
                        PdfFormXObject pageCopy = pdfPage.CopyAsFormXObject(outputPdfDocument);
                        Rectangle rectangle = pdfPage.GetPageSize();
                        PageSize pageSize = new(rectangle);
                        outputPdfDocument.AddNewPage(pageSize);
                        new PdfCanvas(outputPdfDocument.GetLastPage()).AddXObjectAt(pageCopy, 0, 0);
                    }
                }
            });
        }
    }
}
