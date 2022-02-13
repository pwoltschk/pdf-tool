using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using Path = System.IO.Path;

namespace PdfTool.Processors
{
    internal class CompressProcessor
    {
        public static void Compress(string inputPdfPath)
        {
            var outputPdfPath = $"{Path.GetDirectoryName(inputPdfPath)}/{Path.GetFileNameWithoutExtension(inputPdfPath)}_compressed.pdf";

            using PdfDocument pdfDocument = new PdfDocument(new PdfReader(inputPdfPath), new PdfWriter(outputPdfPath));
            pdfDocument.GetWriter().SetCompressionLevel(CompressionConstants.BEST_COMPRESSION);

            pdfDocument.GetWriter().SetCloseStream(false);

            Document doc = new Document(pdfDocument);
            doc.Add(new Paragraph("Compressed with PDFTool Cli"));

            doc.Close();
        }
    }
}
