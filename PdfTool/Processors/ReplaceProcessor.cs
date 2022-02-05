using iText.Kernel.Pdf;
using System;
using Path = System.IO.Path;

namespace PdfTool.Processors
{
    internal class ReplaceProcessor
    {
        public static void Replace(string inputPdfPath, int page1, int page2)
        {
            var outputPdfPath = $"{Path.GetDirectoryName(inputPdfPath)}/{Path.GetFileNameWithoutExtension(inputPdfPath)}_replacedPage{page1}with{page2}.pdf";

            using PdfDocument inputDocument = new PdfDocument(new PdfReader(inputPdfPath));
            using PdfDocument outputDocument = new PdfDocument(new PdfWriter(outputPdfPath));
            int pageCount = inputDocument.GetNumberOfPages();

            if (page1 < 1 || page2 < 1 || page1 > pageCount || page2 > pageCount)
            {
                throw new ArgumentException("Invalid page numbers. Both page1 and page2 should be valid page numbers.");
            }

            for (int page = 1; page <= pageCount; page++)
            {
                if (page == page1)
                {
                    PdfPage pageToSwap = inputDocument.GetPage(page2).CopyTo(outputDocument);
                    outputDocument.AddPage(pageToSwap);
                }
                else if (page == page2)
                {
                    PdfPage pageToSwap = inputDocument.GetPage(page1).CopyTo(outputDocument);
                    outputDocument.AddPage(pageToSwap);
                }
                else
                {
                    PdfPage currentPage = inputDocument.GetPage(page).CopyTo(outputDocument);
                    outputDocument.AddPage(currentPage);
                }
            }
        }
    }
}
