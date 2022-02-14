using iText.Kernel.Pdf;
using System.Collections.Generic;
using Path = System.IO.Path;

namespace PdfTool.Processors
{
    internal class CompressProcessor
    {
        public static void Compress(string inputPdfPath)
        {

            var outputPdfPath = $"{Path.GetDirectoryName(inputPdfPath)}/{Path.GetFileNameWithoutExtension(inputPdfPath)}_compressed.pdf";

            using PdfDocument pdfDocument = new PdfDocument(new PdfReader(inputPdfPath));
            using PdfDocument pdfDocOptimized = new PdfDocument(new PdfWriter(outputPdfPath));
            pdfDocOptimized.GetWriter().SetCompressionLevel(CompressionConstants.BEST_COMPRESSION);
            pdfDocOptimized.GetWriter().SetSmartMode(true);

            HashSet<PdfObject> usedObjects = new HashSet<PdfObject>();

            for (int page = 1; page <= pdfDocument.GetNumberOfPages(); page++)
            {
                PdfPage pdfPage = pdfDocument.GetPage(page);
                usedObjects.Add(pdfPage.GetPdfObject());

                pdfDocOptimized.AddPage(pdfDocument.GetPage(page).CopyTo(pdfDocOptimized));
            }
        }
    }
}
