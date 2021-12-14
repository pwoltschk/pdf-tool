using iText.Kernel.Geom;
using iText.Kernel.Pdf.Canvas;
using iText.Kernel.Pdf.Xobject;
using iText.Kernel.Pdf;
using System;
using System.Linq;

namespace PdfTool.Services
{
    internal class PageRemoveService : IPageRemoveService
    {
        public void RemovePages(string inputPdfPath, string outputPdfPath, params int[] pages)
        {
            using (PdfDocument inputPdfDocument = new PdfDocument(new PdfReader(inputPdfPath)))
            using (PdfDocument outputPdfDocument = new PdfDocument(new PdfWriter(outputPdfPath)))
            {
                int pageCount = inputPdfDocument.GetNumberOfPages();

                for (int page = 1; page <= pageCount; page++)
                {
                    if (!pages.Contains(page))
                    {
                        PdfPage pdfPage = inputPdfDocument.GetPage(page);
                        PdfFormXObject pageCopy = pdfPage.CopyAsFormXObject(outputPdfDocument);
                        Rectangle rectangle = pdfPage.GetPageSize();
                        PageSize pageSize = new PageSize(rectangle);
                        outputPdfDocument.AddNewPage(pageSize);
                        new PdfCanvas(outputPdfDocument.GetLastPage()).AddXObjectAt(pageCopy, 0, 0);
                    }
                }
            }
        }
    }
}
