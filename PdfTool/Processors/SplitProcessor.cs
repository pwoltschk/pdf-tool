using iText.Kernel.Pdf;
using System.IO;
using Path = System.IO.Path;

namespace PdfTool.Processors
{
    internal class SplitProcessor
    {
        public void Split(string fullPath)
        {
            var directory = Path.GetDirectoryName(fullPath);

            var filename = Path.GetFileNameWithoutExtension(fullPath);

            var outputDirectory = Path.Combine(directory, filename);

            Directory.CreateDirectory(outputDirectory);

            using (PdfDocument pdfDocument = new PdfDocument(new PdfReader(fullPath)))
            {
                for (int page = 1; page <= pdfDocument.GetNumberOfPages(); page++)
                {
                    string outputPdfPath = Path.Combine(outputDirectory, $"{filename}_{page}.pdf");

                    using (PdfDocument outputDocument = new PdfDocument(new PdfWriter(outputPdfPath)))
                    {
                        pdfDocument.CopyPagesTo(page, page, outputDocument);
                    }
                }

            }
        }
    }
}
