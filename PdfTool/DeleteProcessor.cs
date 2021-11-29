using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas;
using iText.Kernel.Pdf.Xobject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdfTool
{
    internal class DeleteProcessor
    {
        public void Delete(string inputPdfPath, string outputPdfPath, int pageToDelete)
        {
            using (PdfDocument inputPdfDocument = new PdfDocument(new PdfReader(inputPdfPath)))
            using (PdfDocument outputPdfDocument = new PdfDocument(new PdfWriter(outputPdfPath)))
            {
                int pageCount = inputPdfDocument.GetNumberOfPages();

                for (int page = 1; page <= pageCount; page++)
                {
                    if (page != pageToDelete)
                    {
                        PdfPage pdfPage = inputPdfDocument.GetPage(page);
                        PdfFormXObject pageCopy = pdfPage.CopyAsFormXObject(outputPdfDocument);
                        PageSize pageSize = pdfPage.GetPageSize() as PageSize;
                        outputPdfDocument.AddNewPage(pageSize);
                        new PdfCanvas(outputPdfDocument.GetLastPage()).AddXObject(pageCopy, 0, 0);
                    }
                }
            }
        }
    }
}

