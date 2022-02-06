using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;

namespace PdfTool.Processors
{
    internal class CompressProcessor
    {
        public static void Compress(string inputPath, string outputPath)
        {
            using (PdfDocument pdfDocument = new PdfDocument(new PdfReader(inputPath), new PdfWriter(outputPath)))
            {
                pdfDocument.GetWriter().SetCompressionLevel(CompressionConstants.BEST_COMPRESSION);

                pdfDocument.GetWriter().SetCloseStream(false);

                Document doc = new Document(pdfDocument);
                doc.Add(new Paragraph("Compressed with PDFTool Cli"));

                doc.Close();
            }
        }
    }
}
