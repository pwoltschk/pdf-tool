using iText.Kernel.Pdf;
using System.IO;
using Path = System.IO.Path;

namespace PdfTool
{
    internal class SplitProcessor
    {
        public void Split(string fullPath)
        {
            var directory = Path.GetDirectoryName(fullPath);

            var outputDirectory = Path.Combine(directory, Path.GetFileNameWithoutExtension(fullPath));

            Directory.CreateDirectory(outputDirectory);

            using (PdfDocument pdfDocument = new PdfDocument(new PdfReader(fullPath)))
            {
                for (int page = 1; page <= pdfDocument.GetNumberOfPages(); page++)
                {
                    string outputPdfPath = Path.Combine(outputDirectory, $"page_{page}.pdf");

                    using (PdfDocument outputDocument = new PdfDocument(new PdfWriter(outputPdfPath)))
                    {
                        pdfDocument.CopyPagesTo(page, page, outputDocument);
                    }
                }
            }
        }
    }
}
