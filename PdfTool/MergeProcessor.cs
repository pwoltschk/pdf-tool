using iText.Kernel.Pdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdfTool
{
    internal class MergeProcessor
    {
        void Merge(string pdf1, string pdf2)
        {
            string outputPdfPath = "file_merged.pdf"; 

            using (PdfDocument mergedPdfDocument = new PdfDocument(new PdfWriter(outputPdfPath)))
            {
                foreach (string pdfFile in new[] { pdf1, pdf2 })
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
