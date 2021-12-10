using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas;
using iText.Kernel.Pdf.Xobject;
using System.Linq;
using Path = System.IO.Path;

namespace PdfTool
{
    internal class DeleteProcessor
    {
        public void Delete(string inputPdfPath, int pageToDelete)
        {
            var outputPdfPath = $"{Path.GetDirectoryName(inputPdfPath)}/{Path.GetFileNameWithoutExtension(inputPdfPath)}_removedPage{pageToDelete}.pdf";

            DeletePages(inputPdfPath, outputPdfPath, pageToDelete);
        }

        public void Delete(string inputPdfPath, int fromPage, int toPage)
        {
            var pagesToDelete = Enumerable.Range(fromPage, toPage - fromPage + 1);
            var outputPdfPath = $"{Path.GetDirectoryName(inputPdfPath)}/{Path.GetFileNameWithoutExtension(inputPdfPath)}_removedPage{fromPage}-{toPage}.pdf";

            DeletePages(inputPdfPath, outputPdfPath, pagesToDelete.ToArray());
        }

        private static void DeletePages(string inputPdfPath, string outputPdfPath, params int[] pages)
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

