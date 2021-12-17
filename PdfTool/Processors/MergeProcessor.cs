using iText.Kernel.Pdf;
using System.IO;
using System.Linq;

namespace PdfTool.Processors
{
    internal class MergeProcessor
    {
        public void Merge(params string[] pdf)
        {
            var outputPdfPath = Path.GetFullPath(pdf.First());

            using (PdfDocument mergedPdfDocument = new PdfDocument(new PdfWriter($"{outputPdfPath}_merged.pdf")))
            {
                foreach (string pdfFile in pdf)
                {
                    using (PdfDocument pdfDocument = new PdfDocument(new PdfReader(pdfFile)))
                    {
                        int pageCount = pdfDocument.GetNumberOfPages();
                        for (int page = 1; page <= pageCount; page++)
                        {
                            PdfPage pdfPage = pdfDocument.GetPage(page);
                            mergedPdfDocument.AddPage(pdfPage.CopyTo(mergedPdfDocument));
                        }
                    }
                }
            }
        }
    }
}
