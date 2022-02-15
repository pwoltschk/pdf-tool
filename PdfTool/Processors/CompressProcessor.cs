using iText.Kernel.Pdf;
using Path = System.IO.Path;

namespace PdfTool.Processors
{
    internal class CompressProcessor
    {
        public static void Compress(string inputPdfPath)
        {
            var outputPdfPath = $"{Path.GetDirectoryName(inputPdfPath)}/{Path.GetFileNameWithoutExtension(inputPdfPath)}_compressed.pdf";

            var writerProperties = new WriterProperties();
            writerProperties.SetFullCompressionMode(true);
            writerProperties.SetCompressionLevel(CompressionConstants.BEST_COMPRESSION);

            using PdfDocument pdfDocument = new PdfDocument(new PdfReader(inputPdfPath));
            using PdfDocument pdfDocOptimized = new PdfDocument(new PdfWriter(outputPdfPath, writerProperties));
            pdfDocOptimized.GetWriter().SetSmartMode(true);


            for (int page = 1; page <= pdfDocument.GetNumberOfPages(); page++)
            {
                PdfPage pdfPage = pdfDocument.GetPage(page);

                pdfDocOptimized.AddPage(pdfDocument.GetPage(page).CopyTo(pdfDocOptimized));
            }
        }
    }
}
